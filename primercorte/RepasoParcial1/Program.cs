using RepasoParcial1.Gloval.Modelos;
using System;
using System.IO;

class Program
{
    static string RutaArchivo = "envios.csv";

    static void Main()
    {
        int opc;

        do
        {
            Console.WriteLine("BIENVENIDOS A GLOBALCHIP");
            Console.WriteLine("1. Nuevo envío");
            Console.WriteLine("2. Ver peso total (reporte)");
            Console.WriteLine("3. Buscar por guía");
            Console.WriteLine("4. Salir");
            Console.Write("SELECCIONE: ");

            if (!int.TryParse(Console.ReadLine(), out opc))
                continue;

            switch (opc)
            {
                case 1:
                    CrearEnvio();
                    break;

                case 2:
                    ReporteCarga();
                    break;

                case 3:
                    BuscarPorGuia();
                    break;
            }

        } while (opc != 4);
    }

    static void CrearEnvio()
    {
        paquete nuevoEnvio = new paquete();

        Console.Write("Ingrese guía: ");
        nuevoEnvio.guia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese destinatario: ");
        nuevoEnvio.destinatario = Console.ReadLine();

        Console.Write("Ingrese peso: ");
        nuevoEnvio.peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese Tipo (0: Nacional, 1: Internacional): ");
        nuevoEnvio.tipo = (TiposEnvio)Enum.Parse(typeof(TiposEnvio), Console.ReadLine());

        using (StreamWriter sw = new StreamWriter(RutaArchivo, true))
        {
            sw.WriteLine($"{nuevoEnvio.guia};{nuevoEnvio.destinatario};{nuevoEnvio.peso};{nuevoEnvio.tipo}");
        }

        Console.WriteLine(">> ¡ENVÍO GUARDADO EN ARCHIVO!");
    }

    static void ReporteCarga()
    {
        if (!File.Exists(RutaArchivo))
        {
            Console.WriteLine("No hay datos.");
            return;
        }

        double pesoTotal = 0;
        string[] lineas = File.ReadAllLines(RutaArchivo);

        foreach (string linea in lineas)
        {
            string[] datos = linea.Split(';');
            pesoTotal += double.Parse(datos[2]);
        }

        Console.WriteLine($"\n>> PESO TOTAL DE CARGA: {pesoTotal} kg");
    }

    static void BuscarPorGuia()
    {
        Console.Write("Ingrese guía a buscar: ");
        string guiaBuscada = Console.ReadLine();
        bool encontrado = false;

        if (File.Exists(RutaArchivo))
        {
            using (StreamReader sr = new StreamReader(RutaArchivo))
            {
                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');

                    if (datos[0] == guiaBuscada)
                    {
                        Console.WriteLine($"\n[ENCONTRADO] Destinatario: {datos[1]}, Peso: {datos[2]}, Tipo: {datos[3]}");
                        encontrado = true;
                        break;
                    }
                }
            }
        }

        if (!encontrado)
            Console.WriteLine(">> Paquete no encontrado.");
    }
}