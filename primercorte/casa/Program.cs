using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Serialization;


namespace Parcial1.Parciales1.micasa
{
    public class MiCasa
    {

        public static void guardar_fecha()
        {
            Console.Write("Valor de la vivienda: ");
            double vivienda = double.Parse(Console.ReadLine());

            Console.Write("Tasa de interés mensual (%): ");
            double tasa_interes = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Plazo en meses: ");
            int plazo = int.Parse(Console.ReadLine());

            // Fórmula de cuota fija: 
            // cuota = P * (r * (1+r)^n) / ((1+r)^n - 1)
            double cuota = vivienda * (tasa_interes * Math.Pow(1 + tasa_interes, plazo)) /
                           (Math.Pow(1 + tasa_interes, plazo) - 1);

            double saldo = vivienda;
            double totalInteres = 0;

            Console.WriteLine("\n{0,-5} | {1,-12} | {2,-15} | {3,-12} | {4,-15}",
                              "Mes", "Fecha Pago", "Abono Capital", "Interés", "Saldo");
            Console.WriteLine(new string('-', 70));

            for (int mes = 1; mes <= plazo; mes++)
            {
                double interes = saldo * tasa_interes;
                double abonoCapital = cuota - interes;
                saldo -= abonoCapital;
                totalInteres += interes;

                Console.WriteLine("{0,-5} | {1,-12} | {2,-15:F2} | {3,-12:F2} | {4,-15:F2}",
                                  mes,
                                  DateTime.Now.AddMonths(mes).ToString("dd/MM/yyyy"),
                                  abonoCapital,
                                  interes,
                                  saldo < 0 ? 0 : saldo);
            }

            Console.WriteLine("\nCuota mensual: {0:F2}", cuota);
            Console.WriteLine("Total pagado: {0:F2}", cuota * plazo);
            Console.WriteLine("Total intereses: {0:F2}", totalInteres);

            


        }

        
    }
    
}