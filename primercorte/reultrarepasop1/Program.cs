using System;
using System.IO;

// ================= ENUM =================
// Define los tipos de envío posibles
public enum TipoEnvio
{
    Normal,
    Express
}

// ================= INTERFAZ =================
// Obliga a calcular costo
public interface ICalculable
{
    double CalcularCosto(int peso);
}

// ================= CLASE ABSTRACTA =================
// Clase base para todos los envíos
public abstract class Envio
{
    public int Codigo { get; set; }
    public string Cliente { get; set; }
}

// ================= CLASE HIJA 1 =================
// Envío local
public class EnvioLocal : Envio, ICalculable
{
    public int DistanciaKm { get; set; }

    // Calcula costo para envío local
    public double CalcularCosto(int peso)
    {
        return peso * 200;
    }
}

// ================= CLASE HIJA 2 =================
// Envío internacional
public class EnvioInternacional : Envio, ICalculable
{
    public string PaisDestino { get; set; }

    // Calcula costo para envío internacional
    public double CalcularCosto(int peso)
    {
        return peso * 500;
    }
}

// ================= CLASE PEDIDO =================
// Contiene toda la información del pedido
public class Pedido
{
    public Envio Envio { get; set; }
    public TipoEnvio Tipo { get; set; }
    public int Peso { get; set; }
}

// ================= PROGRAMA PRINCIPAL =================
class Program
{
    // Arreglo de pedidos (máximo 10)
    static Pedido[] lista = new Pedido[10];
    static int contador = 0;

    static string rutaCSV = "pedidos.csv";
    static string rutaTXT = "pedidos.txt";

