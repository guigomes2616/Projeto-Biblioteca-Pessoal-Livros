namespace Formularios
{
    partial class FormCadastro
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
            this.lab_nomeCad = new System.Windows.Forms.Label();
            this.lab_datanasCad = new System.Windows.Forms.Label();
            this.lab_emailCad = new System.Windows.Forms.Label();
            this.lab_nicknameCad = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lab_senhaCad = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_dataNascimento = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_nomeCad
            // 
            this.lab_nomeCad.AutoSize = true;
            this.lab_nomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nomeCad.Location = new System.Drawing.Point(8, 14);
            this.lab_nomeCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_nomeCad.Name = "lab_nomeCad";
            this.lab_nomeCad.Size = new System.Drawing.Size(52, 16);
            this.lab_nomeCad.TabIndex = 1;
            this.lab_nomeCad.Text = "Nome:";
            // 
            // lab_datanasCad
            // 
            this.lab_datanasCad.AutoSize = true;
            this.lab_datanasCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_datanasCad.Location = new System.Drawing.Point(3, 55);
            this.lab_datanasCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_datanasCad.Name = "lab_datanasCad";
            this.lab_datanasCad.Size = new System.Drawing.Size(152, 16);
            this.lab_datanasCad.TabIndex = 2;
            this.lab_datanasCad.Text = "Data de Nascimento:";
            // 
            // lab_emailCad
            // 
            this.lab_emailCad.AutoSize = true;
            this.lab_emailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emailCad.Location = new System.Drawing.Point(10, 97);
            this.lab_emailCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_emailCad.Name = "lab_emailCad";
            this.lab_emailCad.Size = new System.Drawing.Size(50, 16);
            this.lab_emailCad.TabIndex = 3;
            this.lab_emailCad.Text = "Email:";
            // 
            // lab_nicknameCad
            // 
            this.lab_nicknameCad.AutoSize = true;
            this.lab_nicknameCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nicknameCad.Location = new System.Drawing.Point(16, 139);
            this.lab_nicknameCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_nicknameCad.Name = "lab_nicknameCad";
            this.lab_nicknameCad.Size = new System.Drawing.Size(65, 16);
            this.lab_nicknameCad.TabIndex = 4;
            this.lab_nicknameCad.Text = "Apelido:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Purple;
            this.btn_voltar.Location = new System.Drawing.Point(20, 230);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(139, 28);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Purple;
            this.btn_cadastrar.Location = new System.Drawing.Point(167, 230);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(133, 28);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lab_senhaCad
            // 
            this.lab_senhaCad.AutoSize = true;
            this.lab_senhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_senhaCad.Location = new System.Drawing.Point(16, 182);
            this.lab_senhaCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_senhaCad.Name = "lab_senhaCad";
            this.lab_senhaCad.Size = new System.Drawing.Size(55, 16);
            this.lab_senhaCad.TabIndex = 7;
            this.lab_senhaCad.Text = "Senha:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(63, 11);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(236, 22);
            this.tb_nome.TabIndex = 8;
            // 
            // tb_dataNascimento
            // 
            this.tb_dataNascimento.Location = new System.Drawing.Point(155, 52);
            this.tb_dataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dataNascimento.Name = "tb_dataNascimento";
            this.tb_dataNascimento.Size = new System.Drawing.Size(144, 22);
            this.tb_dataNascimento.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(63, 91);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(236, 22);
            this.tb_email.TabIndex = 10;
            // 
            // tb_nickname
            // 
            this.tb_nickname.Location = new System.Drawing.Point(79, 135);
            this.tb_nickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(220, 22);
            this.tb_nickname.TabIndex = 11;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(79, 178);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(220, 22);
            this.tb_senha.TabIndex = 12;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(487, 283);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_dataNascimento);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lab_senhaCad);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lab_nicknameCad);
            this.Controls.Add(this.lab_emailCad);
            this.Controls.Add(this.lab_datanasCad);
            this.Controls.Add(this.lab_nomeCad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCadastro";
            this.Text = "Cadastro de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_nomeCad;
        private System.Windows.Forms.Label lab_datanasCad;
        private System.Windows.Forms.Label lab_emailCad;
        private System.Windows.Forms.Label lab_nicknameCad;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lab_senhaCad;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_dataNascimento;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.TextBox tb_senha;
    }
}