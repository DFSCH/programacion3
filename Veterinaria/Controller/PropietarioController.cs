using System.Collections.Generic;
using System.IO;
using System.Linq;
using Veterinaria.MODELO;


public class PropietarioController
{
    private string rutaArchivo = "propietarios.csv";
    private string rutaMascotas = "mascotas.csv";

    public List<Propietario> ObtenerTodos()
    {
        var lista = new List<Propietario>();
        if (!File.Exists(rutaArchivo)) return lista;

        var lineasPropietarios = File.ReadAllLines(rutaArchivo).Skip(1);
        List<string> listaMascotas = File.Exists(rutaMascotas)
            ? File.ReadAllLines(rutaMascotas).Skip(1).ToList()
            : new List<string>();

        foreach (var linea in lineasPropietarios)
        {
            var c = linea.Split(',');
            if (c.Length >= 4)
            {
                string idProp = c[0];
                int conteo = listaMascotas.Count(m => m.Split(',').Length > 5 && m.Split(',')[5] == idProp);

                lista.Add(new Propietario
                {
                    ID = c[0],
                    Nombre = c[1],
                    Telefono = c[2],
                    Correo = c[3],
                    Direccion = c.Length > 4 ? c[4] : "",
                    CantidadMascotas = conteo
                });
            }
        }
        return lista;
    }

 
    public string CargarIDNuevo()
    {
        int maxId = 0;
        if (File.Exists(rutaArchivo))
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1);
            foreach (var linea in lineas)
            {
                string idLimpio = linea.Split(',')[0].Replace("P", "");
                if (int.TryParse(idLimpio, out int idActual))
                {
                    if (idActual > maxId) maxId = idActual;
                }
            }
        }
        return "P" + (maxId + 1).ToString("D2");
    }

 
    public bool Registrar(Propietario p, out string mensaje)
    {
        if (ObtenerTodos().Any(x => x.ID == p.ID))
        {
            mensaje = "El ID ya existe.";
            return false;
        }

        if (!File.Exists(rutaArchivo))
            File.WriteAllText(rutaArchivo, "ID,Nombre,Telefono,Correo,Direccion\n");

        string nuevaLinea = $"{p.ID},{p.Nombre},{p.Telefono},{p.Correo},{p.Direccion}";
        File.AppendAllLines(rutaArchivo, new[] { nuevaLinea });
        mensaje = "Propietario registrado con éxito";
        return true;
    }

    public void Actualizar(Propietario p)
    {
        if (!File.Exists(rutaArchivo)) return;
        var lineas = File.ReadAllLines(rutaArchivo).ToList();
        for (int i = 0; i < lineas.Count; i++)
        {
            if (lineas[i].StartsWith(p.ID + ","))
            {
                lineas[i] = $"{p.ID},{p.Nombre},{p.Telefono},{p.Correo},{p.Direccion}";
                break;
            }
        }
        File.WriteAllLines(rutaArchivo, lineas);
    }

    public void Eliminar(string id)
    {
        if (!File.Exists(rutaArchivo)) return;
        var lineas = File.ReadAllLines(rutaArchivo).Where(l => !l.StartsWith(id + ",")).ToList();
        File.WriteAllLines(rutaArchivo, lineas);
    }

 
}