    static void Main()
    {
        int opcion;

        // Menú principal
        do
        {
            Console.WriteLine("\n--- SMARTDELIVERY ---");
            Console.WriteLine("1. Registrar pedido");
            Console.WriteLine("2. Mostrar tabla");
            Console.WriteLine("3. Guardar en CSV");
            Console.WriteLine("4. Leer CSV");
            Console.WriteLine("5. Guardar en TXT");
            Console.WriteLine("6. Leer TXT");
            Console.WriteLine("7. Últimos 3");
            Console.WriteLine("8. Editar");
            Console.WriteLine("9. Buscar por código");
            Console.WriteLine("10. Buscar por cliente");
            Console.WriteLine("0. Salir");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1: Registrar(); break;
                case 2: MostrarTabla(); break;
                case 3: GuardarCSV(); break;
                case 4: LeerCSV(); break;
                case 5: GuardarTXT(); break;
                case 6: LeerTXT(); break;
                case 7: Ultimos3(); break;
                case 8: Editar(); break;
                case 9: BuscarCodigo(); break;
                case 10: BuscarCliente(); break;
            }

        } while (opcion != 0);
    }

    // ================= REGISTRAR =================
    static void Registrar()
    {
        if (contador >= 10)
        {
            Console.WriteLine("Lleno");
            return;
        }

        Pedido p = new Pedido();

        Console.Write("Código: ");
        int.TryParse(Console.ReadLine(), out int codigo);

        Console.Write("Cliente: ");
        string cliente = Console.ReadLine();

        Console.WriteLine("1. Local  2. Internacional");
        int tipoEnvio = int.Parse(Console.ReadLine());

        Envio envio;

        if (tipoEnvio == 1)
        {
            envio = new EnvioLocal();
            Console.Write("Distancia: ");
            ((EnvioLocal)envio).DistanciaKm = int.Parse(Console.ReadLine());
        }
        else
        {
            envio = new EnvioInternacional();
            Console.Write("País: ");
            ((EnvioInternacional)envio).PaisDestino = Console.ReadLine();
        }

        envio.Codigo = codigo;
        envio.Cliente = cliente;

        p.Envio = envio;

        Console.Write("Peso: ");
        p.Peso = int.Parse(Console.ReadLine());

        Console.Write("Tipo (0 Normal, 1 Express): ");
        p.Tipo = (TipoEnvio)int.Parse(Console.ReadLine());

        lista[contador] = p;
        contador++;
    }

    // ================= MOSTRAR TABLA =================
    static void MostrarTabla()
    {
        Console.WriteLine("COD | CLIENTE | TIPO | PESO | COSTO");
        Console.WriteLine("------------------------------------");

        for (int i = 0; i < contador; i++)
        {
            MostrarPedido(lista[i]);
        }
    }

    // ================= MOSTRAR PEDIDO =================
    static void MostrarPedido(Pedido p)
    {
        // Polimorfismo: se usa interfaz
        ICalculable calc = (ICalculable)p.Envio;

        double costo = calc.CalcularCosto(p.Peso);

        // Aplica recargo si es express
        if (p.Tipo == TipoEnvio.Express)
        {
            costo *= 1.3;
        }

        Console.WriteLine(
            p.Envio.Codigo + " | " +
            p.Envio.Cliente.ToUpper() + " | " +
            p.Tipo + " | " +
            p.Peso + " | " +
            costo
        );
    }

    // ================= GUARDAR CSV =================
    static void GuardarCSV()
    {
        try
        {
            StreamWriter sw = new StreamWriter(rutaCSV);

            for (int i = 0; i < contador; i++)
            {
                Pedido p = lista[i];

                ICalculable calc = (ICalculable)p.Envio;
                double costo = calc.CalcularCosto(p.Peso);

                if (p.Tipo == TipoEnvio.Express)
                    costo *= 1.3;

                sw.WriteLine($"{p.Envio.Codigo};{p.Envio.Cliente};{p.Tipo};{p.Peso};{costo}");
            }

            sw.Close();
            Console.WriteLine("CSV guardado");
        }
        catch
        {
            Console.WriteLine("Error CSV");
        }
    }

    // ================= LEER CSV =================
    static void LeerCSV()
    {
        try
        {
            StreamReader sr = new StreamReader(rutaCSV);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            sr.Close();
        }
        catch
        {
            Console.WriteLine("Error leyendo CSV");
        }
    }

    // ================= GUARDAR TXT =================
    static void GuardarTXT()
    {
        try
        {
            StreamWriter sw = new StreamWriter(rutaTXT);

            for (int i = 0; i < contador; i++)
            {
                Pedido p = lista[i];
                sw.WriteLine($"Pedido {p.Envio.Codigo} - {p.Envio.Cliente}");
            }

            sw.Close();
        }
        catch
        {
            Console.WriteLine("Error TXT");
        }
    }

    // ================= LEER TXT =================
    static void LeerTXT()
    {
        try
        {
            StreamReader sr = new StreamReader(rutaTXT);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            sr.Close();
        }
        catch
        {
            Console.WriteLine("Error leyendo TXT");
        }
    }

    // ================= ÚLTIMOS 3 =================
    static void Ultimos3()
    {
        Console.WriteLine("ULTIMOS 3:");

        int inicio = contador - 3;
        if (inicio < 0) inicio = 0;

        for (int i = inicio; i < contador; i++)
        {
            Console.WriteLine(lista[i].Envio.Codigo + " - " + lista[i].Envio.Cliente);
        }
    }

    // ================= EDITAR =================
    static void Editar()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        for (int i = 0; i < contador; i++)
        {
            if (lista[i].Envio.Codigo == codigo)
            {
                Console.Write("Nuevo cliente: ");
                lista[i].Envio.Cliente = Console.ReadLine();

                Console.Write("Nuevo peso: ");
                lista[i].Peso = int.Parse(Console.ReadLine());

                Console.Write("Nuevo tipo (0-1): ");
                lista[i].Tipo = (TipoEnvio)int.Parse(Console.ReadLine());

                Console.WriteLine("Actualizado");
                return;
            }
        }

        Console.WriteLine("No encontrado");
    }

    // ================= BUSCAR CÓDIGO =================
    static void BuscarCodigo()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        for (int i = 0; i < contador; i++)
        {
            if (lista[i].Envio.Codigo == codigo)
            {
                MostrarPedido(lista[i]);
                return;
            }
        }

        Console.WriteLine("No encontrado");
    }

    // ================= BUSCAR CLIENTE =================
    static void BuscarCliente()
    {
        Console.Write("Cliente: ");
        string cliente = Console.ReadLine().ToUpper();

        bool encontrado = false;

        for (int i = 0; i < contador; i++)
        {
            if (lista[i].Envio.Cliente.ToUpper() == cliente)
            {
                MostrarPedido(lista[i]);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No encontrado");
        }
    }
}






