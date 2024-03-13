using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using Producto_2.Vista;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.NetworkInformation;


namespace Producto_2.Controlador
{
    public class ClienteControlador
    {

      
        
        public List<Clientes> ObtenerClientes()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Clientes.ToList();
            }
        }
        public List<Clientes> BuscarClientesPorNombre(String nombre)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Clientes.Where(c => c.nombre.Contains(nombre)).ToList();
            }
        }
        public void AgregarCliente(Clientes cliente)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var clienteExiste = db.Clientes.FirstOrDefault(c => c.NIF == cliente.NIF);
                    if (clienteExiste == null)
                    {
                        db.Clientes.Add(cliente);
                    }
                    else
                    {
                        ActualizarCliente(cliente.NIF, cliente.nombre, cliente.apellidos, cliente.email, cliente.telefono, cliente.VIP, cliente.direccion,
                           cliente.ciudad, Convert.ToInt32(cliente.cp), cliente.pais, Convert.ToDateTime(cliente.fechaN), cliente.detalle, cliente.nombreCuenta, 
                           cliente.numeroCuenta, Convert.ToDateTime(cliente.fechaAlta));
                    }
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            sb.AppendLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw new Exception(sb.ToString());
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception("Error al agregar el cliente: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el cliente: " + ex.Message);
                }
            }
        }
        public void EliminarCliente(string nif)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var clienteElimar = db.Clientes.FirstOrDefault(c => c.NIF == nif);
                    if (clienteElimar == null)
                    {
                        throw new Exception("Cliente no encontrado. ");
                    }

                    db.Clientes.Remove(clienteElimar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }
        public void ActualizarCliente(String nif, string nombre, string apellidos, string email, string telefono, byte vipStatus, string direccion,
            string ciudad, int cp, string pais, DateTime fechaN, string detalle, string nombreCuenta, string numeroCuenta, DateTime fechaAlta)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var clienteActualizar = db.Clientes.FirstOrDefault(c => c.NIF == nif);
                    if (clienteActualizar == null)
                    {
                        throw new Exception("Cliente no encontrado. ");
                    }
                    clienteActualizar.nombre = nombre;
                    clienteActualizar.apellidos = apellidos;
                    clienteActualizar.email = email;
                    clienteActualizar.telefono = telefono;
                    clienteActualizar.VIP = vipStatus;
                    clienteActualizar.direccion = direccion;
                    clienteActualizar.ciudad = ciudad;
                    clienteActualizar.cp = cp;
                    clienteActualizar.pais = pais;
                    clienteActualizar.fechaN = fechaN;
                    clienteActualizar.detalle = detalle;
                    clienteActualizar.nombreCuenta = nombreCuenta;
                    clienteActualizar.numeroCuenta = numeroCuenta;
                    clienteActualizar.fechaAlta = fechaAlta;    
                   

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar el cliente: " + ex.Message);
                }
            }
        }
        public void ExportarClientesAXML(List<Clientes> listaClientes, string rutaArchivo)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootNode = xmlDoc.CreateElement("clientes");
            xmlDoc.AppendChild(rootNode);

            foreach (var cliente in listaClientes)
            {
                XmlElement clienteNode = xmlDoc.CreateElement("cliente");

                XmlElement nifElement = xmlDoc.CreateElement("NIF");
                nifElement.InnerText = cliente.NIF;
                clienteNode.AppendChild(nifElement);

                XmlElement nombreElement = xmlDoc.CreateElement("nombre");
                nombreElement.InnerText = cliente.nombre;
                clienteNode.AppendChild(nombreElement);

                XmlElement apellidoElement = xmlDoc.CreateElement("apellidos");
                apellidoElement.InnerText = cliente.apellidos;
                clienteNode.AppendChild(apellidoElement);

                XmlElement telefonoElement = xmlDoc.CreateElement("telefono");
                telefonoElement.InnerText = cliente.telefono;
                clienteNode.AppendChild(telefonoElement);

                XmlElement emailElement = xmlDoc.CreateElement("email");
                emailElement.InnerText = cliente.email;
                clienteNode.AppendChild(emailElement);

                rootNode.AppendChild(clienteNode);

            }

            xmlDoc.Save(rutaArchivo);
        }
        public List<Clientes> ImportarXML(String rutaArchivo)
        {
            List<Clientes> listaClientes = new List<Clientes>();
            XmlDocument xmlDoc = new XmlDocument(); 
            xmlDoc.Load(rutaArchivo);
            XmlNodeList clientesNodos = xmlDoc.SelectNodes("/clientes/cliente");

            foreach(XmlNode clienteNode in clientesNodos) {
                Clientes cliente = new Clientes()
                {
                    NIF = clienteNode["NIF"].InnerText,
                    nombre = clienteNode["nombre"].InnerText,
                    apellidos = clienteNode["apellidos"].InnerText,
                    telefono = clienteNode["telefono"].InnerText,
                    email = clienteNode["email"].InnerText,
                    
                };

                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

    }
}
