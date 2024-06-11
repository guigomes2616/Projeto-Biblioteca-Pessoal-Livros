namespace Formularios
{
    partial class FormCadastroLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NomeLivro = new System.Windows.Forms.Label();
            this.lb_AutorLivro = new System.Windows.Forms.Label();
            this.lb_AnoPublicacao = new System.Windows.Forms.Label();
            this.cb_Generos = new System.Windows.Forms.CheckedListBox();
            this.tb_NomeLivro = new System.Windows.Forms.TextBox();
            this.tb_AnoPublicacao = new System.Windows.Forms.TextBox();
            this.tb_AutorLivro = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Gênero do livro:";
            // 
            // lb_NomeLivro
            // 
            this.lb_NomeLivro.AutoSize = true;
            this.lb_NomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeLivro.Location = new System.Drawing.Point(2, 293);
            this.lb_NomeLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NomeLivro.Name = "lb_NomeLivro";
            this.lb_NomeLivro.Size = new System.Drawing.Size(166, 16);
            this.lb_NomeLivro.TabIndex = 1;
            this.lb_NomeLivro.Text = "Digite o Nome do livro:";
            // 
            // lb_AutorLivro
            // 
            this.lb_AutorLivro.AutoSize = true;
            this.lb_AutorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AutorLivro.Location = new System.Drawing.Point(7, 335);
            this.lb_AutorLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AutorLivro.Name = "lb_AutorLivro";
            this.lb_AutorLivro.Size = new System.Drawing.Size(161, 16);
            this.lb_AutorLivro.TabIndex = 2;
            this.lb_AutorLivro.Text = "Digite o Autor do livro:";
            // 
            // lb_AnoPublicacao
            // 
            this.lb_AnoPublicacao.AutoSize = true;
            this.lb_AnoPublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AnoPublicacao.Location = new System.Drawing.Point(2, 375);
            this.lb_AnoPublicacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AnoPublicacao.Name = "lb_AnoPublicacao";
            this.lb_AnoPublicacao.Size = new System.Drawing.Size(199, 16);
            this.lb_AnoPublicacao.TabIndex = 3;
            this.lb_AnoPublicacao.Text = "Digite o Ano de publicação:";
            // 
            // cb_Generos
            // 
            this.cb_Generos.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Generos.ForeColor = System.Drawing.Color.DarkViolet;
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
            this.cb_Generos.Location = new System.Drawing.Point(212, 28);
            this.cb_Generos.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Generos.Name = "cb_Generos";
            this.cb_Generos.Size = new System.Drawing.Size(197, 242);
            this.cb_Generos.TabIndex = 4;
            // 
            // tb_NomeLivro
            // 
            this.tb_NomeLivro.Location = new System.Drawing.Point(176, 290);
            this.tb_NomeLivro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NomeLivro.Name = "tb_NomeLivro";
            this.tb_NomeLivro.Size = new System.Drawing.Size(233, 22);
            this.tb_NomeLivro.TabIndex = 5;
            // 
            // tb_AnoPublicacao
            // 
            this.tb_AnoPublicacao.Location = new System.Drawing.Point(204, 369);
            this.tb_AnoPublicacao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AnoPublicacao.Name = "tb_AnoPublicacao";
            this.tb_AnoPublicacao.Size = new System.Drawing.Size(205, 22);
            this.tb_AnoPublicacao.TabIndex = 6;
            this.tb_AnoPublicacao.TextChanged += new System.EventHandler(this.tb_AnoPublicacao_TextChanged);
            // 
            // tb_AutorLivro
            // 
            this.tb_AutorLivro.Location = new System.Drawing.Point(176, 329);
            this.tb_AutorLivro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AutorLivro.Name = "tb_AutorLivro";
            this.tb_AutorLivro.Size = new System.Drawing.Size(233, 22);
            this.tb_AutorLivro.TabIndex = 7;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.Purple;
            this.btn_Voltar.Location = new System.Drawing.Point(20, 418);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(180, 28);
            this.btn_Voltar.TabIndex = 8;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Purple;
            this.btn_Cadastrar.Location = new System.Drawing.Point(212, 418);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(199, 28);
            this.btn_Cadastrar.TabIndex = 9;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(711, 448);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.tb_AutorLivro);
            this.Controls.Add(this.tb_AnoPublicacao);
            this.Controls.Add(this.tb_NomeLivro);
            this.Controls.Add(this.cb_Generos);
            this.Controls.Add(this.lb_AnoPublicacao);
            this.Controls.Add(this.lb_AutorLivro);
            this.Controls.Add(this.lb_NomeLivro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastroLivro";
            this.Text = "FormCadastroLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_NomeLivro;
        private System.Windows.Forms.Label lb_AutorLivro;
        private System.Windows.Forms.Label lb_AnoPublicacao;
        private System.Windows.Forms.CheckedListBox cb_Generos;
        private System.Windows.Forms.TextBox tb_NomeLivro;
        private System.Windows.Forms.TextBox tb_AnoPublicacao;
        private System.Windows.Forms.TextBox tb_AutorLivro;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}