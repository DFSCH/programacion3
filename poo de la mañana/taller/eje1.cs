using System;
using System.Collections.Generic;
using System.Text;

namespace poo_de_la_mañana.taller
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public int Saldo { get; private set; }

        public CuentaBancaria(string titular, int saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"\nSaldo actual de {Titular}: ${Saldo}");
        }

        public void Depositar(int cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($" Has depositado ${cantidad}. Nuevo saldo: ${Saldo}");
            }
            else
            {
                Console.WriteLine(" El monto debe ser positivo.");
            }
        }

        public void Retirar(int cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else if (cantidad <= 0)
            {
                Console.WriteLine("El monto a retirar debe ser positivo.");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine($"Has retirado ${cantidad}. Nuevo saldo: ${Saldo}");
            }
        }
    }

    public class eje1
    {
        public static void ejecutar()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            CuentaBancaria miCuenta = new CuentaBancaria(nombre, 0);

            string opcion = "";
            while (opcion != "4")
            {
                Console.WriteLine("\n--- CAJERO AUTOMÁTICO ---");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    miCuenta.ConsultarSaldo();
                }
                else if (opcion == "2")
                {
                    Console.Write("Monto a depositar (entero): ");
                    if (int.TryParse(Console.ReadLine(), out int monto))
                    {
                        miCuenta.Depositar(monto);
                    }
                    else
                    {
                        Console.WriteLine("Dato no válido. Use números enteros.");
                    }
                }
                else if (opcion == "3")
                {
                    Console.Write("Monto a retirar (entero): ");
                    if (int.TryParse(Console.ReadLine(), out int monto))
                    {
                        miCuenta.Retirar(monto);
                    }
                    else
                    {
                        Console.WriteLine("Dato no válido. Use números enteros.");
                    }
                }
            }
            Console.WriteLine("Programa finalizado.");
        }
    }
}
