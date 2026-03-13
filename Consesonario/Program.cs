using Consesonario.Confecionario.Enums;
using Consesonario.Confecionario.Interfaces;
using Consesonario.Confecionario.Modelos;

static void Main()
{
    // Creamos instancias de cada tipo
    Auto miAuto = new Auto(1, "Toyota", "Corolla", 2024, 25000, TipoCombustible.Hibrido, EstadoVehiculo.Nuevo, 4, true);
    Motocicleta miMoto = new Motocicleta(2, "Yamaha", "R6", 2023, 12000, TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, 600, true);
    Camion miCamion = new Camion(3, "Volvo", "FH16", 2022, 80000, TipoCombustible.Diesel, EstadoVehiculo.Seminuevo, 20, 4);

    // Lista de vehículos vendibles para demostrar polimorfismo
    var inventario = new System.Collections.Generic.List<IVendible> { miAuto, miMoto, miCamion };

    Console.WriteLine("--- SISTEMA DE CONCESIONARIO --- \n");

    foreach (var v in inventario)
    {
        // Como Vehiculo es la base, podemos mostrar sus specs
        ((Vehiculo)v).MostrarEspecificaciones();
        v.GenerarFacturaVenta();
        Console.WriteLine($"Comisión: {v.CalcularComisionVendedor():C}");
        Console.WriteLine("--------------------------------");
    }
}