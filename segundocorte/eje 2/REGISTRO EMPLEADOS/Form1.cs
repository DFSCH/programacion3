using System;
using System.Text.RegularExpressions; // Asegúrate que esté fuera del namespace
using System.Windows.Forms;

namespace REGISTRO_EMPLEADOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Limpiar errores previos
            errorProvider1.Clear();

            // 2. Validaciones (Si devuelve false, el "return" detiene la ejecución aquí)
            if (!ValidarCampos()) return;

            // 3. Lógica de Negocio (Cálculo)
            decimal sueldoBase = numSueldoBase.Value;
            decimal retencion = sueldoBase * 0.10m;
            decimal sueldoNeto = sueldoBase - retencion;

            // 4. Mostrar Resultado
            lblResultadoSueldo.Text = $"Sueldo Neto: {sueldoNeto:C2}";

            MessageBox.Show("Empleado registrado con éxito.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar Vacíos (Nombres, Apellidos, Departamento)
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "El nombre es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "El apellido es obligatorio");
                esValido = false;
            }

            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDepartamento, "Seleccione un departamento");
                esValido = false;
            }

            // Validar Email con Regex
            string patronEmail = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(txtEmail.Text, patronEmail))
            {
                errorProvider1.SetError(txtEmail, "Formato de correo inválido (ejemplo@correo.com)");
                esValido = false;
            }

            // Validar Identificación (10 dígitos)
            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtIdentificacion, "La identificación debe tener 10 dígitos numéricos");
                esValido = false;
            }

            // --- ESTA ES LA LÍNEA QUE CORRIGE EL ERROR ---
            return esValido;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los controles
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            numSueldoBase.Value = 1000;
            cmbDepartamento.SelectedIndex = -1;
            lblResultadoSueldo.Text = "Sueldo Neto: $0.00";
            errorProvider1.Clear();
        }
    }
}