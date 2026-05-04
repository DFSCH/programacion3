using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



using Veterinaria.MODELO;

namespace Veterinaria
{
    public partial class FormPropietarios : Form
    {
        private PropietarioController controlador = new PropietarioController();

        // Rutas de archivos CSV
        private string rutaArchivo = "propietarios.csv";
        private string rutaMascotas = "mascotas.csv";

        public FormPropietarios()
        {
            InitializeComponent();
        }

        // Se ejecuta al abrir el formulario
        private void FormPropietarios_Load(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.Trim().ToUpper();

            if (ValidarCampos())
            {
                var nuevoPropietario = new Propietario
                {
                    ID = txtID.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text
                };

                if (controlador.Registrar(nuevoPropietario, out string mensaje))
                {
                    MessageBox.Show(mensaje, "VET SALUD");
                    LimpiarInterfaz();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

            var confirmacion = MessageBox.Show("¿Desea guardar los cambios en este registro?", "Actualizar", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                var propietarioActualizado = new Propietario
                {
                    ID = txtID.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text
                };

                controlador.Actualizar(propietarioActualizado);
                MessageBox.Show("Datos actualizados correctamente.");
                LimpiarInterfaz();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropietarios.SelectedRows.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Está seguro de eliminar este propietario?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    string idEliminar = dgvPropietarios.SelectedRows[0].Cells[0].Value.ToString();
                    controlador.Eliminar(idEliminar);
                    MessageBox.Show("Propietario eliminado.");
                    LimpiarInterfaz();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila en la tabla primero.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToUpper();
            dgvPropietarios.CurrentCell = null;

            foreach (DataGridViewRow fila in dgvPropietarios.Rows)
            {
                if (fila.IsNewRow) continue;

                string id = fila.Cells[0].Value?.ToString().ToUpper() ?? "";
                string nombre = fila.Cells[1].Value?.ToString().ToUpper() ?? "";

                if (string.IsNullOrEmpty(filtro))
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = (id.Contains(filtro) || nombre.Contains(filtro));
                }
            }

            int visibles = dgvPropietarios.Rows.Cast<DataGridViewRow>().Count(f => f.Visible && !f.IsNewRow);
            lblContador.Text = $"{visibles} resultados encontrados";
        }

        private void CargarDatosEnTabla()
        {
            dgvPropietarios.Rows.Clear();
            var propietarios = controlador.ObtenerTodos();

            foreach (var p in propietarios)
            {
                dgvPropietarios.Rows.Add(p.ID, p.Nombre, p.Telefono, p.Correo, p.CantidadMascotas);
            }

            lblContador.Text = $"{propietarios.Count} propietarios registrados";
        }

        private void dgvPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPropietarios.Rows[e.RowIndex];
                string idSeleccionado = fila.Cells[0].Value?.ToString();

                // Buscamos el objeto completo para obtener la dirección (que no suele estar en el DGV)
                var p = controlador.ObtenerTodos().FirstOrDefault(x => x.ID == idSeleccionado);

                if (p != null)
                {
                    txtID.Text = p.ID;
                    txtNombre.Text = p.Nombre;
                    txtTelefono.Text = p.Telefono;
                    txtCorreo.Text = p.Correo;
                    txtDireccion.Text = p.Direccion;
                }
            }
        }

        private void CargarIDNuevo()
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
            // Genera P01, P02, etc.
            txtID.Text = "P" + (maxId + 1).ToString("D2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarInterfaz();

        private void LimpiarInterfaz()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtBuscar.Clear();
            CargarDatosEnTabla();
            CargarIDNuevo();
        }

        private bool ValidarCampos()
        {
            string id = txtID.Text;
            if (string.IsNullOrWhiteSpace(id) || !id.StartsWith("P") || id.Length < 2)
            {
                MessageBox.Show("El ID debe iniciar con la letra 'P' seguida de números (Ej: P01).", "Error de Formato");
                txtID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Falta el nombre.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Falta el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            return true;
        }
        public bool Registrar(Propietario p, out string mensaje)
        {
            if (ObtenerTodos().Any(l => l.ID == p.ID))
            {
                mensaje = "El ID ya existe en el sistema.";
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
            if (File.Exists(rutaArchivo))
            {
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
        }
        public void Eliminar(string id)
        {
            if (File.Exists(rutaArchivo))
            {
                var lineas = File.ReadAllLines(rutaArchivo).Where(l => !l.StartsWith(id + ",")).ToList();
                File.WriteAllLines(rutaArchivo, lineas);
            }
        }

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

        
        
    }
}
