namespace Gestión_de_Inventario
{
    public partial class Form1 : Form
    {
        // Nombre del archivo constante
        private string archivo = "productos.csv";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener los datos de los controles
                string nombre = txtNombre.Text;
                string codigo = txtCodigo.Text;
                decimal costo = numCosto.Value;
                int cantidad = (int)numCantidad.Value;

                // 2. Concatenar los campos en una línea de texto (CSV)
                string linea = $"{nombre},{codigo},{costo},{cantidad}{Environment.NewLine}";

                // 3. Guardar en el archivo usando File.AppendAllText
                File.AppendAllText(archivo, linea);

                // Limpiar campos después de guardar (opcional pero recomendado)
                txtNombre.Clear();
                txtCodigo.Clear();
                numCosto.Value = 0;
                numCantidad.Value = 0;

                MessageBox.Show("Producto guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Limpiar el ListBox
                lstProductos.Items.Clear();

                // 2. Verificar si el archivo existe antes de leer
                if (File.Exists(archivo))
                {
                    // 3. Leer todas las líneas del archivo
                    string[] lineas = File.ReadAllLines(archivo);

                    // 4. Cargar los datos mediante un ciclo foreach
                    foreach (string linea in lineas)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            lstProductos.Items.Add(linea);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aún no hay productos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }
    }
}

