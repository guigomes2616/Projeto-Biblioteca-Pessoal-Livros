namespace FormularioLogin
{
    partial class FormularioCadastroLivro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_nomeLivro = new TextBox();
            btn_Voltar = new Button();
            btn_Cadastrar = new Button();
            tb_autorLivro = new TextBox();
            tb_anoPublicacao = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome do Livro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Autor do Livro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 303);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 2;
            label3.Text = "Ano de Publicação:";
            // 
            // tb_nomeLivro
            // 
            tb_nomeLivro.Location = new Point(171, 92);
            tb_nomeLivro.Margin = new Padding(4, 5, 4, 5);
            tb_nomeLivro.Name = "tb_nomeLivro";
            tb_nomeLivro.Size = new Size(427, 31);
            tb_nomeLivro.TabIndex = 4;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(347, 462);
            btn_Voltar.Margin = new Padding(4, 5, 4, 5);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(253, 38);
            btn_Voltar.TabIndex = 8;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(36, 462);
            btn_Cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(253, 38);
            btn_Cadastrar.TabIndex = 9;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // tb_autorLivro
            // 
            tb_autorLivro.Location = new Point(171, 197);
            tb_autorLivro.Margin = new Padding(4, 5, 4, 5);
            tb_autorLivro.Name = "tb_autorLivro";
            tb_autorLivro.Size = new Size(427, 31);
            tb_autorLivro.TabIndex = 10;
            // 
            // tb_anoPublicacao
            // 
            tb_anoPublicacao.Location = new Point(200, 298);
            tb_anoPublicacao.Margin = new Padding(4, 5, 4, 5);
            tb_anoPublicacao.Name = "tb_anoPublicacao";
            tb_anoPublicacao.Size = new Size(398, 31);
            tb_anoPublicacao.TabIndex = 11;
            // 
            // FormularioCadastroLivro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(646, 535);
            Controls.Add(tb_anoPublicacao);
            Controls.Add(tb_autorLivro);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Voltar);
            Controls.Add(tb_nomeLivro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormularioCadastroLivro";
            Text = "FormularioCadastroLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_nomeLivro;
        private Button btn_Voltar;
        private Button btn_Cadastrar;
        private TextBox tb_autorLivro;
        private TextBox tb_anoPublicacao;
    }
}