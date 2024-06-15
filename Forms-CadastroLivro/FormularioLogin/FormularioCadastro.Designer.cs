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
            lab_nomeCad.Location = new Point(12, 19);
            lab_nomeCad.Name = "lab_nomeCad";
            lab_nomeCad.Size = new Size(43, 15);
            lab_nomeCad.TabIndex = 0;
            lab_nomeCad.Text = "Nome:";
            // 
            // lab_datanasCad
            // 
            lab_datanasCad.AutoSize = true;
            lab_datanasCad.Location = new Point(12, 66);
            lab_datanasCad.Name = "lab_datanasCad";
            lab_datanasCad.Size = new Size(117, 15);
            lab_datanasCad.TabIndex = 1;
            lab_datanasCad.Text = "Data de Nascimento:";
            // 
            // lab_emailCad
            // 
            lab_emailCad.AutoSize = true;
            lab_emailCad.Location = new Point(12, 111);
            lab_emailCad.Name = "lab_emailCad";
            lab_emailCad.Size = new Size(39, 15);
            lab_emailCad.TabIndex = 2;
            lab_emailCad.Text = "Email:";
            // 
            // lab_nicknameCad
            // 
            lab_nicknameCad.AutoSize = true;
            lab_nicknameCad.Location = new Point(12, 163);
            lab_nicknameCad.Name = "lab_nicknameCad";
            lab_nicknameCad.Size = new Size(51, 15);
            lab_nicknameCad.TabIndex = 3;
            lab_nicknameCad.Text = "Apelido:";
            // 
            // lab_senhaCad
            // 
            lab_senhaCad.AutoSize = true;
            lab_senhaCad.Location = new Point(12, 208);
            lab_senhaCad.Name = "lab_senhaCad";
            lab_senhaCad.Size = new Size(42, 15);
            lab_senhaCad.TabIndex = 4;
            lab_senhaCad.Text = "Senha:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(69, 16);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(341, 23);
            tb_nome.TabIndex = 5;
            // 
            // tb_dataNascimento
            // 
            tb_dataNascimento.Location = new Point(135, 63);
            tb_dataNascimento.Name = "tb_dataNascimento";
            tb_dataNascimento.Size = new Size(275, 23);
            tb_dataNascimento.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(69, 108);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(341, 23);
            tb_email.TabIndex = 7;
            // 
            // tb_nickname
            // 
            tb_nickname.Location = new Point(69, 160);
            tb_nickname.Name = "tb_nickname";
            tb_nickname.Size = new Size(341, 23);
            tb_nickname.TabIndex = 8;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(69, 205);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(341, 23);
            tb_senha.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(12, 290);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(163, 23);
            btn_cadastrar.TabIndex = 10;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(247, 290);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(163, 23);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FormularioCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 338);
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