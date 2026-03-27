using BIBLIOTECA.DIGITAL.Enums;
using BIBLIOTECA.DIGITAL.Interfaces;
using BIBLIOTECA.DIGITAL.Modelo;

static void Main()
{
    // Lista polimórfica: solo acepta objetos que implementen IPrestable
    List<IPrestable> listaPrestamos = new List<IPrestable>();

    // Agregando ejemplos manuales para la demostración
    Libro miLibro = new Libro(1, "Cien Años de Soledad", "G. García Márquez", 1967, TIpocategorias.Ficcion, 471, "978-0307474728");
    AudioLibro miAudio = new AudioLibro(2, "Breves respuestas a las grandes preguntas", "Stephen Hawking", 2018, TIpocategorias.Ciencia, new TimeSpan(6, 30, 0), "Varios Narradores");

    listaPrestamos.Add(miLibro);
    listaPrestamos.Add(miAudio);

    Console.WriteLine("--- PROCESANDO PRÉSTAMOS ---");
    foreach (var item in listaPrestamos)
    {
        item.GenerarComprobantePrestramo();
        // Demostración de multa si se atrasa 3 días
        Console.WriteLine($"Multa estimada (3 días de retraso): ${item.CalcularMultaPorRetraso(3)}");
        Console.WriteLine("-----------------------------");
    }
}