Gemini ha dicho
¡Claro! Es un ejercicio excelente para practicar el manejo de archivos y la lógica de conjuntos en C#.

Para lograr esto, lo más eficiente es usar la clase HashSet<T>, que está diseñada específicamente para operaciones matemáticas de conjuntos como la unión y la diferencia.

Aquí tienes un ejemplo funcional y bien estructurado:

C#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string archivoA = "conjuntoA.txt";
        string archivoB = "conjuntoB.txt";

        // 1. Guardar datos de ejemplo
        File.WriteAllLines(archivoA, new[] { "1", "2", "3", "4", "5" });
        File.WriteAllLines(archivoB, new[] { "4", "5", "6", "7", "8" });

        Console.WriteLine("Archivos guardados.");

        // 2. Leer los archivos y convertirlos a conjuntos de números
        var setA = new HashSet<int>(File.ReadAllLines(archivoA).Select(int.Parse));
        var setB = new HashSet<int>(File.ReadAllLines(archivoB).Select(int.Parse));

        Console.WriteLine("\n¿Qué operación deseas realizar?");
        Console.WriteLine("1. Intersección (Números repetidos en ambos)");
        Console.WriteLine("2. Unión (Todos los números sin repetir)");
        Console.WriteLine("3. Diferencia (A - B: lo que está en A pero no en B)");
        Console.WriteLine("4. Diferencia (B - A: lo que está en B pero no en A)");

        string opcion = Console.ReadLine();
        IEnumerable<int> resultado = new List<int>();

        switch (opcion)
        {
            case "1":
                // Intersección
                resultado = setA.Intersect(setB);
                Console.WriteLine("Números repetidos en ambos:");
                break;
            case "2":
                // Unión
                resultado = setA.Union(setB);
                Console.WriteLine("Unión de ambos conjuntos:");
                break;
            case "3":
                // Diferencia A - B
                resultado = setA.Except(setB);
                Console.WriteLine("Elementos en A que no están en B:");
                break;
            case "4":
                // Diferencia B - A
                resultado = setB.Except(setA);
                Console.WriteLine("Elementos en B que no están en A:");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        // Mostrar resultado
        Console.WriteLine(string.Join(", ", resultado));
    }
}






