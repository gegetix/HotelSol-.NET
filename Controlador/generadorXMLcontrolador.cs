using Microsoft.VisualBasic.ApplicationServices;
using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Producto_2.Controlador
{
    public class generadorXMLcontrolador
    {


        public XmlDocument xmlDoc = new XmlDocument();
        public XmlElement rootNode;
        public ClienteControlador controladorCliente = new ClienteControlador();
        public HabitacionesControlador controladorHabitacion = new HabitacionesControlador();
        public FacturaControlador controladorFactura = new FacturaControlador();
        public addServiciosControlador controladorServicio = new addServiciosControlador();
        public ReservaControlador controladorReserva = new ReservaControlador();
        public UtenticacionControlador controladorUsuario = new UtenticacionControlador();


        public generadorXMLcontrolador()
        {

            rootNode = xmlDoc.CreateElement("Hotel_SOL");
            xmlDoc.AppendChild(rootNode);
        }

        // Exportar
        public void exportarXML()


        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootNode;
            rootNode = xmlDoc.CreateElement("Hotel_SOL");
            xmlDoc.AppendChild(rootNode);

            generadorXMLcontrolador xml = new generadorXMLcontrolador();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;


                List<Clientes> listaClientes = new List<Clientes>();
                listaClientes = controladorCliente.ObtenerClientes();
                List<Habitacion> listaHabitacion = new List<Habitacion>();
                listaHabitacion = controladorHabitacion.ObtenerHabitaciones();
                List<Factura> listaFactura = new List<Factura>();
                listaFactura = controladorFactura.ObtenerFactura();
                List<HistoricoServicios> listaHistoircoServicios = new List<HistoricoServicios>();
                listaHistoircoServicios = new ServiciosControlador11().historicoServicios();
                List<RegimenPension> listaRegimenPension = new List<RegimenPension>();
                listaRegimenPension = controladorFactura.BuscarRegimenesPension();
                List<Reservas> listaReservas = new List<Reservas>();
                listaReservas = controladorReserva.ObtenerReserva();
                List<Servicio> listaServicios = new List<Servicio>();
                listaServicios = new ServiciosControlador11().obtenerServicios();
                List<Temporada> listaTemporada = new List<Temporada>();
                listaTemporada = controladorFactura.ObtenerTemporadas();
                List<TipoHabitacion> listaTipoHabitacion = new List<TipoHabitacion>();
                listaTipoHabitacion = controladorHabitacion.ObtenerTiposDeHabitacion();
                List<Usuario> listaUsuario = new List<Usuario>();
                listaUsuario = controladorUsuario.ObtenerUsuarios();

                using (XmlWriter writer = XmlWriter.Create(rutaArchivo))
                {

                    writer.WriteStartDocument();
                    writer.WriteStartElement("Hotel_SOL");

                    ExportarRegimenPensionXML(listaRegimenPension, writer);
                    ExportarTemporadaXML(listaTemporada, writer);
                    ExportarUsuarioXML(listaUsuario, writer);
                    ExportarServicioXML(listaServicios, writer);
                    ExportarClientesXML(listaClientes, writer);
                    ExportarTipoHabitacionXML(listaTipoHabitacion, writer);
                    ExportarhabitacionXML(listaHabitacion, writer);
                    ExportarFacturaXML(listaFactura, writer);
                    ExportarHistoricoServiciosXML(listaHistoircoServicios, writer);
                    ExportarReservaXML(listaReservas, writer);




                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }

                MessageBox.Show("Datos exportados con éxito!");
            }
        }
        public void ExportarClientesXML(List<Clientes> listaClientes, XmlWriter writer)
        {
            if (writer == null || listaClientes == null) return;
            writer.WriteStartElement("Clientes");

            foreach (var clientes in listaClientes)
            {
                writer.WriteStartElement("Cliente");
                writer.WriteElementString("NIF", clientes.NIF.ToString());
                writer.WriteElementString("nombre", clientes.nombre.ToString());
                writer.WriteElementString("apellidos", clientes.apellidos.ToString());
                writer.WriteElementString("telefono", clientes.telefono.ToString());
                writer.WriteElementString("email", clientes.email.ToString());
                writer.WriteElementString("VIP", clientes.VIP.ToString());
                writer.WriteElementString("direccion", clientes.direccion.ToString());
                writer.WriteElementString("ciudad", clientes.ciudad.ToString());
                writer.WriteElementString("cp", clientes.cp.ToString());
                writer.WriteElementString("pais", clientes.pais.ToString());
                writer.WriteElementString("fechaN", clientes.fechaN.ToString());
                if (clientes.detalle != null)
                {
                    writer.WriteElementString("detalle", clientes.detalle.ToString());
                }

                writer.WriteElementString("nombreCuenta", clientes.nombreCuenta.ToString());
                writer.WriteElementString("numeroCuenta", clientes.numeroCuenta.ToString());
                writer.WriteElementString("fechaAlta", clientes.fechaAlta.ToString());

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarhabitacionXML(List<Habitacion> listHabitacion, XmlWriter writer)
        {


            // Si el archivo no existe, crea un nuevo documento con un nodo raíz

            if (writer == null || listHabitacion == null) return;
            writer.WriteStartElement("Habitaciones");

            foreach (var habitacion in listHabitacion)
            {

                writer.WriteStartElement("Habitacion");
                writer.WriteElementString("numeroHabitacion", habitacion.numeroHabitacion.ToString());
                writer.WriteElementString("descripcion", habitacion.descripcion.ToString());
                writer.WriteElementString("tipoID", habitacion.tipoID.ToString());
                writer.WriteElementString("minNoches", habitacion.minNoches.ToString());
                writer.WriteElementString("maxPersonas", habitacion.maxPersonas.ToString());
                writer.WriteElementString("precioAlta", habitacion.precioAlta.ToString());
                writer.WriteElementString("PrecioMedia", habitacion.PrecioMedia.ToString());
                writer.WriteElementString("precioBaja", habitacion.precioBaja.ToString());
                writer.WriteElementString("fueraServicio", habitacion.fueraServicio.ToString());



                writer.WriteEndElement();

            }
            writer.WriteEndElement();

        }
        public void ExportarFacturaXML(List<Factura> listaFactura, XmlWriter writer)
        {
            if (writer == null || listaFactura == null) return;
            writer.WriteStartElement("Facturas");

            foreach (var factura in listaFactura)
            {
                writer.WriteStartElement("Factura");
                writer.WriteElementString("numeroFactura", factura.numeroFactura.ToString());
                writer.WriteElementString("fechaFactura", factura.fechaFactura.ToString());
                writer.WriteElementString("precioTotal", factura.precioTotal.ToString());
                writer.WriteElementString("servicioID", factura.servicioID.ToString());
                writer.WriteElementString("reservaID", factura.reservaID.ToString());
                writer.WriteElementString("idCliente", factura.idCliente.ToString());

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarHistoricoServiciosXML(List<HistoricoServicios> listaHistoircoServicios, XmlWriter writer)
        {
            if (writer == null || listaHistoircoServicios == null) return;
            writer.WriteStartElement("Historicos");

            foreach (var historicoServicios in listaHistoircoServicios)
            {
                writer.WriteStartElement("Historico_Servicios");
                writer.WriteElementString("idServicio", historicoServicios.idServicio.ToString());
                writer.WriteElementString("reservaID", historicoServicios.reservaID.ToString());
                writer.WriteElementString("historicoID", historicoServicios.historicoID.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarRegimenPensionXML(List<RegimenPension> listaRegimenPension, XmlWriter writer)
        {
            if (writer == null || listaRegimenPension == null) return;
            writer.WriteStartElement("Regimenes");

            foreach (var regimenPension in listaRegimenPension)
            {
                writer.WriteStartElement("Regimen_Pension");
                writer.WriteElementString("pensionID", regimenPension.pensionID.ToString());
                writer.WriteElementString("descripcion", regimenPension.descripcion.ToString());
                writer.WriteElementString("precio", regimenPension.precio.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarReservaXML(List<Reservas> listaReservas, XmlWriter writer)
        {
            if (writer == null || listaReservas == null) return;
            writer.WriteStartElement("Reservas");

            foreach (var reservas in listaReservas)
            {
                writer.WriteStartElement("Reserva");
                writer.WriteElementString("reservaID", reservas.reservaID.ToString());
                writer.WriteElementString("firmado", reservas.firmado.ToString());
                writer.WriteElementString("fechaEntrada", reservas.fechaEntrada.ToString());
                writer.WriteElementString("fechaSalida", reservas.fechaSalida.ToString());
                writer.WriteElementString("NIF", reservas.NIF.ToString());
                writer.WriteElementString("numeroHabitacion", reservas.numeroHabitacion.ToString());
                writer.WriteElementString("temporadaID", reservas.temporadaID.ToString());
                writer.WriteElementString("pensionID", reservas.pensionID.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarServicioXML(List<Servicio> listaServicios, XmlWriter writer)
        {
            if (writer == null || listaServicios == null) return;
            writer.WriteStartElement("Servicios");

            foreach (var servicio in listaServicios)
            {
                writer.WriteStartElement("Servicio");
                writer.WriteElementString("idServicio", servicio.idServicio.ToString());
                writer.WriteElementString("precioServicio", servicio.precioServicio.ToString());
                writer.WriteElementString("descripcion", servicio.descripcion.ToString());
                writer.WriteElementString("tipoServicioID", servicio.tipoServicioID.ToString());
                writer.WriteElementString("precioAlta", servicio.precioAlta.ToString());
                writer.WriteElementString("precioBaja", servicio.precioBaja.ToString());
                writer.WriteElementString("precioMedia", servicio.precioMedia.ToString());
                writer.WriteElementString("permisoAlta", servicio.permisoAlta.ToString());
                writer.WriteElementString("permisoMedia", servicio.permisoMedia.ToString());
                writer.WriteElementString("permisoBaja", servicio.permisoBaja.ToString());
                writer.WriteElementString("descVIP", servicio.descVIP.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarTemporadaXML(List<Temporada> listaTemporada, XmlWriter writer)
        {
            if (writer == null || listaTemporada == null) return;
            writer.WriteStartElement("Temporadas");

            foreach (var temporada in listaTemporada)
            {
                writer.WriteStartElement("Temporada");
                writer.WriteElementString("temporadaID", temporada.temporadaID.ToString());
                writer.WriteElementString("descripcion", temporada.descripcion.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarTipoHabitacionXML(List<TipoHabitacion> listaTipoHabitacion, XmlWriter writer)
        {
            if (writer == null || listaTipoHabitacion == null) return;
            writer.WriteStartElement("Tipos");

            foreach (var tipoHabitacion in listaTipoHabitacion)
            {
                writer.WriteStartElement("Tipo_Habitacion");
                writer.WriteElementString("tipoID", tipoHabitacion.tipoID.ToString());
                writer.WriteElementString("descripcion", tipoHabitacion.descripcion.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        public void ExportarUsuarioXML(List<Usuario> listaUsuario, XmlWriter writer)
        {
            if (writer == null || listaUsuario == null) return;
            writer.WriteStartElement("Usuarios");

            foreach (var usuario in listaUsuario)
            {
                writer.WriteStartElement("Usuario");
                writer.WriteElementString("nombre", usuario.nombre.ToString());
                writer.WriteElementString("usuarioID", usuario.usuarioID.ToString());
                writer.WriteElementString("password", usuario.password.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }




        // Importar
        public void importarXML()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.DefaultExt = "xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                ImportarRegimenPensionXML(rutaArchivo);
                ImportarTemporadaXML(rutaArchivo);
                ImportarUsuarioXML(rutaArchivo);
                ImportarServicioXML(rutaArchivo);
                ImportarClienteXML(rutaArchivo);
                ImportarTipoHabitacionXML(rutaArchivo);
                ImportarHabitacionXML(rutaArchivo);
                ImportarHistoricoServiciosXML(rutaArchivo);
                ImportarReservasXML(rutaArchivo);
                ImportarFacturaXML(rutaArchivo);

            }

            MessageBox.Show("Datos importados y agregados con éxito!");

        }


        public void ImportarClienteXML(String rutaArchivo)
        {


            List<Clientes> listaClientes = new List<Clientes>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Clientes cliente = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                cliente = new Clientes();
                                break;
                            case "NIF":
                                if (cliente != null && !reader.IsEmptyElement) cliente.NIF = reader.ReadString();
                                break;
                            case "nombre":
                                if (cliente != null && !reader.IsEmptyElement) cliente.nombre = reader.ReadString();
                                break;
                            case "apellidos":
                                if (cliente != null && !reader.IsEmptyElement) cliente.apellidos = reader.ReadString();
                                break;
                            case "telefono":
                                if (cliente != null && !reader.IsEmptyElement) cliente.telefono = reader.ReadString();
                                break;
                            case "email":
                                if (cliente != null && !reader.IsEmptyElement) cliente.email = reader.ReadString();
                                break;
                            case "VIP":
                                if (cliente != null && !reader.IsEmptyElement) cliente.VIP = Convert.ToByte(reader.ReadString());
                                break;
                            case "direccion":
                                if (cliente != null && !reader.IsEmptyElement) cliente.direccion = reader.ReadString();
                                break;
                            case "ciudad":
                                if (cliente != null && !reader.IsEmptyElement) cliente.ciudad = reader.ReadString();
                                break;
                            case "cp":
                                if (cliente != null && !reader.IsEmptyElement) cliente.cp = Convert.ToInt32(reader.ReadString());
                                break;
                            case "pais":
                                if (cliente != null && !reader.IsEmptyElement) cliente.pais = reader.ReadString();
                                break;
                            case "fechaN":
                                if (cliente != null && !reader.IsEmptyElement) cliente.fechaN = Convert.ToDateTime(reader.ReadString());
                                break;
                            case "detalle":
                                if (cliente != null && !reader.IsEmptyElement) cliente.detalle = reader.ReadString();
                                break;
                            case "nombreCuenta":
                                if (cliente != null && !reader.IsEmptyElement) cliente.nombreCuenta = reader.ReadString();
                                break;
                            case "numeroCuenta":
                                if (cliente != null && !reader.IsEmptyElement) cliente.numeroCuenta = reader.ReadString();
                                break;
                            case "fechaAlta":
                                if (cliente != null && !reader.IsEmptyElement) cliente.fechaAlta = Convert.ToDateTime(reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (cliente != null)
                        {
                            listaClientes.Add(cliente);
                            cliente = null;
                        }
                    }
                }
                foreach (Clientes cl in listaClientes)
                {
                    controladorCliente.AgregarCliente(cl);

                }
            }

        }

        public void ImportarFacturaXML(String rutaArchivo)
        {
            List<Factura> listaFactura = new List<Factura>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Factura Factura = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                Factura = new Factura();
                                break;

                            case "numeroFactura":
                                if (Factura != null && !reader.IsEmptyElement) Factura.numeroFactura = Convert.ToInt32(reader.ReadString());
                                break;

                            case "fechaFactura":
                                if (Factura != null && !reader.IsEmptyElement) Factura.fechaFactura = Convert.ToDateTime(reader.ReadString());
                                break;
                            case "precioTotal":
                                if (Factura != null && !reader.IsEmptyElement) Factura.precioTotal = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "servicioID":
                                if (Factura != null && !reader.IsEmptyElement) Factura.servicioID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "reservaID":
                                if (Factura != null && !reader.IsEmptyElement) Factura.reservaID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "idCliente":
                                if (Factura != null && !reader.IsEmptyElement) Factura.idCliente = reader.ReadString();

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (Factura != null)
                        {
                            listaFactura.Add(Factura);
                            Factura = null;
                        }
                    }
                }
                foreach (Factura each in listaFactura)
                {

                    controladorFactura.addFactura(each);

                }
            }
        }

        public void ImportarHabitacionXML(String rutaArchivo)
        {
            List<Habitacion> listahaHabitacion = new List<Habitacion>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Habitacion habitacion = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                habitacion = new Habitacion();
                                break;

                            case "numeroHabitacion":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.numeroHabitacion = Convert.ToInt32(reader.ReadString());
                                break;
                            case "descripcion":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.descripcion = reader.ReadString();
                                break;
                            case "tipoID":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.tipoID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "minNoches":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.minNoches = Convert.ToInt32(reader.ReadString());
                                break;
                            case "maxPersonas":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.maxPersonas = Convert.ToInt32(reader.ReadString());
                                break;
                            case "precioAlta":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.precioAlta = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "PrecioMedia":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.PrecioMedia = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "precioBaja":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.precioBaja = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "fueraServicio":
                                if (habitacion != null && !reader.IsEmptyElement) habitacion.fueraServicio = Convert.ToByte(reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (habitacion != null)
                        {
                            listahaHabitacion.Add(habitacion);
                            habitacion = null;
                        }
                    }
                }
                foreach (Habitacion each in listahaHabitacion)
                {

                    controladorHabitacion.AgregarHabitacion(each);


                }
            }
        }

        public void ImportarHistoricoServiciosXML(String rutaArchivo)
        {
            List<HistoricoServicios> listahistoricoServ = new List<HistoricoServicios>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                HistoricoServicios histServ = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                histServ = new HistoricoServicios();
                                break;

                            case "idServicio":
                                if (histServ != null && !reader.IsEmptyElement) histServ.idServicio = Convert.ToInt32(reader.ReadString());
                                break;
                            case "reservaID":
                                if (histServ != null && !reader.IsEmptyElement) histServ.reservaID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "historicoID":
                                if (histServ != null && !reader.IsEmptyElement) histServ.historicoID = Convert.ToInt32(reader.ReadString());


                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (histServ != null)
                        {
                            listahistoricoServ.Add(histServ);
                            histServ = null;
                        }
                    }
                }
                foreach (HistoricoServicios each in listahistoricoServ)
                {

                    controladorServicio.AgregarHistoricoServicio(each);

                }
            }
        }

        public void ImportarRegimenPensionXML(String rutaArchivo)
        {
            List<RegimenPension> listaRegimen = new List<RegimenPension>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                RegimenPension reg = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                reg = new RegimenPension();
                                break;

                            case "pensionID":
                                if (reg != null && !reader.IsEmptyElement) reg.pensionID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "descripcion":
                                if (reg != null && !reader.IsEmptyElement) reg.descripcion = reader.ReadString();
                                break;
                            case "precio":
                                if (reg != null && !reader.IsEmptyElement) reg.precio = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;


                        }

                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (reg != null)
                        {
                            listaRegimen.Add(reg);
                            reg = null;
                        }
                    }


                }
                foreach (RegimenPension each in listaRegimen)
                {

                    controladorFactura.AgregarRegimen(each);

                }
            }
        }

        public void ImportarReservasXML(String rutaArchivo)
        {
            List<Reservas> listaRes = new List<Reservas>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Reservas res = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                res = new Reservas();
                                break;

                            case "reservaID":
                                if (res != null && !reader.IsEmptyElement) res.reservaID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "firmado":
                                if (res != null && !reader.IsEmptyElement) res.firmado = Convert.ToByte(reader.ReadString());
                                break;
                            case "fechaEntrada":
                                if (res != null && !reader.IsEmptyElement) res.fechaEntrada = Convert.ToDateTime(reader.ReadString());
                                break;
                            case "fechaSalida":
                                if (res != null && !reader.IsEmptyElement) res.fechaSalida = Convert.ToDateTime(reader.ReadString());
                                break;
                            case "NIF":
                                if (res != null && !reader.IsEmptyElement) res.NIF = reader.ReadString();
                                break;
                            case "numeroHabitacion":
                                if (res != null && !reader.IsEmptyElement) res.numeroHabitacion = Convert.ToInt32(reader.ReadString());
                                break;
                            case "temporadaID":
                                if (res != null && !reader.IsEmptyElement) res.temporadaID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "pensionID":
                                if (res != null && !reader.IsEmptyElement) res.pensionID = Convert.ToInt32(reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (res != null)
                        {
                            listaRes.Add(res);
                            res = null;
                        }
                    }

                }
                foreach (Reservas each in listaRes)
                {

                    controladorReserva.AgregarReserva(each);

                }
            }
        }


        public void ImportarServicioXML(String rutaArchivo)
        {
            List<Servicio> listaSer = new List<Servicio>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Servicio ser = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                ser = new Servicio();
                                break;

                            case "idServicio":
                                if (ser != null && !reader.IsEmptyElement) ser.idServicio = Convert.ToInt32(reader.ReadString());
                                break;
                            case "precioServicio":
                                if (ser != null && !reader.IsEmptyElement) ser.precioServicio = Convert.ToDouble(reader.ReadString());
                                break;
                            case "descripcion":
                                if (ser != null && !reader.IsEmptyElement) ser.descripcion = reader.ReadString();
                                break;
                            case "tipoServicioID":
                                if (ser != null && !reader.IsEmptyElement) ser.tipoServicioID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "precioAlta":
                                if (ser != null && !reader.IsEmptyElement) ser.precioAlta = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "precioBaja":
                                if (ser != null && !reader.IsEmptyElement) ser.precioBaja = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "precioMedia":
                                if (ser != null && !reader.IsEmptyElement) ser.precioMedia = Convert.ToDouble(XmlConvert.ToDecimal(reader.ReadString()));
                                break;
                            case "permisoAlta":
                                if (ser != null && !reader.IsEmptyElement) ser.permisoAlta = Convert.ToByte(reader.ReadString());
                                break;
                            case "permisoMedia":
                                if (ser != null && !reader.IsEmptyElement) ser.permisoMedia = Convert.ToByte(reader.ReadString());
                                break;
                            case "permisoBaja":
                                if (ser != null && !reader.IsEmptyElement) ser.permisoBaja = Convert.ToByte(reader.ReadString());
                                break;
                            case "descVIP":
                                if (ser != null && !reader.IsEmptyElement) ser.descVIP = Convert.ToDouble(reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (ser != null)
                        {
                            listaSer.Add(ser);
                            ser = null;
                        }
                    }
                }
                foreach (Servicio each in listaSer)
                {

                    controladorServicio.AgregarServivio(each);

                }
            }
        }

        public void ImportarTemporadaXML(String rutaArchivo)
        {
            List<Temporada> listaTemp = new List<Temporada>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Temporada temp = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                temp = new Temporada();
                                break;

                            case "temporadaID":
                                if (temp != null && !reader.IsEmptyElement) temp.temporadaID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "descripcion":
                                if (temp != null && !reader.IsEmptyElement) temp.descripcion = reader.ReadString();

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (temp != null)
                        {
                            listaTemp.Add(temp);
                            temp = null;
                        }
                    }
                }
                foreach (Temporada each in listaTemp)
                {

                    controladorFactura.AgregarTemporada(each);

                }
            }
        }

        public void ImportarTipoHabitacionXML(String rutaArchivo)
        {
            List<TipoHabitacion> listaTip = new List<TipoHabitacion>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                TipoHabitacion tHab = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                tHab = new TipoHabitacion();
                                break;

                            case "tipoID":
                                if (tHab != null && !reader.IsEmptyElement) tHab.tipoID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "descripcion":
                                if (tHab != null && !reader.IsEmptyElement) tHab.descripcion = (reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (tHab != null)
                        {
                            listaTip.Add(tHab);
                            tHab = null;
                        }
                    }
                }
                foreach (TipoHabitacion each in listaTip)
                {

                    controladorHabitacion.AgregarTipoHabitacion(each);

                }
            }
        }

        public void ImportarUsuarioXML(String rutaArchivo)
        {
            List<Usuario> listaUsu = new List<Usuario>();
            using (XmlReader reader = XmlReader.Create(rutaArchivo))
            {
                Usuario user = null;
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {

                        switch (reader.Name)
                        {
                            case "record":
                                user = new Usuario();
                                break;

                            case "nombre":
                                if (user != null && !reader.IsEmptyElement) user.nombre = Convert.ToString(reader.ReadString());
                                break;
                            case "usuarioID":
                                if (user != null && !reader.IsEmptyElement) user.usuarioID = Convert.ToInt32(reader.ReadString());
                                break;
                            case "password":
                                if (user != null && !reader.IsEmptyElement) user.password = Convert.ToString(reader.ReadString());

                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "record")
                    {

                        if (user != null)
                        {
                            listaUsu.Add(user);
                            user = null;
                        }
                    }

                }
                foreach (Usuario each in listaUsu)
                {

                    controladorUsuario.addUsuario(each);

                }
            }
        }


    }
}

