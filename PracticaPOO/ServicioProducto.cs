using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    class ServicioProducto
    {
        public List<Producto> listaProductos = new();


        public bool CrearProducto(Producto producto)
        {
            Producto productoBuscar = BuscarProducto(producto.Codigo);
            if (productoBuscar == null)
            {
                listaProductos.Add(producto);
                return true;
            }
            return false;
        }

        public Producto BuscarProducto(string codigo)
        {
            foreach (var producto in listaProductos)
            {
                if (producto.Codigo == codigo)
                {
                    return producto;
                }
            }
            return null;
        }


    }
}
