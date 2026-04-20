namespace Registro_de_Clientes
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
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCiudad = new TextBox();
            txtDNI = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCargar = new Button();
            lstClientes = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(6, 146);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Cliente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(200, 47);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(170, 27);
            txtCiudad.TabIndex = 3;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(6, 47);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(157, 27);
            txtDNI.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "CIUDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "dns CODIGO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCargar);
            groupBox2.Controls.Add(lstClientes);
            groupBox2.Location = new Point(44, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente Registrado";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(28, 142);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(174, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Desde Archivo";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(13, 26);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(372, 104);
            lstClientes.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCiudad;
        private TextBox txtDNI;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox lstClientes;
        private Button btnCargar;
    }
}
