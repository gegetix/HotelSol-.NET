using Producto_2.Controlador;
using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Producto_2.Vista
{
    public partial class Form7Reservas : Form
    {
        private readonly ClienteReservas7 reservas = new ClienteReservas7();
        
        public Form7Reservas()
        {
            InitializeComponent();
            this.Move += new EventHandler(frm_Move);

        }
        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        public void cargarDatos() {

            try
            {
                DateTime ahora = DateTime.Now;

                List<Reservas> historicoReservas = reservas.obtenerHistoricoReservas();

                List<Reservas> reservasFiltradasIN = historicoReservas.Where(r => r.firmado == 0).ToList();
                List<Reservas> reservasFiltradasOUT = historicoReservas.Where(r => r.firmado == 1).ToList();
                List<Reservas> reservasFiltradasFalse = historicoReservas.ToList();


                checkoutHDG.DataSource = reservasFiltradasOUT;

                chinDG.DataSource = reservasFiltradasIN;
                pendDG.DataSource = reservasFiltradasFalse;



                //checkout

                checkoutHDG.Columns["temporadaID"].Visible = false;
                checkoutHDG.Columns["pensionID"].Visible = false;
                checkoutHDG.Columns["fechaEntrada"].Visible = false;
                checkoutHDG.Columns["firmado"].Visible = false;


                checkoutHDG.Columns["numeroHabitacion"].HeaderText = "Nº Habitacion";
                checkoutHDG.Columns["numeroHabitacion"].Width = 100;

                checkoutHDG.Columns["reservaID"].HeaderText = "Reserva";

                checkoutHDG.Columns["fechaSalida"].HeaderText = "Fecha Salida";
                checkoutHDG.Columns["fechaSalida"].Width = 143;



                //checkin

                chinDG.Columns["temporadaID"].Visible = false;
                chinDG.Columns["pensionID"].Visible = false;
                chinDG.Columns["fechaSalida"].Visible = false;
                chinDG.Columns["firmado"].Visible = false;

                chinDG.Columns["numeroHabitacion"].HeaderText = "Nº Habitacion";
                chinDG.Columns["numeroHabitacion"].Width = 100;

                chinDG.Columns["reservaID"].HeaderText = "Reserva";

                chinDG.Columns["fechaEntrada"].HeaderText = "Fecha Entrada";
                chinDG.Columns["fechaEntrada"].Width = 143;


                foreach (DataGridViewRow fila in chinDG.Rows)
                {
                    if (fila.Cells["firmado"].Value == null || fila.Cells["firmado"].Equals(false))
                    {
                        fila.Visible = false;
                    }

                }

                // pendiente
                pendDG.Columns["temporadaID"].Visible = false;
                pendDG.Columns["pensionID"].Visible = false;

                pendDG.Columns["reservaID"].HeaderText = "Nº";
                pendDG.Columns["reservaID"].Width = 42;

                pendDG.Columns["firmado"].HeaderText = "Firmado";
                pendDG.Columns["firmado"].Width = 60;

                pendDG.Columns["numeroHabitacion"].HeaderText = "Hab";
                pendDG.Columns["numeroHabitacion"].Width = 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form7Reservas_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }



        private void nuevaReservaBTN_Click(object sender, EventArgs e)
        {
            InterfazReserva reservaI = new InterfazReserva();


            reservaI.MdiParent = this.MdiParent;
            reservaI.Show();
            this.Close();
            
        }

        private void firmaBTN_Click(object sender, EventArgs e)
        {
            
            if (chinDG.SelectedRows.Count > 0) { 
            
                
                DataGridViewRow row = chinDG.SelectedRows[0];

                if (row != null)


                {

                    Reservas reservaSeleccionada = (Reservas)row.DataBoundItem;

                    row.Cells["firmado"].Value = Convert.ToByte(1);
                    try
                    {
                        
                        using (var db = new dbHotelSQLEntities())
                        {
                           
                            db.Reservas.Attach(reservaSeleccionada);

                            db.Entry(reservaSeleccionada).Property(r => r.firmado).IsModified = true;

                        
                            db.SaveChanges();
                        }

                      
                        chinDG.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar cambios en la base de datos: " + ex.Message);
                    }

                }
            }
            MessageBox.Show("Campos actualizados");
            cargarDatos();
        }
        


    }
}
