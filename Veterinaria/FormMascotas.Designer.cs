namespace Veterinaria
{
    partial class FormMascotas
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
            lblEstadoMascotas = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            Registro = new GroupBox();
            lblEdadCalculada = new Label();
            dtpFechaNac = new DateTimePicker();
            cmbPropietario = new ComboBox();
            cmbEspecie = new ComboBox();
            label8 = new Label();
            btnRegistrar = new Button();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvMascotas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            Registro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
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
            panel1.Size = new Size(1103, 125);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(260, 20);
            label2.TabIndex = 5;
            label2.Text = "REGISTO DE PACIENTE DE LA CLINICA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._006_veterinario_1;
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
            label1.Size = new Size(166, 38);
            label1.TabIndex = 4;
            label1.Text = "MASCOTAS";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblEstadoMascotas });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1113, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 20);
            toolStripStatusLabel1.Text = "✔️LISTO";
            // 
            // lblEstadoMascotas
            // 
            lblEstadoMascotas.Name = "lblEstadoMascotas";
            lblEstadoMascotas.Size = new Size(17, 20);
            lblEstadoMascotas.Text = "0";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 122);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Registro);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1101, 378);
            splitContainer1.SplitterDistance = 333;
            splitContainer1.TabIndex = 4;
            // 
            // Registro
            // 
            Registro.BackColor = SystemColors.Control;
            Registro.Controls.Add(lblEdadCalculada);
            Registro.Controls.Add(dtpFechaNac);
            Registro.Controls.Add(cmbPropietario);
            Registro.Controls.Add(cmbEspecie);
            Registro.Controls.Add(label8);
            Registro.Controls.Add(btnRegistrar);
            Registro.Controls.Add(txtRaza);
            Registro.Controls.Add(txtNombre);
            Registro.Controls.Add(txtID);
            Registro.Controls.Add(label7);
            Registro.Controls.Add(label6);
            Registro.Controls.Add(label5);
            Registro.Controls.Add(label4);
            Registro.Controls.Add(label3);
            Registro.Location = new Point(3, 9);
            Registro.Name = "Registro";
            Registro.Size = new Size(324, 352);
            Registro.TabIndex = 3;
            Registro.TabStop = false;
            Registro.Text = "Registrar Mascota";
            // 
            // lblEdadCalculada
            // 
            lblEdadCalculada.AutoSize = true;
            lblEdadCalculada.BackColor = Color.LightBlue;
            lblEdadCalculada.Location = new Point(22, 273);
            lblEdadCalculada.Name = "lblEdadCalculada";
            lblEdadCalculada.Size = new Size(39, 20);
            lblEdadCalculada.TabIndex = 16;
            lblEdadCalculada.Text = "nota";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(137, 168);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(166, 27);
            dtpFechaNac.TabIndex = 7;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // cmbPropietario
            // 
            cmbPropietario.FormattingEnabled = true;
            cmbPropietario.Location = new Point(137, 201);
            cmbPropietario.Name = "cmbPropietario";
            cmbPropietario.Size = new Size(166, 28);
            cmbPropietario.TabIndex = 15;
            // 
            // cmbEspecie
            // 
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "🐶PERRO", "🐈‍⬛GATO", "🐦AVE", "OTRO..." });
            cmbEspecie.Location = new Point(137, 101);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(166, 28);
            cmbEspecie.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 104);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 12;
            label8.Text = "ESPECIE:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(22, 306);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(259, 29);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "🐾REGISTRAR MASCOTA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(137, 135);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(166, 27);
            txtRaza.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(137, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 27);
            txtID.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 204);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 4;
            label7.Text = "PROPIETARIO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 171);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 3;
            label6.Text = "F. NACIMIENTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 138);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 2;
            label5.Text = "RAZA: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 68);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(dgvMascotas);
            groupBox1.Location = new Point(3, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mascotas Registradas";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(23, 286);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(167, 286);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "🔍Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(449, 284);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 29);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "🔄️Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(595, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "❌Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMascotas
            // 
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5, Column6 });
            dgvMascotas.EnableHeadersVisualStyles = false;
            dgvMascotas.Location = new Point(6, 26);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.ReadOnly = true;
            dgvMascotas.RowHeadersVisible = false;
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.Size = new Size(638, 198);
            dgvMascotas.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "NOMBRE";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "ESPECIE";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "RAZA";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "EDAD";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "PROPIETARIO";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // FormMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1113, 525);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Name = "FormMascotas";
            Text = "FormMascotas";
            Load += FormMascotas_Load;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
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
        private ComboBox cmbEspecie;
        private Label label8;
        private Button btnRegistrar;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgvMascotas;
        private Button btnActualizar;
        private Button btnEliminar;
        private ComboBox cmbPropietario;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblEstadoMascotas;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DateTimePicker dtpFechaNac;
        private Label lblEdadCalculada;
    }
}