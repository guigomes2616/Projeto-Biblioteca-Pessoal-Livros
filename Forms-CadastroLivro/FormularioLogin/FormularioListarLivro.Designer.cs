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
            ListaLivro.Location = new Point(17, 20);
            ListaLivro.Margin = new Padding(4, 5, 4, 5);
            ListaLivro.Name = "ListaLivro";
            ListaLivro.ReadOnly = true;
            ListaLivro.RowHeadersWidth = 51;
            ListaLivro.Size = new Size(656, 332);
            ListaLivro.TabIndex = 0;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(286, 383);
            btn_Voltar.Margin = new Padding(4, 5, 4, 5);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(107, 38);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // FormularioListarLivro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(690, 475);
            Controls.Add(btn_Voltar);
            Controls.Add(ListaLivro);
            Margin = new Padding(4, 5, 4, 5);
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
