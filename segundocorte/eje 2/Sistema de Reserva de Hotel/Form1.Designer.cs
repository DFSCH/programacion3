namespace Sistema_de_Reserva_de_Hotel
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
            txtCliente = new TextBox();
            dtpEntrada = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpSalida = new DateTimePicker();
            label4 = new Label();
            numPersonas = new NumericUpDown();
            clbServicios = new CheckedListBox();
            label5 = new Label();
            rtbResumen = new RichTextBox();
            label6 = new Label();
            btnCalcularReserva = new Button();
            Limpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(24, 41);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(223, 27);
            txtCliente.TabIndex = 1;
            // 
            // dtpEntrada
            // 
            dtpEntrada.Location = new Point(24, 122);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(250, 27);
            dtpEntrada.TabIndex = 2;
            dtpEntrada.Value = new DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 93);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 100);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "salida";
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(338, 123);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(273, 27);
            dtpSalida.TabIndex = 5;
            dtpSalida.Value = new DateTime(2026, 4, 9, 23, 32, 50, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 166);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 6;
            label4.Text = "Numero de Personas";
            // 
            // numPersonas
            // 
            numPersonas.Location = new Point(31, 189);
            numPersonas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPersonas.Name = "numPersonas";
            numPersonas.Size = new Size(150, 27);
            numPersonas.TabIndex = 7;
            numPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // clbServicios
            // 
            clbServicios.FormattingEnabled = true;
            clbServicios.Items.AddRange(new object[] { "WiFi Premium", "Desayuno Buffet", "Estacionamiento", "Spa" });
            clbServicios.Location = new Point(48, 248);
            clbServicios.Name = "clbServicios";
            clbServicios.Size = new Size(150, 114);
            clbServicios.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 224);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 9;
            label5.Text = "Servicios adicionales";
            // 
            // rtbResumen
            // 
            rtbResumen.Location = new Point(265, 242);
            rtbResumen.Name = "rtbResumen";
            rtbResumen.ReadOnly = true;
            rtbResumen.Size = new Size(323, 120);
            rtbResumen.TabIndex = 10;
            rtbResumen.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 207);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 11;
            label6.Text = "Resumen de Operacion";
            // 
            // btnCalcularReserva
            // 
            btnCalcularReserva.Location = new Point(59, 393);
            btnCalcularReserva.Name = "btnCalcularReserva";
            btnCalcularReserva.Size = new Size(156, 29);
            btnCalcularReserva.TabIndex = 12;
            btnCalcularReserva.Text = "CALCULAR RESERVA";
            btnCalcularReserva.UseVisualStyleBackColor = true;
            btnCalcularReserva.Click += btnCalcularReserva_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(362, 393);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(94, 29);
            Limpiar.TabIndex = 13;
            Limpiar.Text = "LIMPIAR";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 450);
            Controls.Add(Limpiar);
            Controls.Add(btnCalcularReserva);
            Controls.Add(label6);
            Controls.Add(rtbResumen);
            Controls.Add(label5);
            Controls.Add(clbServicios);
            Controls.Add(numPersonas);
            Controls.Add(label4);
            Controls.Add(dtpSalida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEntrada);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private DateTimePicker dtpEntrada;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpSalida;
        private Label label4;
        private NumericUpDown numPersonas;
        private CheckedListBox clbServicios;
        private Label label5;
        private RichTextBox rtbResumen;
        private Label label6;
        private Button btnCalcularReserva;
        private Button Limpiar;
        private ErrorProvider errorProvider1;
    }
}
