namespace Veterinaria
{
    partial class FormPropietarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            Registro = new GroupBox();
            txtTelefono = new MaskedTextBox();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dgvPropietarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Mascotas = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblContador = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            Registro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 5;
            label2.Text = "REGISTRO DE DUEÑOS DE MASCOTAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._007_veterinario_2;
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
            label1.Size = new Size(179, 38);
            label1.TabIndex = 4;
            label1.Text = "Propietarios";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-1, 119);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(Registro);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1057, 401);
            splitContainer1.SplitterDistance = 351;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Location = new Point(18, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(205, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "🔍";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(16, 40);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 27);
            txtBuscar.TabIndex = 0;
            // 
            // Registro
            // 
            Registro.Controls.Add(txtTelefono);
            Registro.Controls.Add(btnLimpiar);
            Registro.Controls.Add(btnRegistrar);
            Registro.Controls.Add(txtDireccion);
            Registro.Controls.Add(txtCorreo);
            Registro.Controls.Add(txtNombre);
            Registro.Controls.Add(txtID);
            Registro.Controls.Add(label7);
            Registro.Controls.Add(label6);
            Registro.Controls.Add(label5);
            Registro.Controls.Add(label4);
            Registro.Controls.Add(label3);
            Registro.Location = new Point(13, 12);
            Registro.Name = "Registro";
            Registro.Size = new Size(301, 278);
            Registro.TabIndex = 0;
            Registro.TabStop = false;
            Registro.Text = "Registrar Propietario";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(116, 101);
            txtTelefono.Mask = "000-00-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(166, 27);
            txtTelefono.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(22, 237);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(260, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "\U0001f9f9LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(23, 202);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(259, 29);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "💾REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(116, 167);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(166, 27);
            txtDireccion.TabIndex = 9;
            txtDireccion.Text = "calle/ carrera";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(116, 134);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(166, 27);
            txtCorreo.TabIndex = 8;
            txtCorreo.Text = "Correo@gmail.com";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 27);
            txtNombre.TabIndex = 6;
            txtNombre.Text = "nombre del usuario";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ControlDark;
            txtID.ForeColor = SystemColors.WindowText;
            txtID.Location = new Point(116, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 27);
            txtID.TabIndex = 5;
            txtID.Text = "P01";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 167);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 4;
            label7.Text = "DIRRECION:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 134);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 3;
            label6.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 101);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 2;
            label5.Text = "TELEFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 68);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPropietarios);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 353);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista De Propietario";
            // 
            // dgvPropietarios
            // 
            dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPropietarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPropietarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPropietarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Telefono, Correo, Mascotas });
            dgvPropietarios.EnableHeadersVisualStyles = false;
            dgvPropietarios.Location = new Point(6, 28);
            dgvPropietarios.Name = "dgvPropietarios";
            dgvPropietarios.ReadOnly = true;
            dgvPropietarios.RowHeadersVisible = false;
            dgvPropietarios.RowHeadersWidth = 51;
            dgvPropietarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropietarios.Size = new Size(573, 250);
            dgvPropietarios.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Mascotas
            // 
            Mascotas.HeaderText = "Mascotas";
            Mascotas.MinimumWidth = 6;
            Mascotas.Name = "Mascotas";
            Mascotas.ReadOnly = true;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGreen;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = SystemColors.Desktop;
            btnActualizar.Location = new Point(399, 305);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "🔄️Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(546, 305);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "❌Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblContador });
            statusStrip1.Location = new Point(0, 506);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1056, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(61, 20);
            toolStripStatusLabel1.Text = "✔️Listo";
            // 
            // lblContador
            // 
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(17, 20);
            lblContador.Text = "0";
            // 
            // FormPropietarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1056, 532);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "FormPropietarios";
            Text = "FormPropietarios";
            Load += FormPropietarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            Registro.ResumeLayout(false);
            Registro.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).EndInit();
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
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private GroupBox Registro;
        private Label label4;
        private Label label3;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgvPropietarios;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblContador;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Mascotas;
        private MaskedTextBox txtTelefono;
    }
}