using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FormConsultas : Form
    {
        private string rutaConsultas = "consultas.csv";
        private string rutaMascotas = "mascotas.csv";
        private string rutaPropietarios = "propietarios.csv";

        public FormConsultas()
        {
            InitializeComponent();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void CargarComboMascotas()
        {
            cmbMascota.Items.Clear();
            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).Skip(1);
                foreach (var linea in lineas)
                {
                    var c = linea.Split(',');
                    if (c.Length >= 3) cmbMascota.Items.Add($"{c[0]} — {c[1]} ({c[2]})");
                }
            }
        }

        private void cmbMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMascota.SelectedIndex == -1) return;

            string idMascota = cmbMascota.Text.Split('—')[0].Trim();

            if (File.Exists(rutaMascotas))
            {
                var mascota = File.ReadAllLines(rutaMascotas)
                                  .Skip(1)
                                  .Select(l => l.Split(','))
                                  .FirstOrDefault(c => c[0] == idMascota);

                if (mascota != null)
                {
                    string idDuenio = mascota[5];
                    AutocompletarPropietario(idDuenio);
                }
            }
        }

        private void AutocompletarPropietario(string idDuenio)
        {
            if (File.Exists(rutaPropietarios))
            {
                var duenio = File.ReadAllLines(rutaPropietarios)
                                 .Skip(1)
                                 .Select(l => l.Split(','))
                                 .FirstOrDefault(c => c[0] == idDuenio);

                if (duenio != null) txtPropietario.Text = duenio[1];
            }
        }

        private void btnRegistrarConsulta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // REGLA DE ORO: Si el ID ya existe, no guarda nada
                if (IdYaExiste(txtIDConsulta.Text.Trim()))
                {
                    MessageBox.Show("¡Error! El ID de consulta ya existe. Use uno diferente o presione Actualizar si desea editar el registro.", "ID DUPLICADO");
                    return; // Detiene el proceso de guardado
                }

                string idMascota = cmbMascota.Text.Split('—')[0].Trim();
                string nuevaLinea = $"{txtIDConsulta.Text},{txtFecha.Text},{idMascota},{txtPropietario.Text},{txtMotivo.Text},{txtDiagnostico.Text},{numCosto.Value}";

                if (!File.Exists(rutaConsultas))
                    File.WriteAllText(rutaConsultas, "ID,Fecha,IDMascota,Propietario,Motivo,Diagnostico,Costo\n");

                File.AppendAllLines(rutaConsultas, new[] { nuevaLinea });
                MessageBox.Show("Consulta registrada con éxito", "VET SALUD");
                LimpiarInterfaz();
            }
        }

        // Función para verificar si el ID ya está en el CSV
        private bool IdYaExiste(string id)
        {
            if (!File.Exists(rutaConsultas)) return false;

            return File.ReadAllLines(rutaConsultas)
                       .Skip(1)
                       .Select(linea => linea.Split(',')[0])
                       .Any(idExistente => idExistente.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        private void CargarConsultasHoy()
        {
            dgvConsultas.Rows.Clear();
            decimal totalFacturado = 0;

            if (File.Exists(rutaConsultas))
            {
                var lineas = File.ReadAllLines(rutaConsultas).Skip(1);

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    var c = linea.Split(',');

                    if (c.Length >= 7)
                    {
                        decimal costoVal = 0;
                        if (decimal.TryParse(c[6], out costoVal))
                        {
                            dgvConsultas.Rows.Add(c[0], c[2], c[3], c[4], $"${costoVal:N3}");
                            totalFacturado += costoVal;
                        }
                    }
                }
            }

            lblTotalHoy.Text = $"💰 Total facturado hoy: ${totalFacturado:N3}";
            lblConsultasHoy.Text = $"Consultas hoy: {dgvConsultas.Rows.Count}";
            lblIngresosFooter.Text = $"Ingresos: ${totalFacturado:N3}";
        }

        private void CargarIDNuevo()
        {
            int maxId = 0;
            if (File.Exists(rutaConsultas))
            {
                var lineas = File.ReadAllLines(rutaConsultas).Skip(1);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(',');
                    if (partes.Length > 0 && int.TryParse(partes[0].Replace("C", ""), out int id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            txtIDConsulta.Text = "C" + (maxId + 1).ToString("D2");
        }

        private void LimpiarInterfaz()
        {
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtPropietario.Clear();
            cmbMascota.SelectedIndex = -1;
            numCosto.Value = 0;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarIDNuevo();
            CargarComboMascotas();
            CargarConsultasHoy();
        }

        private bool ValidarCampos()
        {
            if (!txtIDConsulta.Text.StartsWith("C") || txtIDConsulta.Text.Length < 2)
            {
                MessageBox.Show("El ID debe iniciar con 'C' seguido de números.");
                return false;
            }
            if (cmbMascota.SelectedIndex == -1) return false;
            if (string.IsNullOrWhiteSpace(txtMotivo.Text)) return false;
            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDConsulta.Text)) return;

            string idABuscar = txtIDConsulta.Text.Trim();
            if (File.Exists(rutaConsultas))
            {
                List<string> lineas = File.ReadAllLines(rutaConsultas).ToList();
                bool encontrado = false;

                for (int i = 1; i < lineas.Count; i++) // Saltamos encabezado
                {
                    if (lineas[i].StartsWith(idABuscar + ","))
                    {
                        string idMascota = cmbMascota.Text.Split('—')[0].Trim();
                        // Actualizamos la línea con los datos actuales de los campos
                        lineas[i] = $"{idABuscar},{txtFecha.Text},{idMascota},{txtPropietario.Text},{txtMotivo.Text},{txtDiagnostico.Text},{numCosto.Value}";
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    File.WriteAllLines(rutaConsultas, lineas);
                    MessageBox.Show("Registro actualizado correctamente.");
                    CargarConsultasHoy();
                }
                else
                {
                    MessageBox.Show("No se encontró el ID para actualizar. Use 'Registrar' para nuevos datos.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila en la tabla para eliminar.");
                return;
            }

            string idAEliminar = dgvConsultas.CurrentRow.Cells[0].Value.ToString();

            var respuesta = MessageBox.Show($"¿Desea eliminar la consulta {idAEliminar}?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                var lineasSanas = File.ReadAllLines(rutaConsultas)
                                      .Where(l => !l.StartsWith(idAEliminar + ","))
                                      .ToList();

                File.WriteAllLines(rutaConsultas, lineasSanas);
                MessageBox.Show("Consulta eliminada.");
                LimpiarInterfaz();
            }
        }

       
    }
}
