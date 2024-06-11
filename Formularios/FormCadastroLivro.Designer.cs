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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Generos = new System.Windows.Forms.CheckedListBox();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.tb_anoPublicacao = new System.Windows.Forms.TextBox();
            this.tb_autorLivro = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Gênero do livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o Nome do livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o Autor do livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o Ano de publicação:";
            // 
            // cb_Generos
            // 
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
            this.cb_Generos.Location = new System.Drawing.Point(238, 35);
            this.cb_Generos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Generos.Name = "cb_Generos";
            this.cb_Generos.Size = new System.Drawing.Size(222, 303);
            this.cb_Generos.TabIndex = 4;
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.Location = new System.Drawing.Point(198, 363);
            this.tb_nomeLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.Size = new System.Drawing.Size(262, 26);
            this.tb_nomeLivro.TabIndex = 5;
            // 
            // tb_anoPublicacao
            // 
            this.tb_anoPublicacao.Location = new System.Drawing.Point(230, 462);
            this.tb_anoPublicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_anoPublicacao.Name = "tb_anoPublicacao";
            this.tb_anoPublicacao.Size = new System.Drawing.Size(230, 26);
            this.tb_anoPublicacao.TabIndex = 6;
            // 
            // tb_autorLivro
            // 
            this.tb_autorLivro.Location = new System.Drawing.Point(198, 411);
            this.tb_autorLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_autorLivro.Name = "tb_autorLivro";
            this.tb_autorLivro.Size = new System.Drawing.Size(262, 26);
            this.tb_autorLivro.TabIndex = 7;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(22, 523);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(202, 35);
            this.btn_Voltar.TabIndex = 8;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(238, 523);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(224, 35);
            this.btn_Cadastrar.TabIndex = 9;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // FormCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.tb_autorLivro);
            this.Controls.Add(this.tb_anoPublicacao);
            this.Controls.Add(this.tb_nomeLivro);
            this.Controls.Add(this.cb_Generos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroLivro";
            this.Text = "FormCadastroLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cb_Generos;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.TextBox tb_anoPublicacao;
        private System.Windows.Forms.TextBox tb_autorLivro;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}