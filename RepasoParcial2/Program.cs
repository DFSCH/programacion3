using RepasoParcial2.Parking.Modelo;


namespace RepasoParcial2.Parking
{
    internal class Program
    {

        static Vehiculo[] parqueadero = new Vehiculo[5];
        static int contador = 0;

        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENU PARKINGPRO ---");
                Console.WriteLine("1. Registrar Vehículo\n2. Consultar Placa\n3. Ver todos\n0. Salir");
                Console.Write("Seleccione: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: Buscar(); break;
                    case 3: Listar(); break;
                }
            } while (opcion != 0);
        }

        static void Registrar()
        {
            if (contador >= 5) { Console.WriteLine("Lleno"); return; }

            Console.Write("1. Carro / 2. Moto: ");
            string tipo = Console.ReadLine();
            Console.Write("Placa: "); string p = Console.ReadLine();
            Console.Write("Marca: "); string m = Console.ReadLine();

            if (tipo == "1")
            {
                Console.Write("Puertas: ");
                parqueadero[contador++] = new Carro(p, m, int.Parse(Console.ReadLine()));
            }
            else
            {
                Console.Write("Cilindraje: ");
                parqueadero[contador++] = new Moto(p, m, int.Parse(Console.ReadLine()));
            }
        }

        static void Buscar()
        {
            Console.Write("Placa a buscar: ");
            string busca = Console.ReadLine().ToUpper();
            foreach (var v in parqueadero)
            {
                if (v != null && v.Placa.ToUpper() == busca)
                {
                    Console.WriteLine($">> ENCONTRADO: {v} - Tarifa (1h): ${v.CalcularTarifa(60)}");
                    return;
                }
            }
            Console.WriteLine("No encontrado.");
        }

        static void Listar()
        {
            foreach (var v in parqueadero)
                if (v != null) Console.WriteLine(v.ToString().ToUpper());
        }
    }
}