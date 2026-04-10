namespace Gestión_de_Inventario_de_Productos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            numStockInicial = new NumericUpDown();
            numStockMinimo = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            gbIVA = new GroupBox();
            rbReducido = new RadioButton();
            rbGeneral = new RadioButton();
            rbExento = new RadioButton();
            chkEsPerecedero = new CheckBox();
            dtpFechaVencimiento = new DateTimePicker();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).BeginInit();
            gbIVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos Generales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Código (PROD-0000)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 41);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre del producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(37, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(288, 64);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 41);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Electrónica", "Alimentos", "Ropa" });
            cmbCategoria.Location = new Point(499, 64);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 6;
            cmbCategoria.Text = "...";
            // 
            // numStockInicial
            // 
            numStockInicial.Location = new Point(37, 146);
            numStockInicial.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStockInicial.Name = "numStockInicial";
            numStockInicial.Size = new Size(150, 27);
            numStockInicial.TabIndex = 7;
            // 
            // numStockMinimo
            // 
            numStockMinimo.Location = new Point(263, 146);
            numStockMinimo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numStockMinimo.Name = "numStockMinimo";
            numStockMinimo.Size = new Size(150, 27);
            numStockMinimo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 112);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 9;
            label5.Text = "Stock Inicial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 112);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Stock Minimo";
            // 
            // gbIVA
            // 
            gbIVA.Controls.Add(rbReducido);
            gbIVA.Controls.Add(rbGeneral);
            gbIVA.Controls.Add(rbExento);
            gbIVA.Location = new Point(41, 203);
            gbIVA.Name = "gbIVA";
            gbIVA.Size = new Size(414, 61);
            gbIVA.TabIndex = 11;
            gbIVA.TabStop = false;
            gbIVA.Text = "GBIVA";
            // 
            // rbReducido
            // 
            rbReducido.AutoSize = true;
            rbReducido.Location = new Point(274, 24);
            rbReducido.Name = "rbReducido";
            rbReducido.Size = new Size(127, 24);
            rbReducido.TabIndex = 2;
            rbReducido.TabStop = true;
            rbReducido.Text = "Reducido (5%)";
            rbReducido.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            rbGeneral.AutoSize = true;
            rbGeneral.Location = new Point(135, 24);
            rbGeneral.Name = "rbGeneral";
            rbGeneral.Size = new Size(123, 24);
            rbGeneral.TabIndex = 1;
            rbGeneral.TabStop = true;
            rbGeneral.Text = "General (19%)";
            rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbExento
            // 
            rbExento.AutoSize = true;
            rbExento.Location = new Point(8, 24);
            rbExento.Name = "rbExento";
            rbExento.Size = new Size(109, 24);
            rbExento.TabIndex = 0;
            rbExento.TabStop = true;
            rbExento.Text = "Exento (0%)";
            rbExento.UseVisualStyleBackColor = true;
            // 
            // chkEsPerecedero
            // 
            chkEsPerecedero.AutoSize = true;
            chkEsPerecedero.Location = new Point(41, 283);
            chkEsPerecedero.Name = "chkEsPerecedero";
            chkEsPerecedero.Size = new Size(111, 24);
            chkEsPerecedero.TabIndex = 12;
            chkEsPerecedero.Text = "Perecederos";
            chkEsPerecedero.UseVisualStyleBackColor = true;
            chkEsPerecedero.CheckedChanged += chkEsPerecedero_CheckedChanged;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(37, 330);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(307, 27);
            dtpFechaVencimiento.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(51, 390);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(315, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(chkEsPerecedero);
            Controls.Add(gbIVA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numStockMinimo);
            Controls.Add(numStockInicial);
            Controls.Add(cmbCategoria);
            Controls.Add(label4);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).EndInit();
            gbIVA.ResumeLayout(false);
            gbIVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private TextBox txtNombreProducto;
        private Label label4;
        private ComboBox cmbCategoria;
        private NumericUpDown numStockInicial;
        private NumericUpDown numStockMinimo;
        private Label label5;
        private Label label6;
        private GroupBox gbIVA;
        private RadioButton rbReducido;
        private RadioButton rbGeneral;
        private RadioButton rbExento;
        private CheckBox chkEsPerecedero;
        private DateTimePicker dtpFechaVencimiento;
        private Button btnGuardar;
        private Button btnLimpiar;
        private ErrorProvider errorProvider1;
    }
}
