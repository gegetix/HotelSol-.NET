using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;

namespace Producto_2.ClasesTest
{
    public interface IClienteRepositorio
    {
        List<Clientes> ObtenerTodosLosClientes();
        Clientes ObtenerClientesPorNIF(string NIF);
        void AgregarCliente(Clientes cliente);
        void EliminarCliente(string NIF);
        void ActualizarCliente(Clientes cliente);
    }
}
