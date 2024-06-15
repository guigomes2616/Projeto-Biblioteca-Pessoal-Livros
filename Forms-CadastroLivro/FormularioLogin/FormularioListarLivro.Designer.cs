namespace FormularioLogin
{
    partial class FormularioListarLivro
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
            ListaLivro = new DataGridView();
            btn_Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaLivro).BeginInit();
            SuspendLayout();
            // 
            // ListaLivro
            // 
            ListaLivro.AllowUserToDeleteRows = false;
            ListaLivro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaLivro.Location = new Point(12, 12);
            ListaLivro.Name = "ListaLivro";
            ListaLivro.ReadOnly = true;
            ListaLivro.RowHeadersWidth = 51;
            ListaLivro.Size = new Size(459, 199);
            ListaLivro.TabIndex = 0;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(200, 230);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(75, 23);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // FormularioListarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 285);
            Controls.Add(btn_Voltar);
            Controls.Add(ListaLivro);
            MaximizeBox = false;
            Name = "FormularioListarLivro";
            Text = "FormularioListarLivro";
            ((System.ComponentModel.ISupportInitialize)ListaLivro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListaLivro;
        private Button btn_Voltar;
    }
}
