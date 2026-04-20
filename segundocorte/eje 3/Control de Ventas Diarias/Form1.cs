namespace Control_de_Ventas_Diarias
{
    public partial class Form1 : Form
    {
        private string archivoVentas = "ventas.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Capturar datos: ID y Monto
            string id = txtID.Text.Trim();
            double monto = (double)numMonto.Value;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de transacción.");
                return;
            }

            // Guardar en formato CSV: ID,Monto
            string registro = $"{id},{monto}{Environment.NewLine}";
            File.AppendAllText(archivoVentas, registro);

            txtID.Clear();
            numMonto.Value = 0;
            MessageBox.Show("Transacción registrada.");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();
            double acumuladorTotal = 0;

            if (File.Exists(archivoVentas))
            {
                // 1. Leer todas las líneas
                string[] lineas = File.ReadAllLines(archivoVentas);

                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        // 2. Lógica avanzada: Separar los datos por la coma
                        // Partes[0] sería el ID, Partes[1] sería el Monto
                        string[] partes = linea.Split(',');

                        if (partes.Length >= 2)
                        {
                            // Agregar al ListBox para visualización
                            lstHistorial.Items.Add($"ID: {partes[0]} - Monto: ${partes[1]}");

                            // 3. Convertir el texto a número para la sumatoria
                            // Usamos double.Parse o Convert.ToDouble
                            double montoExtraido = double.Parse(partes[1]);
                            acumuladorTotal += montoExtraido;
                        }
                    }
                }

                // 4. Mostrar el resultado en el Label del total
                lblTotal.Text = $"TOTAL: ${acumuladorTotal:F2}";
            }
            else
            {
                MessageBox.Show("No hay registros de ventas.");
            }
        }
    }
}
