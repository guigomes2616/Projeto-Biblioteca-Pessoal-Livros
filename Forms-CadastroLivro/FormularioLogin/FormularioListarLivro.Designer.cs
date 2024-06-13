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
            ListaLivro.Location = new Point(14, 16);
            ListaLivro.Margin = new Padding(3, 4, 3, 4);
            ListaLivro.Name = "ListaLivro";
            ListaLivro.ReadOnly = true;
            ListaLivro.RowHeadersWidth = 51;
            ListaLivro.Size = new Size(525, 265);
            ListaLivro.TabIndex = 0;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(229, 307);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(86, 31);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click_1;
            // 
            // FormularioListarLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 380);
            Controls.Add(btn_Voltar);
            Controls.Add(ListaLivro);
            Margin = new Padding(3, 4, 3, 4);
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
