namespace FormularioLogin
{
    partial class FormularioCadastro
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
            lab_nomeCad = new Label();
            lab_datanasCad = new Label();
            lab_emailCad = new Label();
            lab_nicknameCad = new Label();
            lab_senhaCad = new Label();
            tb_nome = new TextBox();
            tb_dataNascimento = new TextBox();
            tb_email = new TextBox();
            tb_nickname = new TextBox();
            tb_senha = new TextBox();
            btn_cadastrar = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // lab_nomeCad
            // 
            lab_nomeCad.AutoSize = true;
            lab_nomeCad.Location = new Point(17, 32);
            lab_nomeCad.Margin = new Padding(4, 0, 4, 0);
            lab_nomeCad.Name = "lab_nomeCad";
            lab_nomeCad.Size = new Size(65, 25);
            lab_nomeCad.TabIndex = 0;
            lab_nomeCad.Text = "Nome:";
            // 
            // lab_datanasCad
            // 
            lab_datanasCad.AutoSize = true;
            lab_datanasCad.Location = new Point(17, 110);
            lab_datanasCad.Margin = new Padding(4, 0, 4, 0);
            lab_datanasCad.Name = "lab_datanasCad";
            lab_datanasCad.Size = new Size(177, 25);
            lab_datanasCad.TabIndex = 1;
            lab_datanasCad.Text = "Data de Nascimento:";
            // 
            // lab_emailCad
            // 
            lab_emailCad.AutoSize = true;
            lab_emailCad.Location = new Point(17, 185);
            lab_emailCad.Margin = new Padding(4, 0, 4, 0);
            lab_emailCad.Name = "lab_emailCad";
            lab_emailCad.Size = new Size(58, 25);
            lab_emailCad.TabIndex = 2;
            lab_emailCad.Text = "Email:";
            // 
            // lab_nicknameCad
            // 
            lab_nicknameCad.AutoSize = true;
            lab_nicknameCad.Location = new Point(17, 272);
            lab_nicknameCad.Margin = new Padding(4, 0, 4, 0);
            lab_nicknameCad.Name = "lab_nicknameCad";
            lab_nicknameCad.Size = new Size(78, 25);
            lab_nicknameCad.TabIndex = 3;
            lab_nicknameCad.Text = "Apelido:";
            // 
            // lab_senhaCad
            // 
            lab_senhaCad.AutoSize = true;
            lab_senhaCad.Location = new Point(17, 347);
            lab_senhaCad.Margin = new Padding(4, 0, 4, 0);
            lab_senhaCad.Name = "lab_senhaCad";
            lab_senhaCad.Size = new Size(64, 25);
            lab_senhaCad.TabIndex = 4;
            lab_senhaCad.Text = "Senha:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(99, 27);
            tb_nome.Margin = new Padding(4, 5, 4, 5);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(485, 31);
            tb_nome.TabIndex = 5;
            // 
            // tb_dataNascimento
            // 
            tb_dataNascimento.Location = new Point(193, 105);
            tb_dataNascimento.Margin = new Padding(4, 5, 4, 5);
            tb_dataNascimento.Name = "tb_dataNascimento";
            tb_dataNascimento.Size = new Size(391, 31);
            tb_dataNascimento.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(99, 180);
            tb_email.Margin = new Padding(4, 5, 4, 5);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(485, 31);
            tb_email.TabIndex = 7;
            // 
            // tb_nickname
            // 
            tb_nickname.Location = new Point(99, 267);
            tb_nickname.Margin = new Padding(4, 5, 4, 5);
            tb_nickname.Name = "tb_nickname";
            tb_nickname.Size = new Size(485, 31);
            tb_nickname.TabIndex = 8;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(99, 342);
            tb_senha.Margin = new Padding(4, 5, 4, 5);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(485, 31);
            tb_senha.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(17, 483);
            btn_cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(233, 38);
            btn_cadastrar.TabIndex = 10;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(353, 483);
            btn_voltar.Margin = new Padding(4, 5, 4, 5);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(233, 38);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FormularioCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(631, 563);
            Controls.Add(btn_voltar);
            Controls.Add(btn_cadastrar);
            Controls.Add(tb_senha);
            Controls.Add(tb_nickname);
            Controls.Add(tb_email);
            Controls.Add(tb_dataNascimento);
            Controls.Add(tb_nome);
            Controls.Add(lab_senhaCad);
            Controls.Add(lab_nicknameCad);
            Controls.Add(lab_emailCad);
            Controls.Add(lab_datanasCad);
            Controls.Add(lab_nomeCad);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormularioCadastro";
            Text = "FormularioCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_nomeCad;
        private Label lab_datanasCad;
        private Label lab_emailCad;
        private Label lab_nicknameCad;
        private Label lab_senhaCad;
        private TextBox tb_nome;
        private TextBox tb_dataNascimento;
        private TextBox tb_email;
        private TextBox tb_nickname;
        private TextBox tb_senha;
        private Button btn_cadastrar;
        private Button btn_voltar;
    }
}