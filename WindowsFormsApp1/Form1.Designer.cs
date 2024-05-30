namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_texto = new System.Windows.Forms.Label();
            this.textbox_texto = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lab_textoEnviado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_texto
            // 
            this.lab_texto.AutoSize = true;
            this.lab_texto.Location = new System.Drawing.Point(2, 9);
            this.lab_texto.Name = "lab_texto";
            this.lab_texto.Size = new System.Drawing.Size(102, 13);
            this.lab_texto.TabIndex = 0;
            this.lab_texto.Text = "Digite alguma coisa:";
            // 
            // textbox_texto
            // 
            this.textbox_texto.Location = new System.Drawing.Point(110, 9);
            this.textbox_texto.Name = "textbox_texto";
            this.textbox_texto.Size = new System.Drawing.Size(145, 20);
            this.textbox_texto.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(5, 40);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lab_textoEnviado
            // 
            this.lab_textoEnviado.AutoSize = true;
            this.lab_textoEnviado.Location = new System.Drawing.Point(2, 83);
            this.lab_textoEnviado.Name = "lab_textoEnviado";
            this.lab_textoEnviado.Size = new System.Drawing.Size(65, 13);
            this.lab_textoEnviado.TabIndex = 3;
            this.lab_textoEnviado.Text = "Aguardando";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(604, 345);
            this.Controls.Add(this.lab_textoEnviado);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textbox_texto);
            this.Controls.Add(this.lab_texto);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_texto;
        private System.Windows.Forms.TextBox textbox_texto;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lab_textoEnviado;
    }
}

