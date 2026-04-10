namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.Visible = true;
                label1.Text= "el campo de correo es obligatorio";

            }
            else
            { 
                label3.Visible = false;
            }
            if (textBox1.Text != "" && !texbox1.Text.Contains("@"))
            {
                label3.Visible = true;
                label1.Text = "el correo debe de tener @ ";
            }
             else if (textbox1.Text != "" && textbox1.Text.Contains("@"))
            {
                label3.Visible = false;
            }
        }
    }
}
