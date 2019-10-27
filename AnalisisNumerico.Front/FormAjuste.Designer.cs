namespace AnalisisNumerico.Front
{
    partial class FormAjuste
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.txtInter = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCoe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.lblInter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCoe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(211, 108);
            this.txtPot.Name = "txtPot";
            this.txtPot.Size = new System.Drawing.Size(134, 20);
            this.txtPot.TabIndex = 1;
            // 
            // txtInter
            // 
            this.txtInter.Location = new System.Drawing.Point(383, 108);
            this.txtInter.Name = "txtInter";
            this.txtInter.Size = new System.Drawing.Size(113, 20);
            this.txtInter.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 20);
            this.textBox4.TabIndex = 3;
            // 
            // txtCoe
            // 
            this.txtCoe.Location = new System.Drawing.Point(211, 284);
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(285, 20);
            this.txtCoe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de puntos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(208, 75);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(137, 13);
            this.lblPot.TabIndex = 6;
            this.lblPot.Text = "Potencia de la funcion (RP)";
            this.lblPot.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblInter
            // 
            this.lblInter.AutoSize = true;
            this.lblInter.Location = new System.Drawing.Point(380, 75);
            this.lblInter.Name = "lblInter";
            this.lblInter.Size = new System.Drawing.Size(116, 13);
            this.lblInter.TabIndex = 7;
            this.lblInter.Text = "Valor interpretacion (L):";
            this.lblInter.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Funcion de mejor ajuste:";
            // 
            // lblCoe
            // 
            this.lblCoe.AutoSize = true;
            this.lblCoe.Location = new System.Drawing.Point(208, 268);
            this.lblCoe.Name = "lblCoe";
            this.lblCoe.Size = new System.Drawing.Size(133, 13);
            this.lblCoe.TabIndex = 9;
            this.lblCoe.Text = "Coeficiente de correlacion:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresion Lineal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Regresion Polinomial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Lagrange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Location = new System.Drawing.Point(33, 131);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.Size = new System.Drawing.Size(151, 234);
            this.dgvPuntos.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y";
            // 
            // FormAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCoe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInter);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoe);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtInter);
            this.Controls.Add(this.txtPot);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAjuste";
            this.Text = "FormAjuste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.TextBox txtInter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label lblInter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCoe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}