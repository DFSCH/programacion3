using System;
using System.Collections.Generic;
using ejerciciopasoapaso.interfaces;
using ejerciciopasoapaso.Modelo; // ¡No olvides este!

internal class Program
{
    static void Main(string[] args)
    {
        List<Ireproductor> Playlist = new List<Ireproductor>();
        bool continu = true; // CAMBIO: Debe ser true para entrar al ciclo

        while (continu)
        {
            Console.WriteLine("\n--- MENÚ REPRODUCTOR ---");
            Console.WriteLine("1. agregar cancion");
            Console.WriteLine("2. agregar podcast");
            Console.WriteLine("3. Reproducir todo");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");

            string opcion = Console.ReadLine()?.ToLower(); // ToLower ayuda a validar mejor

            switch (opcion)
            {
                case "1":
                case "agregar cancion":
                    Console.Write("Nombre: ");
                    string nC = Console.ReadLine();
                    Console.Write("Artista: ");
                    string aC = Console.ReadLine();
                    Console.Write("año: ");
                    string aA = Console.ReadLine();
                    Playlist.Add(new Cancion(nC, aC, aA));
                    break;

                case "2":
                case "agregar podcast":
                    Console.Write("Nombre: ");
                    string nP = Console.ReadLine();
                    Console.Write("Autor: ");
                    string aP = Console.ReadLine();
                    Console.Write("Episodio: ");
                    string eP = Console.ReadLine();
                    Playlist.Add(new Podcast(nP, aP, eP));
                    break;

                case "3":
                case "reproducir todo":
                    Console.WriteLine("\n--- Iniciando Playlist ---");
                    foreach (var item in Playlist) { item.Play(); }
                    break;

                case "4":
                case "salir":
                    continu = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}