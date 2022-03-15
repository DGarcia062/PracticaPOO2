using System;
using System.Collections.Generic;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioCliente servicioCliente = new();
            ServicioProducto servicioProducto = new();
            List<string> listaProductos = new List<string>();

            bool ingreso = true;

            while (ingreso == true) 
            { 
                Console.WriteLine("¿A qué módulo deseas acceder?\n\n1 - Módulo Clientes\n2 - Módulo Producto\n3 - Módulo Ventas\n4 - Módulo Reportes\n5 - Módulo Configuración\n\n6 - Salir");

                string seleccion = Console.ReadLine();
               
                while (seleccion == "1")
                {
                    Console.WriteLine("\nIngresaste al módulo de clientes, elige una opción:\n\n1 - Crear cliente\n2 - Buscar cliente\n3 - Modificar cliente\n4 - Deshabilitar cliente\n5 - Salir");

                    string seleccion2 = Console.ReadLine();

                    while (seleccion2 == "1")
                    {
                        Console.WriteLine("Elegiste la opción de crear cliente");

                        Cliente cliente = new(); //Se crea cliente

                        Console.WriteLine("ingrese el nombre del cliente: ");
                        cliente.Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese la dirección del cliente: ");
                        cliente.Direccion = Console.ReadLine();

                        Console.WriteLine("ingrese el teléfono del cliente: ");
                        cliente.Telefono = Console.ReadLine();

                        Console.WriteLine("ingrese la cédula del cliente: ");
                        cliente.Cedula = Console.ReadLine();
                       
                        bool clienteAdicionado = servicioCliente.CrearCliente(cliente);

                        if (clienteAdicionado == true)
                        {
                            Console.WriteLine("Cliente creado");
                        }
                        else
                        {
                            Console.WriteLine("No se puede crear, el cliente ya existe");
                        }

                        servicioCliente.ListarCliente();

                        Console.WriteLine("¿Quieres crear otro cliente?\n1 - Sí\n2 - No");

                        string seleccionCliente = Console.ReadLine();

                        if (seleccionCliente != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }                      
                    }
                    while (seleccion2 == "2")
                    {
                        Console.WriteLine("Elegiste la opción buscar cliente\n");

                        Console.WriteLine("Digita la cédula: ");

                        string cedula = Console.ReadLine();

                        var cliente = servicioCliente.BuscarCliente(cedula);

                        if (cliente == null)
                        {
                            Console.WriteLine("El cliente no existe");
                        }
                        else if(cliente.Habilitado == true)
                        {
                            Console.WriteLine("El cliente existe, pero está deshabilitado");
                        }
                        else
                        {
                            Console.WriteLine($"La cédula {cliente.Cedula} pertenece al cliente con nombre {cliente.Nombre}, dirección {cliente.Direccion}, teléfono {cliente.Telefono}");
                        }

                        Console.WriteLine("¿Quieres buscar otro cliente?\n1 - Sí\n2 - No");

                        string seleccionBusqueda = Console.ReadLine();

                        if (seleccionBusqueda != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }
                    }
                    while (seleccion2 == "3")
                    {
                        Console.WriteLine("Elegiste la opción modificar cliente\n");

                        Console.WriteLine("Digita la cédula del cliente: ");

                        string cedula = Console.ReadLine();

                        var cliente = servicioCliente.BuscarCliente(cedula);

                        if(cliente == null)
                        {
                            Console.WriteLine("No se encontró un cliente con esa cédula");
                        }
                        else
                        {
                            Console.WriteLine("Cliente encontrado\n");

                            Console.WriteLine("¿Qué dato deseas modificar?\n1 - Nombre\n2 - Dirección\n3 - Teléfono");

                            var datoModificar = Console.ReadLine();

                            if(datoModificar == "1")
                            {
                                Console.WriteLine("Digita el nuevo nombre\n");

                                var nuevoNombre = Console.ReadLine();

                                cliente.Nombre = nuevoNombre;

                                Console.WriteLine($"El cliente ha sido modificado exitosamente, el nuevo nombre es: {cliente.Nombre}");

                            }
                            else if (datoModificar == "2")
                            {
                                Console.WriteLine("Digita la nuevo dirección\n");

                                var nuevaDireccion = Console.ReadLine();

                                cliente.Direccion = nuevaDireccion;

                                Console.WriteLine($"El cliente ha sido modificado exitosamente, la nueva dirección es: {cliente.Direccion}");
                            }
                            else if (datoModificar == "3")
                            {
                                Console.WriteLine("Digita el nuevo teléfono\n");

                                var nuevoTelefono = Console.ReadLine();

                                cliente.Telefono = nuevoTelefono;

                                Console.WriteLine($"El cliente ha sido modificado exitosamente, el nuevo teléfono es: {cliente.Telefono}");
                            }
                            Console.WriteLine("¿Quieres modificar otro cliente?\n1 - Sí\n2 - No");

                            string seleccionModificar = Console.ReadLine();

                            if (seleccionModificar != "1")
                            {
                                Console.WriteLine("Hasta luego");
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    while (seleccion2 == "4")
                    {
                        Console.WriteLine("Elegiste la opción deshabilitar cliente\n");

                        Console.WriteLine("Digita la cédula del cliente a deshabilitar: ");

                        string cedula = Console.ReadLine();

                        var cliente = servicioCliente.BuscarCliente(cedula);

                        if(cliente == null)
                        {
                            Console.WriteLine("No se encontró un cliente con esa cédula");
                        }
                        else
                        {
                            cliente.Habilitado = true;

                            Console.WriteLine("Cliente deshabilitado");
                        }

                        Console.WriteLine("¿Quieres deshabilitar otro cliente?\n1 - Sí\n2 - No");

                        string seleccionDeshabilitar = Console.ReadLine();

                        if (seleccionDeshabilitar != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }

                    }
                        if (seleccion2 == "5")
                    {
                        Console.WriteLine("Hasta luego");
                        break;
                    }
                }              
                while (seleccion == "2")
                {
                    Console.WriteLine("Ingresaste al módulo de productos, elige una opción:\n\n1- Crear Producto. \n2- Buscar Producto. \n3- Modificar un producto. \n4- Deshabilitar un producto. \n5- Salir. \n");

                    string seleccion3 = Console.ReadLine();

                    while (seleccion3 == "1")
                    {
                        Console.WriteLine("Elegiste la opción crear producto");

                        Producto producto = new();

                        Console.WriteLine("Ingresa el nombre del producto: ");
                        producto.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingresa el valor del producto: ");
                        producto.Precio = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la cantidad del producto: ");
                        producto.Cantidad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa el código del producto: ");
                        producto.Codigo = Console.ReadLine();

                        bool productoAdicionado = servicioProducto.CrearProducto(producto);

                        if (productoAdicionado == true)
                        {
                            Console.WriteLine("Producto creado");
                        }
                        else
                        {
                            Console.WriteLine("No se puede crear, el producto ya existe");
                        }

                        Console.WriteLine("¿Deseas crear otro producto?\n1 - Sí\n2 - No");

                        string seleccionProducto = Console.ReadLine();

                        if (seleccionProducto != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }
                    }
                    while (seleccion3 == "2")
                    {
                        Console.WriteLine("Elegiste la opción buscar producto");

                        Console.WriteLine("Digita el código: ");

                        string codigo = Console.ReadLine();

                        var producto = servicioProducto.BuscarProducto(codigo);

                        if (producto == null)
                        {
                            Console.WriteLine("El producto ya existe");
                        }
                        else if (producto.Habilitar == true)
                        {
                            Console.WriteLine("El producto ya existe, pero está deshabilitado");
                        }
                        else
                        {
                            Console.WriteLine($"El código {producto.Codigo} pertenece al producto {producto.Nombre}, con un precio de {producto.Precio}, y una cantidad de{producto.Cantidad}");
                        }

                        Console.WriteLine("¿Quieres buscar otro producto?\n1 - Sí\n2 - No");

                        string seleccionBusquedaProducto = Console.ReadLine();

                        if (seleccionBusquedaProducto != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }
                    }

                    while (seleccion3 == "3")
                    {
                        Console.WriteLine("Elegiste la opción modificar producto\n");

                        Console.WriteLine("Digita el código del producto: ");

                        string codigo = Console.ReadLine();

                        var producto = servicioProducto.BuscarProducto(codigo);

                        if (producto == null)
                        {
                            Console.WriteLine("No se encontró un producto con ese código");
                        }
                        else
                        {
                            Console.WriteLine("Producto encontrado\n");

                            Console.WriteLine("¿Qué dato deseas modificar?\n1 - Nombre\n2 - Cantidad\n3 - Precio");

                            var datoModificar = Console.ReadLine();

                            if (datoModificar == "1")
                            {
                                Console.WriteLine("Digita el nuevo nombre\n");

                                var nuevoNombre = Console.ReadLine();

                                producto.Nombre = nuevoNombre;

                                Console.WriteLine($"El cliente ha sido modificado exitosamente, el nuevo nombre es: {producto.Nombre}");

                            }
                            else if (datoModificar == "2")
                            {
                                Console.WriteLine("Digita la nueva cantidad\n");

                                var nuevaCantidad = Console.ReadLine();

                                producto.Cantidad = int.Parse(nuevaCantidad);

                                Console.WriteLine($"El producto ha sido modificado exitosamente, la nueva cantidad es: {producto.Cantidad}");
                            }
                            else if (datoModificar == "3")
                            {
                                Console.WriteLine("Digita el nuevo precio\n");

                                var nuevoPrecio = Console.ReadLine();

                                producto.Precio = double.Parse(nuevoPrecio);

                                Console.WriteLine($"El producto ha sido modificado exitosamente, el nuevo precio es: {producto.Precio}");
                            }
                            Console.WriteLine("¿Quieres modificar otro producto?\n1 - Sí\n2 - No");

                            string seleccionModificar = Console.ReadLine();

                            if (seleccionModificar != "1")
                            {
                                Console.WriteLine("Hasta luego");
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    while (seleccion3 == "4")
                    {
                        Console.WriteLine("Elegiste la opción deshabilitar producto\n");

                        Console.WriteLine("Digita el código del producto a deshabilitar: ");

                        string codigo = Console.ReadLine();

                        var producto = servicioProducto.BuscarProducto(codigo);

                        if (producto == null)
                        {
                            Console.WriteLine("No se encontró un producto con ese código");
                        }
                        else
                        {
                            producto.Habilitar = true;

                            Console.WriteLine("Producto deshabilitado");
                        }

                        Console.WriteLine("¿Quieres deshabilitar otro producto?\n1 - Sí\n2 - No");

                        string seleccionDeshabilitar = Console.ReadLine();

                        if (seleccionDeshabilitar != "1")
                        {
                            Console.WriteLine("Hasta luego");
                            Console.Clear();
                            break;
                        }

                    }

                    if (seleccion3 == "5")
                    {
                        Console.WriteLine("Hasta luego");
                        break;
                    }
                }

                while (seleccion == "3")
                {
                    Console.WriteLine("Ingresaste al módulo de ventas\n");

                    Console.WriteLine("Ingresa la cédula del cliente: ");

                    string cedula = Console.ReadLine();

                    var cliente = servicioCliente.BuscarCliente(cedula);

                    if (cliente == null)
                    {
                        Console.WriteLine("El cliente ingresado no existe");
                        break;
                    }
                    else if (cliente.Habilitado == true)
                    {
                        Console.WriteLine("El cliente existe, pero está deshabilitado");
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Consulta realizada\n");
                        Console.WriteLine($"La cédula {cliente.Cedula} pertenece al cliente con nombre {cliente.Nombre}, dirección {cliente.Direccion}, teléfono {cliente.Telefono}");


                        Console.WriteLine("Nuestra disponibilidad es: \n");

                        foreach (var i in servicioProducto.listaProductos)
                        {
                            Console.WriteLine($"Producto: {i.Nombre} - Cantidad: {i.Cantidad}");
                          
                        }

                        foreach (var f in servicioProducto.listaProductos)
                        {
                            Console.WriteLine("Ingresa el nombre del producto que deseas llevar");

                            var seleccionProducto = Console.ReadLine();

                            if (seleccionProducto == f.Nombre)
                            {
                                Console.WriteLine($"Seleccionaste el producto: {f.Nombre}");

                                Console.WriteLine("¿Cuántas unidades deseas llevar?");

                                double seleccionCantidad = int.Parse(Console.ReadLine());

                                if (seleccionCantidad <= f.Cantidad)
                                {
                                    Console.WriteLine($"Seleccionaste {seleccionCantidad} del producto:     {seleccionProducto}");

                                    Console.WriteLine("¿Deseas seleccionar otro producto? 1 - Sí 2 - No");

                                    var seleccionProducto_ = Console.ReadLine();

                                    if (seleccionProducto_ != "1")
                                    {
                                        Console.WriteLine("Hasta luego");                                       
                                        break;
                                    }                                    
                                }
                                else
                                {
                                    Console.WriteLine("Existencias insuficientes");
                                }
                            }

                            
                        }
                        



                        

                        



                    }                 
                    
            }
            if (seleccion == "6")
            {
                Console.WriteLine("Hasta luego.");
                ingreso = false;

             }
        }
        
        }
    }
}

