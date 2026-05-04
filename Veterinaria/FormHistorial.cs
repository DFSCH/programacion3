using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FormHistorial : Form
    {
        private string rutaConsultas = "consultas.csv";
        private string rutaMascotas = "mascotas.csv";
        private string rutaPropietarios = "propietarios.csv";

        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            CargarTodo();
            CargarFiltros();
        }

        private void CargarTodo()
        {
            if (!File.Exists(rutaConsultas)) return;

            var consultas = File.ReadAllLines(rutaConsultas).Skip(1).ToList();

            // 1. Cálculos de las Cards Superiores
            decimal totalIngresos = 0;
            int totalConsultas = consultas.Count;

            foreach (var linea in consultas)
            {
                var c = linea.Split(',');
                if (c.Length >= 7 && decimal.TryParse(c[6], out decimal costo))
                {
                    totalIngresos += costo;
                }
            }

            // Llenar los labels de arriba
            lblTotalConsultas.Text = totalConsultas.ToString();
            lblIngresosTotales.Text = $"${totalIngresos:N0}K";
            SConsulta.Text = $"{totalConsultas:N0} CONSULTAS"; // Total facturado
            STotal.Text = $"TOTAL ${totalIngresos:N0}K";

            decimal promedio = totalConsultas > 0 ? totalIngresos / totalConsultas : 0;
            lblPromedio.Text = $"${promedio:N1}K";

            // 2. Llenar Tabla Principal (Historial de Consultas)
            dgvHistorialCompleto.Rows.Clear();
            foreach (var linea in consultas)
            {
                var c = linea.Split(',');
                if (c.Length >= 7)
                {
                    // Formato: ID, Fecha, Mascota, Propietario, Motivo, Diagnóstico, Costo
                    dgvHistorialCompleto.Rows.Add(c[0], c[1], c[2], c[3], c[4], c[5], $"${decimal.Parse(c[6]):N3}");
                }
            }

            // 3. Resumen por Mascota (Cruzar datos)
            CargarResumenMascotas(consultas);
        }

        private void CargarResumenMascotas(List<string> consultas)
        {
            dgvResumenMascotas.Rows.Clear();
            if (!File.Exists(rutaMascotas)) return;

            var mascotas = File.ReadAllLines(rutaMascotas).Skip(1);
            int contadorMascotasAtendidas = 0;

            foreach (var lineaM in mascotas)
            {
                var m = lineaM.Split(',');
                string idMascota = m[0];

                // Contar cuántas consultas tiene esta mascota y sumar su costo
                var consultasMascota = consultas.Where(lineaC => lineaC.Split(',')[2] == idMascota).ToList();

                if (consultasMascota.Count > 0)
                {
                    contadorMascotasAtendidas++;
                    decimal sumaFalturada = consultasMascota.Sum(l => decimal.Parse(l.Split(',')[6]));

                    // Agregar a la tabla de abajo: ID, Nombre, Especie, Propietario, Cant. Consultas, Total Facturado
                    dgvResumenMascotas.Rows.Add(m[0], m[1], m[2], m[4], consultasMascota.Count, $"${sumaFalturada:N3}");
                }
            }
            lblMascotasAtendidas.Text = contadorMascotasAtendidas.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaConsultas)) return;

            // 1. Obtener los criterios de búsqueda de los combos
            // Asumiendo que el texto es "M01 — Luna" o "M02 — Michi"
            string filtroMascota = cmbMascotaHistorial.Text.Split('—')[0].Trim();
            string filtroPropietario = cmbPropietarioHistorial.Text.Trim();

            // 2. Leer todas las consultas (saltando el encabezado)
            var todasLasConsultas = File.ReadAllLines(rutaConsultas).Skip(1).ToList();

            // 3. Aplicar los filtros
            var consultasFiltradas = todasLasConsultas.Where(linea =>
            {
                var c = linea.Split(',');
                bool coincideMascota = true;
                bool coincidePropietario = true;

                // Si no seleccionó "Todas las mascotas" o "Todos"
                if (cmbMascotaHistorial.SelectedIndex > 0)
                    coincideMascota = c[2] == filtroMascota; // El ID de mascota está en c[2]

                if (cmbPropietarioHistorial.SelectedIndex > 0)
                    coincidePropietario = c[3].ToLower().Contains(filtroPropietario.ToLower());

                return coincideMascota && coincidePropietario;
            }).ToList();

            // 4. Mostrar los resultados en la tabla principal
            dgvHistorialCompleto.Rows.Clear();
            decimal totalFiltrado = 0;

            foreach (var linea in consultasFiltradas)
            {
                var c = linea.Split(',');
                if (c.Length >= 7)
                {
                    decimal costo = decimal.Parse(c[6]);
                    dgvHistorialCompleto.Rows.Add(c[0], c[1], c[2], c[3], c[4], c[5], $"${costo:N3}");
                    totalFiltrado += costo;
                }
            }

           
            lblTotalConsultas.Text = consultasFiltradas.Count.ToString();
            lblIngresosTotales.Text = $"${(totalFiltrado / 1000):N1}K"; 

           
            CargarResumenMascotas(consultasFiltradas);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarTodo();
        }

        private void CargarFiltros()
        {
           
            cmbMascotaHistorial.Items.Clear();
            cmbMascotaHistorial.Items.Add("— Todas las mascotas —");
            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).Skip(1);
                foreach (var linea in lineas)
                {
                    var c = linea.Split(',');
                    
                    if (c.Length >= 2) cmbMascotaHistorial.Items.Add($"{c[0]} — {c[1]}");
                }
            }
            cmbMascotaHistorial.SelectedIndex = 0; 

            
            cmbPropietarioHistorial.Items.Clear();
            cmbPropietarioHistorial.Items.Add("— Todos —");
            if (File.Exists(rutaPropietarios))
            {
                var lineas = File.ReadAllLines(rutaPropietarios).Skip(1);
                foreach (var linea in lineas)
                {
                    var c = linea.Split(',');
                    if (c.Length >= 2) cmbPropietarioHistorial.Items.Add(c[1]);
                }
            }
            cmbPropietarioHistorial.SelectedIndex = 0;
        }

       
    }
}