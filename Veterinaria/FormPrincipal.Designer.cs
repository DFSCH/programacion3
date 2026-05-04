namespace Veterinaria
{
    partial class FormPrincipal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnHistorial = new Button();
            btnConsulta = new Button();
            btnMascota = new Button();
            btnPropietario = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnHistorial, 3, 0);
            tableLayoutPanel1.Controls.Add(btnConsulta, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMascota, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPropietario, 0, 0);
            tableLayoutPanel1.Location = new Point(62, 246);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(542, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnHistorial
            // 
            btnHistorial.Dock = DockStyle.Fill;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Image = Properties.Resources._004_portapapeles;
            btnHistorial.Location = new Point(408, 3);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(131, 119);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.BottomCenter;
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Dock = DockStyle.Fill;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Image = Properties.Resources._003_veterinario;
            btnConsulta.Location = new Point(273, 3);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(129, 119);
            btnConsulta.TabIndex = 2;
            btnConsulta.Text = "Consulta";
            btnConsulta.TextAlign = ContentAlignment.BottomCenter;
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnMascota
            // 
            btnMascota.Dock = DockStyle.Fill;
            btnMascota.FlatStyle = FlatStyle.Flat;
            btnMascota.Image = Properties.Resources._006_veterinario_1;
            btnMascota.Location = new Point(138, 3);
            btnMascota.Name = "btnMascota";
            btnMascota.Size = new Size(129, 119);
            btnMascota.TabIndex = 1;
            btnMascota.Text = "Mascota";
            btnMascota.TextAlign = ContentAlignment.BottomCenter;
            btnMascota.UseVisualStyleBackColor = true;
            btnMascota.Click += btnMascota_Click;
            // 
            // btnPropietario
            // 
            btnPropietario.Dock = DockStyle.Fill;
            btnPropietario.FlatAppearance.BorderColor = Color.Black;
            btnPropietario.FlatStyle = FlatStyle.Flat;
            btnPropietario.Image = Properties.Resources._007_veterinario_2;
            btnPropietario.Location = new Point(3, 3);
            btnPropietario.Name = "btnPropietario";
            btnPropietario.Size = new Size(129, 119);
            btnPropietario.TabIndex = 0;
            btnPropietario.Text = "Propietario";
            btnPropietario.TextAlign = ContentAlignment.BottomCenter;
            btnPropietario.UseVisualStyleBackColor = true;
            btnPropietario.Click += btnPropietario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 125);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 52);
            label2.Name = "label2";
            label2.Size = new Size(307, 20);
            label2.TabIndex = 2;
            label2.Text = "SISTEMA DE GESTION CLINICA VETERINARIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 10);
            label1.Name = "label1";
            label1.Size = new Size(337, 38);
            label1.TabIndex = 1;
            label1.Text = "VETERINARIA SANTA FE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._002_la_tienda_de_animales;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(817, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 20);
            toolStripStatusLabel1.Text = "✔️LISTO";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(817, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "FormPrincipal";
            Text = "Veterinaria -Principal";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnHistorial;
        private Button btnConsulta;
        private Button btnMascota;
        private Button btnPropietario;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
