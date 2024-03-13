using Producto_2.Modelo;
using Producto_2.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
namespace Producto_2.Vista
{
    public partial class frmExportarAOdoo : Form
    {
        public generadorXMLcontrolador controlador = new generadorXMLcontrolador();
        private dbHotelSQLEntities db;

        public frmExportarAOdoo()
        {
            InitializeComponent();
            db = new dbHotelSQLEntities();
            this.Move += new EventHandler(frm_Move);
        }

        private void frm_Move(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void frmExportarAOdoo_Load(object sender, EventArgs e)
        {

        }

        private void cargarGrid(String tabla)
        {
            if (tabla == "Clientes")
            {
                var tbl = ConsultarTabla<Clientes>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "Reservas")
            {

                var tbl = ConsultarTabla<Reservas>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "Habitacion")
            {
                var tbl = ConsultarTabla<Habitacion>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "Factura")
            {
                var tbl = ConsultarTabla<Factura>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "Servicio")
            {
                var tbl = ConsultarTabla<Servicio>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "Temporada")
            {
                var tbl = ConsultarTabla<Temporada>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "TipoHabitacion")
            {
                var tbl = ConsultarTabla<TipoHabitacion>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "RegimenPension")
            {
                var tbl = ConsultarTabla<RegimenPension>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "historicoReservas")
            {
                var tbl = ConsultarTabla<historicoReservas>(tabla);
                dbgTables.DataSource = tbl;
            }
            else if (tabla == "HistoricoServicios")
            {
                var tbl = ConsultarTabla<HistoricoServicios>(tabla);
                dbgTables.DataSource = tbl;
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null)
            {
                string selectedTable = cmbTables.SelectedItem.ToString();

                cargarGrid(selectedTable);


            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna tabla.");
            }
        }
   
        private List<T> ConsultarTabla<T>(string tableName) where T : class
        {
            using (dbHotelSQLEntities dbContext = new dbHotelSQLEntities())
            {
                // Construimos la consulta SQL dinámica
                string sqlQuery = $"SELECT * FROM {tableName}";

                // Ejecutamos la consulta y convertimos los resultados a una lista del tipo T
                List<T> result = dbContext.Database.SqlQuery<T>(sqlQuery).ToList();

                return result;
            }
        }

        private void btnExportarAOdoo_Click(object sender, EventArgs e)
        {
            if (dbgTables.DataSource != null)
            {
                string selectedTable = cmbTables.SelectedItem.ToString();
                var data = (IEnumerable<object>)dbgTables.DataSource;

                if (data.Any())
                {
                    string appFolderPath = AppDomain.CurrentDomain.BaseDirectory;
                    string archivo = (selectedTable + ".XML");
                    string filePath = Path.Combine(appFolderPath, archivo);

                    var datosExportados = new DatosExportados<object>();
                    datosExportados.Elementos.AddRange(data);

                    System.Xml.Serialization.XmlSerializer serializador = new System.Xml.Serialization.XmlSerializer(typeof(DatosExportados<object>));

                    using (System.IO.FileStream flujo = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
                    {
                        serializador.Serialize(flujo, datosExportados);
                       // MessageBox.Show("Los datos se han exportado exitosamente a un archivo XML.");
                        EjecutarScriptPython(selectedTable);
                        flujo.Close();
                        System.IO.File.Delete(filePath);
                        MessageBox.Show("Datos exportados con exito");
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna tabla");
            }
        }

        private void EjecutarScriptPython(String tabla)
        {
            string pythonPath = @"python.exe";


            if (string.IsNullOrEmpty(pythonPath))
            {
                MessageBox.Show("La variable de entorno Python no esta configurada");
                return;
            }

            string scriptPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "importarOdooXML.py");
            string scriptArguments = tabla;

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"{scriptPath} {scriptArguments}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo = startInfo
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string error = process.StandardError.ReadToEnd();

            if (error != null)
            {
                MessageBox.Show($"Error: {error}");

            }
            else
            {
                MessageBox.Show(output);
            }
            process.Close();
        }

        private String EjecutarScriptPythonTraer(String tabla)
        {
            string pythonPath = @"python.exe";


            if (string.IsNullOrEmpty(pythonPath))
            {
                MessageBox.Show("La variable de entorno Python no esta configurada");
                return "None";
            }

            string scriptPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "ExportarHotelXML.py");
            string scriptArguments = tabla;

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"{scriptPath} {scriptArguments}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo = startInfo
            };

            process.Start();
          
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string error = process.StandardError.ReadToEnd();
            
            if (error != null)
            {
                MessageBox.Show($"Error: {error}");

            }
            else
            {
                MessageBox.Show(output);
            }
            
            process.Close();
            return output;
        }

        private void btnImportarDeOdoo_Click(object sender, EventArgs e)
        {
            if (dbgTables.DataSource != null)
            {
                string selectedTable = cmbTables.SelectedItem.ToString();

                EjecutarScriptPythonTraer(selectedTable);
                InsertXmlDataIntoMySQL(selectedTable);

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna tabla");
            }
        }

        public void InsertXmlDataIntoMySQL(string tabla)
        {
            String directoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (tabla == "Reservas")
            {
                String path = System.IO.Path.Combine(directoryPath, "reservaExportar.xml");
               // MessageBox.Show(path);
                controlador.ImportarReservasXML(path);

            }
            else if (tabla == "Clientes")
            {
                String path = System.IO.Path.Combine(directoryPath, "clienteExportar.xml");
                //MessageBox.Show(path);
                controlador.ImportarClienteXML(path);
            }
            else if (tabla == "RegimenPension")
            {
                String path = System.IO.Path.Combine(directoryPath, "regimenExportar.xml");
                //MessageBox.Show(path);
                controlador.ImportarRegimenPensionXML(path);
            }
            else if (tabla == "Habitacion")
            {
                String path = System.IO.Path.Combine(directoryPath, "habitacionExportar.xml");
               // MessageBox.Show(path);
                controlador.ImportarHabitacionXML(path);
            }
            else if (tabla == "Servicio")
            {
                String path = System.IO.Path.Combine(directoryPath, "servicioExportar.xml");
                //MessageBox.Show(path);
                controlador.ImportarServicioXML(path);
            }
            else if (tabla == "Temporada")
            {
                String path = System.IO.Path.Combine(directoryPath, "temporadaExportar.xml");
                //MessageBox.Show(path);
                controlador.ImportarTemporadaXML(path);
            }
            else if (tabla == "TipoHabitacion")
            {
                String path = System.IO.Path.Combine(directoryPath, "thabitacionExportar.xml");
                //MessageBox.Show(path);
                controlador.ImportarTipoHabitacionXML(path);
            }

            dbgTables.DataSource = null;
            cargarGrid(tabla);
            MessageBox.Show("Datos importados con exito.");
        }
    }
}
