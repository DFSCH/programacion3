namespace Veterinaria
{
    partial class FormConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblConsultasHoy = new ToolStripStatusLabel();
            lblIngresosFooter = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            Registro = new GroupBox();
            label9 = new Label();
            numCosto = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cmbMascota = new ComboBox();
            label8 = new Label();
            btnRegistrarConsulta = new Button();
            txtDiagnostico = new TextBox();
            txtMotivo = new TextBox();
            txtPropietario = new TextBox();
            txtFecha = new TextBox();
            txtIDConsulta = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            lblTotalHoy = new Label();
            btnActualizar = new Button();
            dgvConsultas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 125);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(261, 20);
            label2.TabIndex = 5;
            label2.Text = "ATENCION MEDICA A LAS MASCOTAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._003_veterinario;
            pictureBox1.Location = new Point(13, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 4;
            label1.Text = "CONSULTA";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblConsultasHoy, lblIngresosFooter });
            statusStrip1.Location = new Point(0, 543);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1097, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 20);
            toolStripStatusLabel1.Text = "✔️LISTO";
            // 
            // lblConsultasHoy
            // 
            lblConsultasHoy.Name = "lblConsultasHoy";
            lblConsultasHoy.Size = new Size(17, 20);
            lblConsultasHoy.Text = "0";
            // 
            // lblIngresosFooter
            // 
            lblIngresosFooter.Name = "lblIngresosFooter";
            lblIngresosFooter.Size = new Size(17, 20);
            lblIngresosFooter.Text = "0";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 120);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Registro);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1096, 424);
            splitContainer1.SplitterDistance = 365;
            splitContainer1.TabIndex = 4;
            // 
            // Registro
            // 
            Registro.Controls.Add(label9);
            Registro.Controls.Add(numCosto);
            Registro.Controls.Add(label6);
            Registro.Controls.Add(label5);
            Registro.Controls.Add(cmbMascota);
            Registro.Controls.Add(label8);
            Registro.Controls.Add(btnRegistrarConsulta);
            Registro.Controls.Add(txtDiagnostico);
            Registro.Controls.Add(txtMotivo);
            Registro.Controls.Add(txtPropietario);
            Registro.Controls.Add(txtFecha);
            Registro.Controls.Add(txtIDConsulta);
            Registro.Controls.Add(label7);
            Registro.Controls.Add(label4);
            Registro.Controls.Add(label3);
            Registro.Location = new Point(25, 11);
            Registro.Name = "Registro";
            Registro.Size = new Size(324, 397);
            Registro.TabIndex = 4;
            Registro.TabStop = false;
            Registro.Text = "Nueva Consulta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 299);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 17;
            label9.Text = "COSTO ($):";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(153, 297);
            numCosto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(150, 27);
            numCosto.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 207);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 15;
            label6.Text = "DIAGNOSTICO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 171);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "MOTIVO:";
            // 
            // cmbMascota
            // 
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Items.AddRange(new object[] { "🐶PERRO", "🐈‍⬛GATO", "🐦AVE" });
            cmbMascota.Location = new Point(137, 101);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(166, 28);
            cmbMascota.TabIndex = 13;
            cmbMascota.SelectedIndexChanged += cmbMascota_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 109);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 12;
            label8.Text = "MASCOTA:";
            // 
            // btnRegistrarConsulta
            // 
            btnRegistrarConsulta.Location = new Point(22, 349);
            btnRegistrarConsulta.Name = "btnRegistrarConsulta";
            btnRegistrarConsulta.Size = new Size(259, 29);
            btnRegistrarConsulta.TabIndex = 10;
            btnRegistrarConsulta.Text = "💉REGISTRAR CONSULTA";
            btnRegistrarConsulta.UseVisualStyleBackColor = true;
            btnRegistrarConsulta.Click += btnRegistrarConsulta_Click;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(22, 230);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(267, 57);
            txtDiagnostico.TabIndex = 9;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(137, 168);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(166, 27);
            txtMotivo.TabIndex = 8;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(137, 135);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.ReadOnly = true;
            txtPropietario.Size = new Size(166, 27);
            txtPropietario.TabIndex = 7;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(137, 68);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(166, 27);
            txtFecha.TabIndex = 6;
            // 
            // txtIDConsulta
            // 
            txtIDConsulta.Location = new Point(137, 35);
            txtIDConsulta.Name = "txtIDConsulta";
            txtIDConsulta.Size = new Size(166, 27);
            txtIDConsulta.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 142);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 4;
            label7.Text = "PROPIETARIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 71);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 1;
            label4.Text = "FECHA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 35);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 0;
            label3.Text = "ID CONSULTA:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(lblTotalHoy);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(dgvConsultas);
            groupBox1.Location = new Point(3, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlDark;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.Crimson;
            btnEliminar.Location = new Point(585, 290);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "❌Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTotalHoy
            // 
            lblTotalHoy.AutoSize = true;
            lblTotalHoy.BackColor = Color.LightGreen;
            lblTotalHoy.Location = new Point(15, 230);
            lblTotalHoy.Name = "lblTotalHoy";
            lblTotalHoy.Size = new Size(72, 20);
            lblTotalHoy.TabIndex = 4;
            lblTotalHoy.Text = "Consultas";
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.DarkCyan;
            btnActualizar.Location = new Point(432, 290);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 29);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "🔄️Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvConsultas
            // 
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4 });
            dgvConsultas.EnableHeadersVisualStyles = false;
            dgvConsultas.Location = new Point(6, 26);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.ReadOnly = true;
            dgvConsultas.RowHeadersVisible = false;
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(573, 136);
            dgvConsultas.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "MASCOTA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "PROPIETARIO";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "MOTIVO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "COSTO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1097, 569);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Name = "FormConsultas";
            Text = "FormConsultas";
            Load += FormConsultas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            Registro.ResumeLayout(false);
            Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private GroupBox Registro;
        private ComboBox cmbMascota;
        private Label label8;
        private Button btnRegistrarConsulta;
        private TextBox txtMotivo;
        private TextBox txtPropietario;
        private TextBox txtFecha;
        private TextBox txtIDConsulta;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtDiagnostico;
        private Label label9;
        private NumericUpDown numCosto;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private DataGridView dgvConsultas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ToolStripStatusLabel lblIngresosFooter;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblConsultasHoy;
        private Label lblTotalHoy;
        private Button btnEliminar;
    }
}