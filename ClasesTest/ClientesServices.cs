using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;

namespace Producto_2.ClasesTest
{
    public class ClientesServices
    {
        private readonly IClienteRepositorio _ClienteRepositorio;

        public ClientesServices(IClienteRepositorio clienteRepositorio)
        {
            _ClienteRepositorio = clienteRepositorio;
        }

        public List<Clientes> ObtenerClientes()
        {
            return _ClienteRepositorio.ObtenerTodosLosClientes();
        }
        public Clientes ObtenerClientesPorNIF(string NIF)
        {
            if (string.IsNullOrWhiteSpace(NIF))
            {
                throw new ArgumentException("El NIF no puede estar vacío", nameof(NIF));
            }

            var cliente = _ClienteRepositorio.ObtenerClientesPorNIF(NIF);

            if (cliente == null)
            {
               
                throw new InvalidOperationException($"No se encontró ningún cliente con el NIF: {NIF}");
            }

            return cliente;
        }
        public void AgregarCliente(Clientes cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo");
            }

            if (string.IsNullOrWhiteSpace(cliente.nombre))
            {
                throw new ArgumentException("El NIF del cliente es requerido", nameof(cliente));
            }

            try
            {
                // Lógica para agregar cliente
                _ClienteRepositorio.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                
                throw new InvalidOperationException("Error al agregar el cliente", ex);
            }

            
        }
        public void EliminarCliente(string NIF)
        {
            _ClienteRepositorio.EliminarCliente(NIF);
        }
        public void ActualizarCliente(Clientes cliente)
        {
            _ClienteRepositorio.ActualizarCliente(cliente);
        }
    }
}
