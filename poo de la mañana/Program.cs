using poo_de_la_mañana.taller;


Console.WriteLine("--- Menú de Repaso ---");
Console.WriteLine("Seleccione un ejercicio (1-3):");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        eje1.ejecutar();
        break;
    case "2":
        eje2.ejecutar();
        break;
    case "3":
        eje3.ejecutar();
        break;
    default:
        Console.WriteLine("Opción no válida. Intente de nuevo.");
        break;
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();