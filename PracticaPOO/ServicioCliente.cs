using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    class ServicioCliente
    {
        public List<Cliente> listaClientes = new();


        public bool CrearCliente(Cliente cliente)
        {
            Cliente clienteBuscar = BuscarCliente(cliente.Cedula);
            if (clienteBuscar == null)
            {
                listaClientes.Add(cliente);
                return true;
            }
            return false;           
        }

        public Cliente BuscarCliente(string cedula)
        {
            foreach (var cliente in listaClientes)
            {
                if(cliente.Cedula == cedula)
                {
                    return cliente;
                }                
            }
            return null;
        }

        public void ModificarCliente()
        {

        }

        public void DeshabiltiarCliente()
        {

        }

        public List<Cliente> ListarCliente()
        {
            return listaClientes;
        }
    }	
}
   