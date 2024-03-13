using Producto_2.Modelo;
using Producto_2.Vista;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Controlador
{
    public class UtenticacionControlador
    {
        public bool inicioSesion(string nombreUsuario,string password)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
               // string passHash = HashPass(password);
                var usuario = db.Usuario.Where(u => u.nombre == nombreUsuario).FirstOrDefault();
                
                if (usuario != null && usuario.password == password)
                {
                    return true;
                }

                return false; 
            }
        }
       

        public void AgregarUsuario(String nombreUsuario, String pass) {
        using(dbHotelSQLEntities db =new dbHotelSQLEntities())
            {
                var usuario = new Usuario
                {
                   nombre = nombreUsuario,
                   password = pass
                };

                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
        }
        public void addUsuario(Usuario servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.Usuario.Add(servicio);
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
                    throw new Exception("Error al agregar reserva: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.Message);
                }
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
