using System.Windows.Forms;

namespace Formularios
{
    public partial class FormLivro : Form
    {
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

        private void InitializeComponent()
        {
            this.cb_Generos = new System.Windows.Forms.ComboBox();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.tb_autorLivro = new System.Windows.Forms.TextBox();
            this.tb_anoPublicacao = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Generos
            // 
            this.cb_Generos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Generos.FormattingEnabled = true;
            this.cb_Generos.Items.AddRange(new object[] {
            "Acao",
            "Aventura",
            "Comedia",
            "Documentario",
            "Drama",
            "Espionagem",
            "Faroeste",
            "Fantasia",
            "Ficcao_Cientifica",
            "Auto_Ajuda",
            "Romance",
            "Suspense",
            "Terror"});
            this.cb_Generos.Location = new System.Drawing.Point(20, 30);
            this.cb_Generos.Name = "cb_Generos";
            this.cb_Generos.Size = new System.Drawing.Size(200, 21);
            this.cb_Generos.TabIndex = 0;
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.Location = new System.Drawing.Point(20, 70);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.Size = new System.Drawing.Size(200, 20);
            this.tb_nomeLivro.TabIndex = 1;
            // 
            // tb_autorLivro
            // 
            this.tb_autorLivro.Location = new System.Drawing.Point(20, 110);
            this.tb_autorLivro.Name = "tb_autorLivro";
            this.tb_autorLivro.Size = new System.Drawing.Size(200, 20);
            this.tb_autorLivro.TabIndex = 2;
            // 
            // tb_anoPublicacao
            // 
            this.tb_anoPublicacao.Location = new System.Drawing.Point(20, 150);
            this.tb_anoPublicacao.Name = "tb_anoPublicacao";
            this.tb_anoPublicacao.Size = new System.Drawing.Size(100, 20);
            this.tb_anoPublicacao.TabIndex = 3;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(20, 200);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(145, 200);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 5;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // FormLivro
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_Generos);
            this.Controls.Add(this.tb_nomeLivro);
            this.Controls.Add(this.tb_autorLivro);
            this.Controls.Add(this.tb_anoPublicacao);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Name = "FormLivro";
            this.Text = "Cadastro de Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Generos;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.TextBox tb_autorLivro;
        private System.Windows.Forms.TextBox tb_anoPublicacao;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}
