using System;
using System.Collections.Generic;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Enums;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Interfaces;
using Sistema_de_Restaurante_y_Cocina.Restaurante.Modelos;

namespace Sistema_de_Restaurante_y_Cocina
{
    class Program
    {
        static List<IPreparable> pedidoActual = new List<IPreparable>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEMA DE RESTAURANTE GOURMET ===");
                    Console.WriteLine("1. Agregar Entrada (Bruschetta)");
                    Console.WriteLine("2. Agregar Plato Principal (Salmón)");
                    Console.WriteLine("3. Agregar Postre (Mousse)");
                    Console.WriteLine("4. Ver Orden y Procesar Cocina");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");

                    string entrada = Console.ReadLine();
                    int opcion = int.Parse(entrada);

                    switch (opcion)
                    {
                        case 1:
                            pedidoActual.Add(new Entrada(1, "Bruschetta", 12.0m, TipoComida.Vegetariana, NivelDificultad.Facil, false));
                            Console.WriteLine("Entrada agregada.");
                            break;
                        case 2:
                            pedidoActual.Add(new PlatoPrincipal(2, "Salmón Grillé", 25.0m, TipoComida.Mariscos, NivelDificultad.Intermedio, "Salmón"));
                            Console.WriteLine("Plato Principal agregado.");
                            break;
                        case 3:
                            pedidoActual.Add(new Postre(3, "Mousse de Chocolate", 8.0m, TipoComida.Mixta, NivelDificultad.Avanzado, true));
                            Console.WriteLine("Postre agregado.");
                            break;
                        case 4:
                            MostrarResumenPedido();
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            throw new Exception("Opción no válida.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Por favor ingrese un número entero válido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Inesperado: {ex.Message}");
                }
                finally
                {
                    if (!salir)
                    {
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }
        }

        static void MostrarResumenPedido()
        {
            Console.WriteLine("\n--- RESUMEN DE LA ORDEN ---");
            decimal total = 0;

            if (pedidoActual.Count == 0)
            {
                Console.WriteLine("No hay platos en la orden.");
                return;
            }

            foreach (var item in pedidoActual)
            {

                item.GenerarOrdenCocina();
                total += item.CalcularCostoTotal();

                if (item is Plato p)
                {
                    p.MostrarInformacionNutricional();
                }
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine($"TOTAL A PAGAR: {total:C}");
        }
    }
}