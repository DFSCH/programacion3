namespace Registro_de_Clientes
{
    public partial class Form1 : Form
    {
        private string rutaArchivo = "clientes.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Capturar datos de los TextBox
            string dni = txtDNI.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();

            // 2. DESAFÍO: Validaciones
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El DNI y el Nombre Completo son campos obligatorios.", "Validación");
                return; // Detiene la ejecución si falta información
            }

            // 3. DESAFÍO: Ciudad por defecto
            if (string.IsNullOrEmpty(ciudad))
            {
                ciudad = "No especificado";
            }

            try
            {
                // 4. PERSISTENCIA: Formatear y guardar
                string registro = $"{dni} | {nombre} | {ciudad}{Environment.NewLine}";
                File.AppendAllText(rutaArchivo, registro);

                MessageBox.Show("Cliente registrado con éxito.");

                // Limpieza de campos
                txtDNI.Clear();
                txtNombre.Clear();
                txtCiudad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }



        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            

            lstClientes.Items.Clear();

            if (File.Exists(rutaArchivo))
            {
                // PERSISTENCIA: ReadAllLines devuelve un arreglo de strings
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    lstClientes.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de registros.");
            }

        }
    }
}
