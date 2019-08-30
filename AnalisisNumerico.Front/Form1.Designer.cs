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
            this.label_TituloResultado = new System.Windows.Forms.Label();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.textBox_ValorDerecho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ValorIzquierdo = new System.Windows.Forms.TextBox();
            this.label_ValorIzquierdo = new System.Windows.Forms.Label();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.label_Tolerancia = new System.Windows.Forms.Label();
            this.textBox_Iteraciones = new System.Windows.Forms.TextBox();
            this.label_Iteraciones = new System.Windows.Forms.Label();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.label_Funcion = new System.Windows.Forms.Label();
            this.label_TitDatosEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Error
            // 
            this.textBox_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Error.Location = new System.Drawing.Point(662, 372);
            this.textBox_Error.Name = "textBox_Error";
            this.textBox_Error.Size = new System.Drawing.Size(100, 29);
            this.textBox_Error.TabIndex = 37;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.Location = new System.Drawing.Point(564, 372);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(57, 24);
            this.label_Error.TabIndex = 36;
            this.label_Error.Text = "Error";
            // 
            // textBox_IteracionesR
            // 
            this.textBox_IteracionesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IteracionesR.Location = new System.Drawing.Point(417, 372);
            this.textBox_IteracionesR.Name = "textBox_IteracionesR";
            this.textBox_IteracionesR.Size = new System.Drawing.Size(100, 29);
            this.textBox_IteracionesR.TabIndex = 35;
            // 
            // label_IteracionesR
            // 
            this.label_IteracionesR.AutoSize = true;
            this.label_IteracionesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IteracionesR.Location = new System.Drawing.Point(278, 372);
            this.label_IteracionesR.Name = "label_IteracionesR";
            this.label_IteracionesR.Size = new System.Drawing.Size(112, 24);
            this.label_IteracionesR.TabIndex = 34;
            this.label_IteracionesR.Text = "Iteraciones";
            // 
            // textBox_Raiz
            // 
            this.textBox_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Raiz.Location = new System.Drawing.Point(112, 367);
            this.textBox_Raiz.Name = "textBox_Raiz";
            this.textBox_Raiz.Size = new System.Drawing.Size(114, 29);
            this.textBox_Raiz.TabIndex = 33;
            this.textBox_Raiz.TextChanged += new System.EventHandler(this.textBox_Raiz_TextChanged);
            // 
            // label_Raiz
            // 
            this.label_Raiz.AutoSize = true;
            this.label_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Raiz.Location = new System.Drawing.Point(43, 367);
            this.label_Raiz.Name = "label_Raiz";
            this.label_Raiz.Size = new System.Drawing.Size(50, 24);
            this.label_Raiz.TabIndex = 32;
            this.label_Raiz.Text = "Raíz";
            // 
            // label_TituloResultado
            // 
            this.label_TituloResultado.AutoSize = true;
            this.label_TituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloResultado.Location = new System.Drawing.Point(276, 326);
            this.label_TituloResultado.Name = "label_TituloResultado";
            this.label_TituloResultado.Size = new System.Drawing.Size(209, 31);
            this.label_TituloResultado.TabIndex = 31;
            this.label_TituloResultado.Text = "RESULTADOS";
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(601, 241);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(135, 60);
            this.button_Calcular.TabIndex = 30;
            this.button_Calcular.Text = "CALCULAR";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // textBox_ValorDerecho
            // 
            this.textBox_ValorDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorDerecho.Location = new System.Drawing.Point(564, 190);
            this.textBox_ValorDerecho.Name = "textBox_ValorDerecho";
            this.textBox_ValorDerecho.Size = new System.Drawing.Size(100, 29);
            this.textBox_ValorDerecho.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "VALOR DERECHO";
            // 
            // textBox_ValorIzquierdo
            // 
            this.textBox_ValorIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorIzquierdo.Location = new System.Drawing.Point(212, 188);
            this.textBox_ValorIzquierdo.Name = "textBox_ValorIzquierdo";
            this.textBox_ValorIzquierdo.Size = new System.Drawing.Size(125, 29);
            this.textBox_ValorIzquierdo.TabIndex = 27;
            // 
            // label_ValorIzquierdo
            // 
            this.label_ValorIzquierdo.AutoSize = true;
            this.label_ValorIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorIzquierdo.Location = new System.Drawing.Point(10, 184);
            this.label_ValorIzquierdo.Name = "label_ValorIzquierdo";
            this.label_ValorIzquierdo.Size = new System.Drawing.Size(196, 24);
            this.label_ValorIzquierdo.TabIndex = 26;
            this.label_ValorIzquierdo.Text = "VALOR IZQUIERDO";
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(564, 142);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(100, 29);
            this.textBox_Tolerancia.TabIndex = 25;
            // 
            // label_Tolerancia
            // 
            this.label_Tolerancia.AutoSize = true;
            this.label_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tolerancia.Location = new System.Drawing.Point(372, 142);
            this.label_Tolerancia.Name = "label_Tolerancia";
            this.label_Tolerancia.Size = new System.Drawing.Size(140, 24);
            this.label_Tolerancia.TabIndex = 24;
            this.label_Tolerancia.Text = "TOLERANCIA";
            // 
            // textBox_Iteraciones
            // 
            this.textBox_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Iteraciones.Location = new System.Drawing.Point(212, 137);
            this.textBox_Iteraciones.Name = "textBox_Iteraciones";
            this.textBox_Iteraciones.Size = new System.Drawing.Size(125, 29);
            this.textBox_Iteraciones.TabIndex = 23;
            // 
            // label_Iteraciones
            // 
            this.label_Iteraciones.AutoSize = true;
            this.label_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Iteraciones.Location = new System.Drawing.Point(10, 135);
            this.label_Iteraciones.Name = "label_Iteraciones";
            this.label_Iteraciones.Size = new System.Drawing.Size(147, 24);
            this.label_Iteraciones.TabIndex = 22;
            this.label_Iteraciones.Text = "ITERACIONES";
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(146, 72);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(158, 29);
            this.textBox_Funcion.TabIndex = 21;
            // 
            // label_Funcion
            // 
            this.label_Funcion.AutoSize = true;
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(10, 72);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(108, 24);
            this.label_Funcion.TabIndex = 20;
            this.label_Funcion.Text = "FUNCION:";
            // 
            // label_TitDatosEntrada
            // 
            this.label_TitDatosEntrada.AutoSize = true;
            this.label_TitDatosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitDatosEntrada.Location = new System.Drawing.Point(224, 19);
            this.label_TitDatosEntrada.Name = "label_TitDatosEntrada";
            this.label_TitDatosEntrada.Size = new System.Drawing.Size(241, 25);
            this.label_TitDatosEntrada.TabIndex = 19;
            this.label_TitDatosEntrada.Text = "DATOS DE ENTRADA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 416);
            this.Controls.Add(this.textBox_Error);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.textBox_IteracionesR);
            this.Controls.Add(this.label_IteracionesR);
            this.Controls.Add(this.textBox_Raiz);
            this.Controls.Add(this.label_Raiz);
            this.Controls.Add(this.label_TituloResultado);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_ValorDerecho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ValorIzquierdo);
            this.Controls.Add(this.label_ValorIzquierdo);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.label_Tolerancia);
            this.Controls.Add(this.textBox_Iteraciones);
            this.Controls.Add(this.label_Iteraciones);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.label_Funcion);
            this.Controls.Add(this.label_TitDatosEntrada);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label_TituloResultado;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.TextBox textBox_ValorDerecho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ValorIzquierdo;
        private System.Windows.Forms.Label label_ValorIzquierdo;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.Label label_Tolerancia;
        private System.Windows.Forms.TextBox textBox_Iteraciones;
        private System.Windows.Forms.Label label_Iteraciones;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.Label label_TitDatosEntrada;
    }
}

