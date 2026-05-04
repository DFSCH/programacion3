namespace Veterinaria
{
    partial class FormHistorial
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
            panel2 = new Panel();
            label4 = new Label();
            lblMascotasAtendidas = new Label();
            panel3 = new Panel();
            label5 = new Label();
            lblTotalConsultas = new Label();
            panel4 = new Panel();
            label7 = new Label();
            lblIngresosTotales = new Label();
            panel5 = new Panel();
            label9 = new Label();
            lblPromedio = new Label();
            panel6 = new Panel();
            btnVerTodo = new Button();
            btnFiltrar = new Button();
            cmbPropietarioHistorial = new ComboBox();
            cmbMascotaHistorial = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            dgvHistorialCompleto = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dgvResumenMascotas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            SConsulta = new ToolStripStatusLabel();
            STotal = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCompleto).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenMascotas).BeginInit();
            statusStrip1.SuspendLayout();
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
            panel1.Size = new Size(1083, 125);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(492, 20);
            label2.TabIndex = 5;
            label2.Text = "REGISTO MEDICO COMPLETO POR MASCOTA E INGRESOS DEL PERIODO ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._004_portapapeles;
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
            label1.Size = new Size(160, 38);
            label1.TabIndex = 4;
            label1.Text = "HISTORIAL";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblMascotasAtendidas);
            panel2.Location = new Point(14, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 78);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 1;
            label4.Text = "MASCOTAS ATENDIDAS";
            // 
            // lblMascotasAtendidas
            // 
            lblMascotasAtendidas.AutoSize = true;
            lblMascotasAtendidas.BackColor = SystemColors.Control;
            lblMascotasAtendidas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMascotasAtendidas.ForeColor = Color.CornflowerBlue;
            lblMascotasAtendidas.Location = new Point(94, 30);
            lblMascotasAtendidas.Name = "lblMascotasAtendidas";
            lblMascotasAtendidas.Size = new Size(24, 28);
            lblMascotasAtendidas.TabIndex = 0;
            lblMascotasAtendidas.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblTotalConsultas);
            panel3.Location = new Point(284, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 78);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 3;
            label5.Text = "CONSULTAS TOTALES";
            // 
            // lblTotalConsultas
            // 
            lblTotalConsultas.AutoSize = true;
            lblTotalConsultas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalConsultas.ForeColor = Color.CornflowerBlue;
            lblTotalConsultas.Location = new Point(103, 30);
            lblTotalConsultas.Name = "lblTotalConsultas";
            lblTotalConsultas.Size = new Size(24, 28);
            lblTotalConsultas.TabIndex = 2;
            lblTotalConsultas.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblIngresosTotales);
            panel4.Location = new Point(553, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 78);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 5;
            label7.Text = "INGRESOS TOTALES";
            // 
            // lblIngresosTotales
            // 
            lblIngresosTotales.AutoSize = true;
            lblIngresosTotales.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIngresosTotales.ForeColor = Color.Coral;
            lblIngresosTotales.Location = new Point(98, 30);
            lblIngresosTotales.Name = "lblIngresosTotales";
            lblIngresosTotales.Size = new Size(24, 28);
            lblIngresosTotales.TabIndex = 4;
            lblIngresosTotales.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(lblPromedio);
            panel5.Location = new Point(819, 131);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 78);
            label9.Name = "label9";
            label9.Size = new Size(192, 20);
            label9.TabIndex = 7;
            label9.Text = "PROMEDIO POR CONSULTA";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPromedio.ForeColor = Color.DarkMagenta;
            lblPromedio.Location = new Point(112, 30);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(24, 28);
            lblPromedio.TabIndex = 6;
            lblPromedio.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(btnVerTodo);
            panel6.Controls.Add(btnFiltrar);
            panel6.Controls.Add(cmbPropietarioHistorial);
            panel6.Controls.Add(cmbMascotaHistorial);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(14, 271);
            panel6.Name = "panel6";
            panel6.Size = new Size(1055, 59);
            panel6.TabIndex = 6;
            // 
            // btnVerTodo
            // 
            btnVerTodo.ForeColor = Color.CornflowerBlue;
            btnVerTodo.Location = new Point(695, 22);
            btnVerTodo.Name = "btnVerTodo";
            btnVerTodo.Size = new Size(116, 29);
            btnVerTodo.TabIndex = 13;
            btnVerTodo.Text = "👁️VER TODO";
            btnVerTodo.UseVisualStyleBackColor = true;
            btnVerTodo.Click += btnVerTodo_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(571, 22);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.Text = "🔍FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cmbPropietarioHistorial
            // 
            cmbPropietarioHistorial.FormattingEnabled = true;
            cmbPropietarioHistorial.Location = new Point(283, 23);
            cmbPropietarioHistorial.Name = "cmbPropietarioHistorial";
            cmbPropietarioHistorial.Size = new Size(237, 28);
            cmbPropietarioHistorial.TabIndex = 11;
            // 
            // cmbMascotaHistorial
            // 
            cmbMascotaHistorial.FormattingEnabled = true;
            cmbMascotaHistorial.Location = new Point(13, 23);
            cmbMascotaHistorial.Name = "cmbMascotaHistorial";
            cmbMascotaHistorial.Size = new Size(237, 28);
            cmbMascotaHistorial.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(270, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 9;
            label12.Text = "PROPIETARIO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 8;
            label11.Text = "MASCOTA:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHistorialCompleto);
            groupBox1.Location = new Point(17, 347);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1052, 161);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial de Consultas";
            // 
            // dgvHistorialCompleto
            // 
            dgvHistorialCompleto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCompleto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCompleto.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvHistorialCompleto.Location = new Point(10, 26);
            dgvHistorialCompleto.Name = "dgvHistorialCompleto";
            dgvHistorialCompleto.ReadOnly = true;
            dgvHistorialCompleto.RowHeadersVisible = false;
            dgvHistorialCompleto.RowHeadersWidth = 51;
            dgvHistorialCompleto.Size = new Size(1036, 188);
            dgvHistorialCompleto.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "FECHA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "MASCOTA";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "PROPIETARIO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "MOTIVO";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "DIAGNOSTICO";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "COSTO";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvResumenMascotas);
            groupBox2.Location = new Point(27, 528);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1052, 161);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen por Mascota";
            // 
            // dgvResumenMascotas
            // 
            dgvResumenMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumenMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenMascotas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column8, Column9, Column10, Column11, Column12 });
            dgvResumenMascotas.Location = new Point(10, 26);
            dgvResumenMascotas.Name = "dgvResumenMascotas";
            dgvResumenMascotas.ReadOnly = true;
            dgvResumenMascotas.RowHeadersVisible = false;
            dgvResumenMascotas.RowHeadersWidth = 51;
            dgvResumenMascotas.Size = new Size(1036, 188);
            dgvResumenMascotas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "NOMBRE";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "ESPECIE";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "PROPIETARIO";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "CONSULTAS";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "TOTAL FACTURADO";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SConsulta, STotal });
            statusStrip1.Location = new Point(0, 754);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1081, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // SConsulta
            // 
            SConsulta.Name = "SConsulta";
            SConsulta.Size = new Size(64, 20);
            SConsulta.Text = "consulta";
            // 
            // STotal
            // 
            STotal.Name = "STotal";
            STotal.Size = new Size(42, 20);
            STotal.Text = "Total";
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1081, 780);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCompleto).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResumenMascotas).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label lblMascotasAtendidas;
        private Label label5;
        private Label lblTotalConsultas;
        private Label label7;
        private Label lblIngresosTotales;
        private Label label9;
        private Label lblPromedio;
        private Panel panel6;
        private Button btnVerTodo;
        private Button btnFiltrar;
        private ComboBox cmbPropietarioHistorial;
        private ComboBox cmbMascotaHistorial;
        private Label label12;
        private Label label11;
        private GroupBox groupBox1;
        private DataGridView dgvHistorialCompleto;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private GroupBox groupBox2;
        private DataGridView dgvResumenMascotas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel SConsulta;
        private ToolStripStatusLabel STotal;
    }
}