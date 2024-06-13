namespace Formularios
{
    partial class FormListarLivros
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
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.AllowUserToDeleteRows = false;
            this.dataGridViewLivros.AllowUserToOrderColumns = true;
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.ReadOnly = true;
            this.dataGridViewLivros.Size = new System.Drawing.Size(382, 216);
            this.dataGridViewLivros.TabIndex = 0;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(160, 243);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // FormListarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 303);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.dataGridViewLivros);
            this.Name = "FormListarLivros";
            this.Text = "FormListarLivros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Button btn_Voltar;
    }
}