namespace Calculadora
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(48, 70);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(186, 47);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(48, 193);
            button1.Name = "button1";
            button1.Size = new Size(42, 29);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += botonNumero_Click;
            // 
            // button2
            // 
            button2.Location = new Point(96, 193);
            button2.Name = "button2";
            button2.Size = new Size(42, 29);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += botonNumero_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 193);
            button3.Name = "button3";
            button3.Size = new Size(42, 29);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += botonNumero_Click;
            // 
            // button4
            // 
            button4.Location = new Point(48, 158);
            button4.Name = "button4";
            button4.Size = new Size(42, 29);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += botonNumero_Click;
            // 
            // button5
            // 
            button5.Location = new Point(96, 158);
            button5.Name = "button5";
            button5.Size = new Size(42, 29);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += botonNumero_Click;
            // 
            // button6
            // 
            button6.Location = new Point(144, 158);
            button6.Name = "button6";
            button6.Size = new Size(42, 29);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += botonNumero_Click;
            // 
            // button7
            // 
            button7.Location = new Point(48, 123);
            button7.Name = "button7";
            button7.Size = new Size(42, 29);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += botonNumero_Click;
            // 
            // button8
            // 
            button8.Location = new Point(96, 123);
            button8.Name = "button8";
            button8.Size = new Size(42, 29);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += botonNumero_Click;
            // 
            // button9
            // 
            button9.Location = new Point(144, 123);
            button9.Name = "button9";
            button9.Size = new Size(42, 29);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += botonNumero_Click;
            // 
            // button10
            // 
            button10.Location = new Point(48, 228);
            button10.Name = "button10";
            button10.Size = new Size(42, 29);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += botonNumero_Click;
            // 
            // button11
            // 
            button11.Location = new Point(96, 228);
            button11.Name = "button11";
            button11.Size = new Size(42, 29);
            button11.TabIndex = 11;
            button11.Text = "c";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Coral;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(144, 228);
            button12.Name = "button12";
            button12.Size = new Size(42, 29);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Coral;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(192, 158);
            button13.Name = "button13";
            button13.Size = new Size(42, 29);
            button13.TabIndex = 13;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = false;
            button13.Click += botonOperador_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Coral;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(192, 123);
            button14.Name = "button14";
            button14.Size = new Size(42, 29);
            button14.TabIndex = 13;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.Click += botonOperador_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Coral;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(192, 193);
            button15.Name = "button15";
            button15.Size = new Size(42, 29);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.TextAlign = ContentAlignment.TopCenter;
            button15.UseVisualStyleBackColor = false;
            button15.Click += botonOperador_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Coral;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(192, 228);
            button16.Name = "button16";
            button16.Size = new Size(42, 29);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += botonOperador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 326);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Click += botonNumero_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}