/***
 * 
 * 
 * 
 * 1. CLASES ABSTRACTAS

Se usan cuando quieres crear una clase base que no se puede crear directamente, sino que solo sirve para que otras clases hereden de ella.

Se utiliza cuando varias clases comparten atributos o comportamientos.

Ejemplo típico
public abstract class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
}
¿Por qué se usa?

Porque Carro y Moto tienen cosas en común:

Placa

Marca

Entonces en vez de repetir código, se hereda.

Clases hijas
public class Carro : Vehiculo
{
    public int NroPuertas { get; set; }
}

public class Moto : Vehiculo
{
    public int Cilindraje { get; set; }
}

📌 Lo común en el examen:

abstract class

Herencia con :

Propiedades con {get; set;}

2. INTERFACES

Una interfaz obliga a las clases a implementar ciertos métodos.

Se usa cuando quieres asegurar que varias clases tengan el mismo comportamiento.

Ejemplo
public interface ICobrable
{
    double CalcularTarifa(int minutos);
}

Luego las clases lo implementan.

public class Carro : Vehiculo, ICobrable
{
    public int NroPuertas { get; set; }

    public double CalcularTarifa(int minutos)
    {
        return minutos * 100;
    }
}
public class Moto : Vehiculo, ICobrable
{
    public int Cilindraje { get; set; }

    public double CalcularTarifa(int minutos)
    {
        return minutos * 50;
    }
}

📌 Lo que más aparece:

interface

Implementación con :

Métodos obligatorios

3. ENUM

Un enum es una lista de valores posibles.

Se usa para evitar usar strings o números sin sentido.

Ejemplo
public enum TipoEnvio
{
    Nacional,
    Internacional
}

Luego se usa en la clase.

public class Paquete
{
    public int Guia { get; set; }
    public string Destinatario { get; set; }
    public double Peso { get; set; }
    public TipoEnvio Tipo { get; set; }
}

Cuando el usuario ingresa un número:

int tipo = int.Parse(Console.ReadLine());
paquete.Tipo = (TipoEnvio)tipo;

📌 Lo típico del parcial:

Convertir número a enum

Mostrar enum en consola

4. MENÚ INTERACTIVO

Casi todos los ejercicios usan un menú con un ciclo.

Estructura común
int opcion;

do
{
    Console.WriteLine("1. Registrar");
    Console.WriteLine("2. Buscar");
    Console.WriteLine("0. Salir");

    int.TryParse(Console.ReadLine(), out opcion);

    switch(opcion)
    {
        case 1:
            Registrar();
            break;

        case 2:
            Buscar();
            break;
    }

} while(opcion != 0);

📌 Cosas importantes aquí:

do while

switch

int.TryParse

5. MANEJO DE ARCHIVOS CSV

CSV = archivo de texto separado por ;

Ejemplo dentro del archivo:

101;Juan Perez;12.5;Nacional
102;Maria Lopez;5.2;Internacional
Guardar en archivo
StreamWriter sw = new StreamWriter("envios.csv", true);

sw.WriteLine($"{guia};{destinatario};{peso};{tipo}");

sw.Close();
Leer archivo
StreamReader sr = new StreamReader("envios.csv");

string linea;

while((linea = sr.ReadLine()) != null)
{
    string[] datos = linea.Split(';');

    int guia = int.Parse(datos[0]);
    string destinatario = datos[1];
    double peso = double.Parse(datos[2]);
}

sr.Close();

📌 Lo típico:

StreamWriter

StreamReader

Split(';')

6. TRY - CATCH

Sirve para evitar que el programa se cierre si hay errores.

Ejemplo:

try
{
    StreamReader sr = new StreamReader("envios.csv");
}
catch(Exception ex)
{
    Console.WriteLine("Error al leer el archivo");
}
7. ARREGLOS

En el primer ejercicio te dicen guardar máximo 5 vehículos.

Entonces se usa un arreglo.

Vehiculo[] lista = new Vehiculo[5];
int contador = 0;

Guardar:

lista[contador] = nuevoVehiculo;
contador++;
8. BÚSQUEDA

Buscar por placa o guía.

Ejemplo:

for(int i = 0; i < contador; i++)
{
    if(lista[i].Placa == placaBuscada)
    {
        Console.WriteLine("Encontrado");
    }
}
9. PASAR A MAYÚSCULAS

El ejercicio lo pide.

Console.WriteLine(marca.ToUpper());
10. ESTRUCTURA GENERAL DEL PROGRAMA

Normalmente el código queda así:

MODELOS
│
├── Vehiculo (abstracta)
├── Carro
├── Moto
├── Paquete
├── CitaMedica
│
INTERFACES
│
├── ICobrable
├── IPrioritario
│
ENUMS
│
├── TipoEnvio
├── Especialidad
│
PROGRAMA PRINCIPAL
│
└── Menu + funciones
COSAS QUE CASI SEGURO SALEN EN EL PARCIAL

✔ clases abstractas
✔ interfaces
✔ enums
✔ menú con do while
✔ switch
✔ int.TryParse
✔ arreglos
✔ búsqueda
✔ CSV con Split(';')
✔ StreamWriter / StreamReader
✔ try catch



🚀 🔥 RESUMEN CLAVE (LO QUE MÁS CAE EN PARCIAL)

Antes del código, esto es lo que sí o sí debes dominar:

🧠 1. POO (LO MÁS IMPORTANTE)

abstract → clase base que no se puede instanciar

interface → contrato obligatorio

override → modificar comportamiento

polimorfismo → lista de tipo interfaz o clase base

🧠 2. ARCHIVOS (FIJO EN PARCIAL)

File.WriteAllText() → escribir (sobrescribe)

File.AppendAllText() → agregar

File.ReadAllText() → leer

Directory.CreateDirectory() → crear carpeta

Path.Combine() → rutas seguras

🧠 3. VALIDACIONES (TE LAS PIDEN SIEMPRE)

TryParse()

if (cantidad > 0)

File.Exists()

🧠 4. MENÚ (OBLIGATORIO)

while + switch

💻 CÓDIGO COMPLETO (LO MÁS USADO + COMENTADO)

Te dejo un ejemplo tipo examen que mezcla TODO lo importante 👇

🧩 INTERFAZ (CONTRATO)
// INTERFAZ → Define lo que una clase DEBE hacer (contrato)
public interface IPrestable
{
    DateTime CalcularFechaDevolucion(); // calcula fecha
    void GenerarComprobante(); // imprime info
}
🧩 CLASE ABSTRACTA (BASE)
// CLASE ABSTRACTA → no se puede crear directamente
public abstract class MaterialBiblioteca
{
    // PROPIEDADES comunes a todos
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }

    // CONSTRUCTOR protegido → solo lo usan las clases hijas
    protected MaterialBiblioteca(int id, string titulo, string autor)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
    }

    // MÉTODO VIRTUAL → se puede modificar en hijos
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"ID: {Id} - Título: {Titulo} - Autor: {Autor}");
    }
}
📘 CLASE HIJA (HERENCIA + INTERFAZ)
// HEREDA de MaterialBiblioteca e IMPLEMENTA interfaz
public class Libro : MaterialBiblioteca, IPrestable
{
    public int Paginas { get; set; }

    public Libro(int id, string titulo, string autor, int paginas)
        : base(id, titulo, autor) // llama al constructor padre
    {
        Paginas = paginas;
    }

    // OVERRIDE → modifica método del padre
    public override void MostrarInfo()
    {
        base.MostrarInfo(); // reutiliza código base
        Console.WriteLine($"Páginas: {Paginas}");
    }

    // IMPLEMENTACIÓN DE INTERFAZ
    public DateTime CalcularFechaDevolucion()
    {
        return DateTime.Now.AddDays(7); // préstamo de 7 días
    }

    public void GenerarComprobante()
    {
        Console.WriteLine($"Libro prestado: {Titulo}");
        Console.WriteLine($"Devolver antes de: {CalcularFechaDevolucion()}");
    }
}
📂 MANEJO DE ARCHIVOS (FIJO EN EXAMEN)
using System.IO;

public class Archivos
{
    public static void Guardar(string texto)
    {
        try
        {
            string ruta = Path.Combine("datos.txt"); // ruta segura

            // APPEND → NO borra lo anterior
            File.AppendAllText(ruta, texto + Environment.NewLine);

            Console.WriteLine("Guardado correctamente");
        }
        catch (Exception ex)
        {
            // MANEJO DE ERRORES → obligatorio
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void Leer()
    {
        string ruta = "datos.txt";

        if (File.Exists(ruta)) // VALIDACIÓN
        {
            string contenido = File.ReadAllText(ruta);
            Console.WriteLine(contenido);
        }
    }
}
🧠 MENÚ PRINCIPAL (OBLIGATORIO EN TODOS)
class Program
{
    static void Main()
    {
        List<IPrestable> lista = new List<IPrestable>(); // POLIMORFISMO

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Mostrar préstamos");
            Console.WriteLine("3. Guardar en archivo");
            Console.WriteLine("0. Salir");

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    // CREA OBJETO
                    Libro libro = new Libro(1, titulo, "Autor X", 100);

                    lista.Add(libro); // guarda en lista
                    break;

                case "2":
                    foreach (var item in lista)
                    {
                        item.GenerarComprobante(); // POLIMORFISMO
                    }
                    break;

                case "3":
                    Archivos.Guardar("Nuevo registro guardado");
                    break;

                case "0":
                    salir = true;
                    break;
            }
        }
    }
}
🎯 LO QUE TE VAN A PREGUNTAR S