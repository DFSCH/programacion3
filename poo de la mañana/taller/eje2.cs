using System;
using System.Collections.Generic;
using System.Text;

namespace poo_de_la_mañana.taller
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Precio { get; set; }
        public int CantidadStock { get; private set; }

        public Producto(string nombre, string codigo, int precio, int stockInicial)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            CantidadStock = stockInicial;
        }

         public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadStock += cantidad;
                Console.WriteLine($" Se agregaron {cantidad} unidades. Nuevo stock: {CantidadStock}");
            }
            else
            {
                Console.WriteLine(" La cantidad a agregar debe ser positiva.");
            }
        }

        public int VenderProducto(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine(" La cantidad a vender debe ser positiva.");
                return 0;
            }

            if (cantidad <= CantidadStock)
            {
                CantidadStock -= cantidad;
                int totalVenta = cantidad * Precio;
                Console.WriteLine($" Venta exitosa. Total a cobrar: ${totalVenta}");
                return totalVenta;
            }
            else
            {
                Console.WriteLine(" No hay suficiente stock para esta venta.");
                return 0;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\n--- DETALLES DEL PRODUCTO ---");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Stock disponible: {CantidadStock}");
            Console.WriteLine("-----------------------------");
        }
    }

    public class eje2
    {
        public static void ejecutar()
        {
            Console.WriteLine("--- REGISTRO DE PRODUCTO NUEVO ---");
            Console.Write("Nombre: ");
            string nom = Console.ReadLine();
            Console.Write("Código: ");
            string cod = Console.ReadLine();

            Console.Write("Precio (entero): ");
            int.TryParse(Console.ReadLine(), out int pre);

            Console.Write("Stock inicial (entero): ");
            int.TryParse(Console.ReadLine(), out int stock);

            Producto miProducto = new Producto(nom, cod, pre, stock);

            string opcion = "";
            while (opcion != "4")
            {
                Console.WriteLine("\n--- MENÚ DE INVENTARIO ---");
                Console.WriteLine("1. Ver información del producto");
                Console.WriteLine("2. Agregar Stock (Entrada)");
                Console.WriteLine("3. Vender Producto (Salida)");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    miProducto.MostrarInfo();
                }
                else if (opcion == "2")
                {
                    Console.Write("Cantidad que entra al almacén: ");
                    if (int.TryParse(Console.ReadLine(), out int cantEntrada))
                    {
                        miProducto.AgregarStock(cantEntrada);
                    }
                }
                else if (opcion == "3")
                {
                    Console.Write("Cantidad a vender: ");
                    if (int.TryParse(Console.ReadLine(), out int cantVenta))
                    {
                        miProducto.VenderProducto(cantVenta);
                    }
                }
            }
            Console.WriteLine("Cerrando sistema de inventario...");
        }
    }
}
