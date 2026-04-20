namespace Control_de_Ventas_Diarias
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
            btnGuardar = new Button();
            label2 = new Label();
            numMonto = new NumericUpDown();
            txtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            btnCargar = new Button();
            lstHistorial = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numMonto);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Venta";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(22, 90);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Transaccion";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Monton ($)";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(217, 47);
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(150, 27);
            numMonto.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(22, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "ID transaccion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnCargar);
            groupBox2.Controls.Add(lstHistorial);
            groupBox2.Location = new Point(50, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.CornflowerBlue;
            lblTotal.Location = new Point(249, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "TOTAL : $ 0.00";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(14, 168);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(20, 36);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(329, 104);
            lstHistorial.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numMonto;
        private TextBox txtID;
        private Label label1;
        private Button btnGuardar;
        private GroupBox groupBox2;
        private Label lblTotal;
        private Button btnCargar;
        private ListBox lstHistorial;
    }
}
