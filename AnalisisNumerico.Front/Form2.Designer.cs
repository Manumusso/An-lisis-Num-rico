namespace AnalisisNumerico.Front
{
    partial class Form2
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
            this.label_NumIncon = new System.Windows.Forms.Label();
            this.TextBox_NumIncogn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIterac = new System.Windows.Forms.TextBox();
            this.tbError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NumIncon
            // 
            this.label_NumIncon.AutoSize = true;
            this.label_NumIncon.Location = new System.Drawing.Point(98, 29);
            this.label_NumIncon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumIncon.Name = "label_NumIncon";
            this.label_NumIncon.Size = new System.Drawing.Size(184, 17);
            this.label_NumIncon.TabIndex = 0;
            this.label_NumIncon.Text = "NUMERO DE INCOGNITAS:";
            this.label_NumIncon.Click += new System.EventHandler(this.label_NumIncon_Click);
            // 
            // TextBox_NumIncogn
            // 
            this.TextBox_NumIncogn.Location = new System.Drawing.Point(290, 26);
            this.TextBox_NumIncogn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_NumIncogn.Name = "TextBox_NumIncogn";
            this.TextBox_NumIncogn.Size = new System.Drawing.Size(132, 22);
            this.TextBox_NumIncogn.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 366);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(868, 177);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(187, 328);
            this.dataGridView2.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Resultados";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(429, 16);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(137, 37);
            this.buttonConfirmar.TabIndex = 9;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(135, 115);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(204, 41);
            this.button_Calcular.TabIndex = 8;
            this.button_Calcular.Text = "GaussJordan";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "GaussSeidel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(884, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Iteraciones: XX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Iteraciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Error";
            // 
            // tbIterac
            // 
            this.tbIterac.Location = new System.Drawing.Point(691, 75);
            this.tbIterac.Name = "tbIterac";
            this.tbIterac.Size = new System.Drawing.Size(100, 22);
            this.tbIterac.TabIndex = 14;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(691, 103);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(100, 22);
            this.tbError.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.tbIterac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBox_NumIncogn);
            this.Controls.Add(this.label_NumIncon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NumIncon;
        private System.Windows.Forms.TextBox TextBox_NumIncogn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIterac;
        private System.Windows.Forms.TextBox tbError;
    }
}