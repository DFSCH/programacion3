namespace Catálogo_de_Producto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnañadir = new Button();
            numCantidad = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnañadir);
            panel1.Controls.Add(numCantidad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(21, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 355);
            panel1.TabIndex = 0;
            // 
            // btnañadir
            // 
            btnañadir.BackColor = Color.MediumSeaGreen;
            btnañadir.Cursor = Cursors.Hand;
            btnañadir.FlatStyle = FlatStyle.Flat;
            btnañadir.ForeColor = SystemColors.ControlLightLight;
            btnañadir.Location = new Point(31, 228);
            btnañadir.Name = "btnañadir";
            btnañadir.Size = new Size(149, 33);
            btnañadir.TabIndex = 5;
            btnañadir.Text = "Añadir al carrito";
            btnañadir.UseVisualStyleBackColor = false;
            btnañadir.Click += btnañadir_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(31, 167);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 27);
            numCantidad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(31, 126);
            label2.Name = "label2";
            label2.Size = new Size(121, 38);
            label2.TabIndex = 3;
            label2.Text = "$299.99";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 1;
            label1.Text = "Monitor Gamer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(212, 54);
            textBox1.TabIndex = 2;
            textBox1.Text = "Monitor con tasa de refresco\r\nde 144Hz y panel IPS...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnañadir;
        private NumericUpDown numCantidad;
        private Label label2;
    }
}
