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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NumIncon
            // 
            this.label_NumIncon.AutoSize = true;
            this.label_NumIncon.Location = new System.Drawing.Point(40, 26);
            this.label_NumIncon.Name = "label_NumIncon";
            this.label_NumIncon.Size = new System.Drawing.Size(145, 13);
            this.label_NumIncon.TabIndex = 0;
            this.label_NumIncon.Text = "NUMERO DE INCOGNITAS:";
            this.label_NumIncon.Click += new System.EventHandler(this.label_NumIncon_Click);
            // 
            // TextBox_NumIncogn
            // 
            this.TextBox_NumIncogn.Location = new System.Drawing.Point(212, 19);
            this.TextBox_NumIncogn.Name = "TextBox_NumIncogn";
            this.TextBox_NumIncogn.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NumIncogn.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 297);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(655, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(140, 297);
            this.dataGridView2.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Resultados";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(369, 16);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(103, 30);
            this.buttonConfirmar.TabIndex = 9;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(594, 16);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(101, 33);
            this.button_Calcular.TabIndex = 8;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBox_NumIncogn);
            this.Controls.Add(this.label_NumIncon);
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
    }
}