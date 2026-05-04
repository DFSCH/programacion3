using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FormMascotas : Form
    {
        private string rutaMascotas = "mascotas.csv";
        private string rutaPropietarios = "propietarios.csv";

        public FormMascotas()
        {
            InitializeComponent();
        }

        private void FormMascotas_Load(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void CargarComboPropietarios()
        {
            cmbPropietario.Items.Clear();
            if (File.Exists(rutaPropietarios))
            {
                var lineas = File.ReadAllLines(rutaPropietarios).Skip(1);
                foreach (var linea in lineas)
                {
                    var c = linea.Split(',');
                    // Formato requerido: P01 — Carlos Mendoza
                    if (c.Length >= 2) cmbPropietario.Items.Add($"{c[0]} — {c[1]}");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToUpper();
            CargarDatosEnTabla(filtro);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string idDuenio = cmbPropietario.Text.Split(' ')[0];
                string fechaCSV = dtpFechaNac.Value.ToString("dd/MM/yyyy");

                string nuevaLinea = $"{txtID.Text},{txtNombre.Text},{cmbEspecie.Text},{txtRaza.Text},{fechaCSV},{idDuenio}";

                if (!File.Exists(rutaMascotas))
                    File.WriteAllText(rutaMascotas, "ID,Nombre,Especie,Raza,FechaNac,IDPropietario\n");

                File.AppendAllLines(rutaMascotas, new[] { nuevaLinea });
                MessageBox.Show("Paciente registrado correctamente", "VET SALUD");
                LimpiarInterfaz();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).ToList();
                string idDuenio = cmbPropietario.Text.Split(' ')[0];
                string fechaCSV = dtpFechaNac.Value.ToString("dd/MM/yyyy");

                for (int i = 0; i < lineas.Count; i++)
                {
                    if (lineas[i].StartsWith(txtID.Text + ","))
                    {
                        lineas[i] = $"{txtID.Text},{txtNombre.Text},{cmbEspecie.Text},{txtRaza.Text},{fechaCSV},{idDuenio}";
                        break;
                    }
                }
                File.WriteAllLines(rutaMascotas, lineas);
                MessageBox.Show("Datos actualizados", "VET SALUD");
                LimpiarInterfaz();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    string id = dgvMascotas.SelectedRows[0].Cells[0].Value.ToString();
                    var lineas = File.ReadAllLines(rutaMascotas).Where(l => !l.StartsWith(id + ",")).ToList();
                    File.WriteAllLines(rutaMascotas, lineas);
                    LimpiarInterfaz();
                }
            }
        }


        private void CargarDatosEnTabla(string filtro = "")
        {
            dgvMascotas.Rows.Clear();
            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).Skip(1);
                foreach (var linea in lineas)
                {
                    var c = linea.Split(',');
                    if (c.Length >= 6)
                    {
                        string nombre = c[1].ToUpper();
                        string idDuenio = c[5].ToUpper();

                        if (string.IsNullOrEmpty(filtro) || nombre.Contains(filtro) || idDuenio.Contains(filtro))
                        {
                            // Edad según taller: (Hoy - FechaNac).Days / 365
                            int años = 0;
                            if (DateTime.TryParse(c[4], out DateTime fechaNac))
                            {
                                años = (DateTime.Now - fechaNac).Days / 365;
                            }
                            dgvMascotas.Rows.Add(c[0], c[1], c[2], c[3], $"{años} años", c[5]);
                        }
                    }
                }
            }
            lblEstadoMascotas.Text = $"{dgvMascotas.Rows.Cast<DataGridViewRow>().Count(f => f.Visible && !f.IsNewRow)} mascotas encontradas";
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMascotas.Rows[e.RowIndex];
                txtID.Text = fila.Cells[0].Value?.ToString();
                txtNombre.Text = fila.Cells[1].Value?.ToString();
                cmbEspecie.Text = fila.Cells[2].Value?.ToString();
                txtRaza.Text = fila.Cells[3].Value?.ToString();

                var linea = File.ReadAllLines(rutaMascotas).FirstOrDefault(l => l.StartsWith(txtID.Text + ","));
                if (linea != null && DateTime.TryParse(linea.Split(',')[4], out DateTime fecha))
                {
                    dtpFechaNac.Value = fecha;
                }

                string idBusca = fila.Cells[5].Value?.ToString();
                foreach (var item in cmbPropietario.Items)
                {
                    if (item.ToString().StartsWith(idBusca)) { cmbPropietario.SelectedItem = item; break; }
                }
            }
        }

        private void CargarIDNuevo()
        {
            int maxId = 0;
            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).Skip(1);
                foreach (var linea in lineas)
                {
                    string idString = linea.Split(',')[0].Replace("M", "");
                    if (int.TryParse(idString, out int idActual))
                    {
                        if (idActual > maxId) maxId = idActual;
                    }
                }
            }
            txtID.Text = "M" + (maxId + 1).ToString("D2");
        }

        private void LimpiarInterfaz()
        {
            txtNombre.Clear();
            txtRaza.Clear();
            txtBuscar.Clear();
            dtpFechaNac.Value = DateTime.Now;
            lblEdadCalculada.Text = "Edad calculada: 0 años, 0 meses";
            CargarIDNuevo();
            CargarComboPropietarios();
            CargarDatosEnTabla();
        }

        private bool ValidarCampos()
        {
            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la mascota es obligatorio.");
                return false;
            }

    
            string id = txtID.Text.Trim();
      
            if (string.IsNullOrWhiteSpace(id) || !id.StartsWith("M") || id.Length < 2)
            {
                MessageBox.Show("El ID debe iniciar con la letra 'M' seguida de números (Ej: M01).", "Error de Formato");
                txtID.Focus();
                return false;
            }

         
            if (cmbPropietario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un propietario.");
                return false;
            }

   
            if (dtpFechaNac.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.");
                return false;
            }

            return true;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNac = dtpFechaNac.Value;
            DateTime hoy = DateTime.Now;

            // Lógica detallada para el label visual
            int anios = hoy.Year - fechaNac.Year;
            if (hoy < fechaNac.AddYears(anios)) anios--;

            int meses = hoy.Month - fechaNac.Month;
            if (hoy.Day < fechaNac.Day) meses--;
            if (meses < 0) meses += 12;

            lblEdadCalculada.Text = $"🗓️ Edad calculada: {anios} años, {meses} meses";
        }

        
    }
}