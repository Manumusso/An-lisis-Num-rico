namespace AnalisisNumerico.Front
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Error = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.textBox_IteracionesR = new System.Windows.Forms.TextBox();
            this.label_IteracionesR = new System.Windows.Forms.Label();
            this.textBox_Raiz = new System.Windows.Forms.TextBox();
            this.label_Raiz = new System.Windows.Forms.Label();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.textBox_ValorDerecho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ValorIzquierdo = new System.Windows.Forms.TextBox();
            this.label_ValorIzquierdo = new System.Windows.Forms.Label();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.label_Tolerancia = new System.Windows.Forms.Label();
            this.textBox_Iteraciones = new System.Windows.Forms.TextBox();
            this.label_Iteraciones = new System.Windows.Forms.Label();
            this.label_Funcion = new System.Windows.Forms.Label();
            this.label_TitDatosEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Error
            // 
            this.textBox_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Error.Location = new System.Drawing.Point(489, 538);
            this.textBox_Error.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Error.Name = "textBox_Error";
            this.textBox_Error.Size = new System.Drawing.Size(183, 34);
            this.textBox_Error.TabIndex = 37;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.Location = new System.Drawing.Point(409, 538);
            this.label_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(72, 29);
            this.label_Error.TabIndex = 36;
            this.label_Error.Text = "Error";
            // 
            // textBox_IteracionesR
            // 
            this.textBox_IteracionesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IteracionesR.Location = new System.Drawing.Point(218, 535);
            this.textBox_IteracionesR.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IteracionesR.Name = "textBox_IteracionesR";
            this.textBox_IteracionesR.Size = new System.Drawing.Size(183, 34);
            this.textBox_IteracionesR.TabIndex = 35;
            // 
            // label_IteracionesR
            // 
            this.label_IteracionesR.AutoSize = true;
            this.label_IteracionesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IteracionesR.Location = new System.Drawing.Point(68, 538);
            this.label_IteracionesR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IteracionesR.Name = "label_IteracionesR";
            this.label_IteracionesR.Size = new System.Drawing.Size(142, 29);
            this.label_IteracionesR.TabIndex = 34;
            this.label_IteracionesR.Text = "Iteraciones";
            // 
            // textBox_Raiz
            // 
            this.textBox_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Raiz.Location = new System.Drawing.Point(329, 580);
            this.textBox_Raiz.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Raiz.Name = "textBox_Raiz";
            this.textBox_Raiz.Size = new System.Drawing.Size(183, 34);
            this.textBox_Raiz.TabIndex = 33;
            this.textBox_Raiz.TextChanged += new System.EventHandler(this.textBox_Raiz_TextChanged);
            // 
            // label_Raiz
            // 
            this.label_Raiz.AutoSize = true;
            this.label_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Raiz.Location = new System.Drawing.Point(237, 580);
            this.label_Raiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Raiz.Name = "label_Raiz";
            this.label_Raiz.Size = new System.Drawing.Size(64, 29);
            this.label_Raiz.TabIndex = 32;
            this.label_Raiz.Text = "Raíz";
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(18, 416);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(4);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(727, 74);
            this.button_Calcular.TabIndex = 5;
            this.button_Calcular.Text = "CALCULAR";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // textBox_ValorDerecho
            // 
            this.textBox_ValorDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorDerecho.Location = new System.Drawing.Point(580, 134);
            this.textBox_ValorDerecho.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ValorDerecho.Name = "textBox_ValorDerecho";
            this.textBox_ValorDerecho.Size = new System.Drawing.Size(165, 34);
            this.textBox_ValorDerecho.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "VALOR DERECHO";
            // 
            // textBox_ValorIzquierdo
            // 
            this.textBox_ValorIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorIzquierdo.Location = new System.Drawing.Point(580, 202);
            this.textBox_ValorIzquierdo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ValorIzquierdo.Name = "textBox_ValorIzquierdo";
            this.textBox_ValorIzquierdo.Size = new System.Drawing.Size(165, 34);
            this.textBox_ValorIzquierdo.TabIndex = 3;
            // 
            // label_ValorIzquierdo
            // 
            this.label_ValorIzquierdo.AutoSize = true;
            this.label_ValorIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorIzquierdo.Location = new System.Drawing.Point(310, 205);
            this.label_ValorIzquierdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ValorIzquierdo.Name = "label_ValorIzquierdo";
            this.label_ValorIzquierdo.Size = new System.Drawing.Size(244, 29);
            this.label_ValorIzquierdo.TabIndex = 26;
            this.label_ValorIzquierdo.Text = "VALOR IZQUIERDO";
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(580, 270);
            this.textBox_Tolerancia.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(165, 34);
            this.textBox_Tolerancia.TabIndex = 4;
            // 
            // label_Tolerancia
            // 
            this.label_Tolerancia.AutoSize = true;
            this.label_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tolerancia.Location = new System.Drawing.Point(379, 273);
            this.label_Tolerancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tolerancia.Name = "label_Tolerancia";
            this.label_Tolerancia.Size = new System.Drawing.Size(175, 29);
            this.label_Tolerancia.TabIndex = 24;
            this.label_Tolerancia.Text = "TOLERANCIA";
            // 
            // textBox_Iteraciones
            // 
            this.textBox_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Iteraciones.Location = new System.Drawing.Point(580, 66);
            this.textBox_Iteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Iteraciones.Name = "textBox_Iteraciones";
            this.textBox_Iteraciones.Size = new System.Drawing.Size(165, 34);
            this.textBox_Iteraciones.TabIndex = 1;
            // 
            // label_Iteraciones
            // 
            this.label_Iteraciones.AutoSize = true;
            this.label_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Iteraciones.Location = new System.Drawing.Point(368, 69);
            this.label_Iteraciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Iteraciones.Name = "label_Iteraciones";
            this.label_Iteraciones.Size = new System.Drawing.Size(186, 29);
            this.label_Iteraciones.TabIndex = 22;
            this.label_Iteraciones.Text = "ITERACIONES";
            // 
            // label_Funcion
            // 
            this.label_Funcion.AutoSize = true;
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(13, 89);
            this.label_Funcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(137, 29);
            this.label_Funcion.TabIndex = 20;
            this.label_Funcion.Text = "FUNCION:";
            // 
            // label_TitDatosEntrada
            // 
            this.label_TitDatosEntrada.AutoSize = true;
            this.label_TitDatosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitDatosEntrada.Location = new System.Drawing.Point(225, 9);
            this.label_TitDatosEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TitDatosEntrada.Name = "label_TitDatosEntrada";
            this.label_TitDatosEntrada.Size = new System.Drawing.Size(307, 31);
            this.label_TitDatosEntrada.TabIndex = 19;
            this.label_TitDatosEntrada.Text = "DATOS DE ENTRADA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(347, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "O PUNTO DE INICIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 21);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.Tag = "Funcion";
            this.radioButton1.Text = "Actividad 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 21);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Funcion";
            this.radioButton2.Text = "Actividad 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 21);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.Tag = "Funcion";
            this.radioButton3.Text = "Actividad 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 102);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 21);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.Tag = "Funcion";
            this.radioButton4.Text = "Actividad 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(90, 21);
            this.radioButton5.TabIndex = 43;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "Metodo";
            this.radioButton5.Text = "Tangente";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(19, 46);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 21);
            this.radioButton6.TabIndex = 44;
            this.radioButton6.Tag = "Metodo";
            this.radioButton6.Text = "Secante";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(19, 73);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 21);
            this.radioButton7.TabIndex = 45;
            this.radioButton7.Tag = "Metodo";
            this.radioButton7.Text = "Biseccion";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(19, 100);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(104, 21);
            this.radioButton8.TabIndex = 46;
            this.radioButton8.Tag = "Metodo";
            this.radioButton8.Text = "Regla Falsa";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "METODO: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(14, 157);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(111, 21);
            this.radioButton9.TabIndex = 49;
            this.radioButton9.Tag = "Funcion";
            this.radioButton9.Text = "Actividad 5-b";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(15, 130);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(111, 21);
            this.radioButton10.TabIndex = 48;
            this.radioButton10.Tag = "Funcion";
            this.radioButton10.Text = "Actividad 5-a";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(141, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 209);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(141, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 128);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(15, 182);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(105, 21);
            this.radioButton11.TabIndex = 50;
            this.radioButton11.Tag = "Funcion";
            this.radioButton11.Text = "Para parcial";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Error);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.textBox_IteracionesR);
            this.Controls.Add(this.label_IteracionesR);
            this.Controls.Add(this.textBox_Raiz);
            this.Controls.Add(this.label_Raiz);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_ValorDerecho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ValorIzquierdo);
            this.Controls.Add(this.label_ValorIzquierdo);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.label_Tolerancia);
            this.Controls.Add(this.textBox_Iteraciones);
            this.Controls.Add(this.label_Iteraciones);
            this.Controls.Add(this.label_Funcion);
            this.Controls.Add(this.label_TitDatosEntrada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Error;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.TextBox textBox_IteracionesR;
        private System.Windows.Forms.Label label_IteracionesR;
        private System.Windows.Forms.TextBox textBox_Raiz;
        private System.Windows.Forms.Label label_Raiz;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.TextBox textBox_ValorDerecho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ValorIzquierdo;
        private System.Windows.Forms.Label label_ValorIzquierdo;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.Label label_Tolerancia;
        private System.Windows.Forms.TextBox textBox_Iteraciones;
        private System.Windows.Forms.Label label_Iteraciones;
        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.Label label_TitDatosEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton11;
    }
}

