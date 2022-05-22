namespace CalculadoraPrestamo
{
    partial class CalculadoraPrestamo
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudNoCuotas = new System.Windows.Forms.NumericUpDown();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListCapRestante = new System.Windows.Forms.ListBox();
            this.ListCaCuota = new System.Windows.Forms.ListBox();
            this.ListMontoCuota = new System.Windows.Forms.ListBox();
            this.ListInteresCuota = new System.Windows.Forms.ListBox();
            this.ListCapitalCuota = new System.Windows.Forms.ListBox();
            this.ListNoCuotas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoCuotas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackgroundImage = global::CalculadoraPrestamo.Properties.Resources.loanIMG;
            this.cmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCalcular.Location = new System.Drawing.Point(306, 25);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(98, 74);
            this.cmdCalcular.TabIndex = 0;
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa interes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. Cuotas:";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.nudNoCuotas);
            this.panel1.Controls.Add(this.txtTasaInteres);
            this.panel1.Controls.Add(this.txtMontoPrestamo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmdCalcular);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 176);
            this.panel1.TabIndex = 4;
            // 
            // nudNoCuotas
            // 
            this.nudNoCuotas.Location = new System.Drawing.Point(121, 89);
            this.nudNoCuotas.Name = "nudNoCuotas";
            this.nudNoCuotas.Size = new System.Drawing.Size(120, 23);
            this.nudNoCuotas.TabIndex = 6;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(121, 47);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(120, 23);
            this.txtTasaInteres.TabIndex = 5;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(121, 13);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(120, 23);
            this.txtMontoPrestamo.TabIndex = 4;
            this.txtMontoPrestamo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ListCapRestante);
            this.panel2.Controls.Add(this.ListCaCuota);
            this.panel2.Controls.Add(this.ListMontoCuota);
            this.panel2.Controls.Add(this.ListInteresCuota);
            this.panel2.Controls.Add(this.ListCapitalCuota);
            this.panel2.Controls.Add(this.ListNoCuotas);
            this.panel2.Location = new System.Drawing.Point(21, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 217);
            this.panel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capital Restante";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Capital Cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto Cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interes Couta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capital Cuota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Cuotas";
            // 
            // ListCapRestante
            // 
            this.ListCapRestante.FormattingEnabled = true;
            this.ListCapRestante.ItemHeight = 15;
            this.ListCapRestante.Location = new System.Drawing.Point(655, 35);
            this.ListCapRestante.Name = "ListCapRestante";
            this.ListCapRestante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListCapRestante.Size = new System.Drawing.Size(109, 169);
            this.ListCapRestante.TabIndex = 5;
            // 
            // ListCaCuota
            // 
            this.ListCaCuota.FormattingEnabled = true;
            this.ListCaCuota.ItemHeight = 15;
            this.ListCaCuota.Location = new System.Drawing.Point(523, 35);
            this.ListCaCuota.Name = "ListCaCuota";
            this.ListCaCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListCaCuota.Size = new System.Drawing.Size(109, 169);
            this.ListCaCuota.TabIndex = 4;
            // 
            // ListMontoCuota
            // 
            this.ListMontoCuota.FormattingEnabled = true;
            this.ListMontoCuota.ItemHeight = 15;
            this.ListMontoCuota.Location = new System.Drawing.Point(390, 35);
            this.ListMontoCuota.Name = "ListMontoCuota";
            this.ListMontoCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListMontoCuota.Size = new System.Drawing.Size(109, 169);
            this.ListMontoCuota.TabIndex = 3;
            this.ListMontoCuota.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // ListInteresCuota
            // 
            this.ListInteresCuota.FormattingEnabled = true;
            this.ListInteresCuota.ItemHeight = 15;
            this.ListInteresCuota.Location = new System.Drawing.Point(265, 35);
            this.ListInteresCuota.Name = "ListInteresCuota";
            this.ListInteresCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListInteresCuota.Size = new System.Drawing.Size(109, 169);
            this.ListInteresCuota.TabIndex = 2;
            // 
            // ListCapitalCuota
            // 
            this.ListCapitalCuota.FormattingEnabled = true;
            this.ListCapitalCuota.ItemHeight = 15;
            this.ListCapitalCuota.Location = new System.Drawing.Point(132, 35);
            this.ListCapitalCuota.Name = "ListCapitalCuota";
            this.ListCapitalCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListCapitalCuota.Size = new System.Drawing.Size(109, 169);
            this.ListCapitalCuota.TabIndex = 1;
            this.ListCapitalCuota.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ListNoCuotas
            // 
            this.ListNoCuotas.FormattingEnabled = true;
            this.ListNoCuotas.ItemHeight = 15;
            this.ListNoCuotas.Location = new System.Drawing.Point(3, 35);
            this.ListNoCuotas.Name = "ListNoCuotas";
            this.ListNoCuotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListNoCuotas.Size = new System.Drawing.Size(109, 169);
            this.ListNoCuotas.TabIndex = 0;
            // 
            // CalculadoraPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CalculadoraPrestamo";
            this.Text = "Calculadora Prestamo";
            this.Load += new System.EventHandler(this.CalculadoraPrestamo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoCuotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudNoCuotas;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListCapRestante;
        private System.Windows.Forms.ListBox ListCaCuota;
        private System.Windows.Forms.ListBox ListMontoCuota;
        private System.Windows.Forms.ListBox ListInteresCuota;
        private System.Windows.Forms.ListBox ListCapitalCuota;
        private System.Windows.Forms.ListBox ListNoCuotas;
    }
}
