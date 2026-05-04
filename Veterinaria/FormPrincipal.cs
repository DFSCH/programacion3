namespace Veterinaria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            FormPropietarios formularioPropietarios = new FormPropietarios();

            formularioPropietarios.ShowDialog();

        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            FormMascotas formularioMascotas = new FormMascotas();

            formularioMascotas.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormConsultas formularioConsultas = new FormConsultas();

            formularioConsultas.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            new FormHistorial().Show();
        }

      
    }
}
