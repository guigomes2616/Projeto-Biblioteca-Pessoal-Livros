namespace FormularioLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab_emailLogin = new Label();
            lab_senhaLogin = new Label();
            tb_emailLogin = new TextBox();
            tb_senhaLogin = new TextBox();
            label3 = new Label();
            btn_cadastrarLogin = new Button();
            btn_entrarLogin = new Button();
            SuspendLayout();
            // 
            // lab_emailLogin
            // 
            lab_emailLogin.AutoSize = true;
            lab_emailLogin.Location = new Point(109, 127);
            lab_emailLogin.Margin = new Padding(4, 0, 4, 0);
            lab_emailLogin.Name = "lab_emailLogin";
            lab_emailLogin.Size = new Size(58, 25);
            lab_emailLogin.TabIndex = 0;
            lab_emailLogin.Text = "Email:";
            // 
            // lab_senhaLogin
            // 
            lab_senhaLogin.AutoSize = true;
            lab_senhaLogin.Location = new Point(109, 230);
            lab_senhaLogin.Margin = new Padding(4, 0, 4, 0);
            lab_senhaLogin.Name = "lab_senhaLogin";
            lab_senhaLogin.Size = new Size(64, 25);
            lab_senhaLogin.TabIndex = 1;
            lab_senhaLogin.Text = "Senha:";
            // 
            // tb_emailLogin
            // 
            tb_emailLogin.Location = new Point(177, 122);
            tb_emailLogin.Margin = new Padding(4, 5, 4, 5);
            tb_emailLogin.Name = "tb_emailLogin";
            tb_emailLogin.Size = new Size(404, 31);
            tb_emailLogin.TabIndex = 2;
            // 
            // tb_senhaLogin
            // 
            tb_senhaLogin.Location = new Point(177, 225);
            tb_senhaLogin.Margin = new Padding(4, 5, 4, 5);
            tb_senhaLogin.Name = "tb_senhaLogin";
            tb_senhaLogin.PasswordChar = '*';
            tb_senhaLogin.Size = new Size(404, 31);
            tb_senhaLogin.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 313);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(330, 25);
            label3.TabIndex = 4;
            label3.Text = "Não tem cadastro? Aperte em Cadastrar";
            // 
            // btn_cadastrarLogin
            // 
            btn_cadastrarLogin.Location = new Point(109, 440);
            btn_cadastrarLogin.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrarLogin.Name = "btn_cadastrarLogin";
            btn_cadastrarLogin.Size = new Size(227, 38);
            btn_cadastrarLogin.TabIndex = 5;
            btn_cadastrarLogin.Text = "Cadastrar";
            btn_cadastrarLogin.UseVisualStyleBackColor = true;
            btn_cadastrarLogin.Click += btn_cadastrarLogin_Click;
            // 
            // btn_entrarLogin
            // 
            btn_entrarLogin.Location = new Point(360, 440);
            btn_entrarLogin.Margin = new Padding(4, 5, 4, 5);
            btn_entrarLogin.Name = "btn_entrarLogin";
            btn_entrarLogin.Size = new Size(223, 38);
            btn_entrarLogin.TabIndex = 6;
            btn_entrarLogin.Text = "Entrar";
            btn_entrarLogin.UseVisualStyleBackColor = true;
            btn_entrarLogin.Click += btn_entrarLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(690, 578);
            Controls.Add(btn_entrarLogin);
            Controls.Add(btn_cadastrarLogin);
            Controls.Add(label3);
            Controls.Add(tb_senhaLogin);
            Controls.Add(tb_emailLogin);
            Controls.Add(lab_senhaLogin);
            Controls.Add(lab_emailLogin);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_emailLogin;
        private Label lab_senhaLogin;
        private TextBox tb_emailLogin;
        private TextBox tb_senhaLogin;
        private Label label3;
        private Button btn_cadastrarLogin;
        private Button btn_entrarLogin;
    }
}
