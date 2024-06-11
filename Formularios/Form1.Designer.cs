namespace Formularios
{
    partial class FormLogin
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
            this.lab_emailLogin = new System.Windows.Forms.Label();
            this.lab_senhaLogin = new System.Windows.Forms.Label();
            this.tb_emailLogin = new System.Windows.Forms.TextBox();
            this.tb_senhaLogin = new System.Windows.Forms.TextBox();
            this.btn_cadastrarLogin = new System.Windows.Forms.Button();
            this.btn_entrarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_emailLogin
            // 
            this.lab_emailLogin.AutoSize = true;
            this.lab_emailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emailLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_emailLogin.Location = new System.Drawing.Point(30, 52);
            this.lab_emailLogin.Name = "lab_emailLogin";
            this.lab_emailLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_emailLogin.Size = new System.Drawing.Size(41, 13);
            this.lab_emailLogin.TabIndex = 1;
            this.lab_emailLogin.Text = "Email:";
            // 
            // lab_senhaLogin
            // 
            this.lab_senhaLogin.AutoSize = true;
            this.lab_senhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_senhaLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_senhaLogin.Location = new System.Drawing.Point(30, 101);
            this.lab_senhaLogin.Name = "lab_senhaLogin";
            this.lab_senhaLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_senhaLogin.Size = new System.Drawing.Size(47, 13);
            this.lab_senhaLogin.TabIndex = 2;
            this.lab_senhaLogin.Text = "Senha:";
            // 
            // tb_emailLogin
            // 
            this.tb_emailLogin.Location = new System.Drawing.Point(72, 49);
            this.tb_emailLogin.Name = "tb_emailLogin";
            this.tb_emailLogin.Size = new System.Drawing.Size(173, 20);
            this.tb_emailLogin.TabIndex = 3;
            this.tb_emailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_senhaLogin
            // 
            this.tb_senhaLogin.Location = new System.Drawing.Point(83, 98);
            this.tb_senhaLogin.Name = "tb_senhaLogin";
            this.tb_senhaLogin.Size = new System.Drawing.Size(162, 20);
            this.tb_senhaLogin.TabIndex = 4;
            this.tb_senhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_cadastrarLogin
            // 
            this.btn_cadastrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrarLogin.ForeColor = System.Drawing.Color.Purple;
            this.btn_cadastrarLogin.Location = new System.Drawing.Point(33, 159);
            this.btn_cadastrarLogin.Name = "btn_cadastrarLogin";
            this.btn_cadastrarLogin.Size = new System.Drawing.Size(97, 23);
            this.btn_cadastrarLogin.TabIndex = 5;
            this.btn_cadastrarLogin.Text = "Cadastrar";
            this.btn_cadastrarLogin.UseVisualStyleBackColor = true;
            this.btn_cadastrarLogin.Click += new System.EventHandler(this.btn_cadastrarLogin_Click);
            // 
            // btn_entrarLogin
            // 
            this.btn_entrarLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_entrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrarLogin.ForeColor = System.Drawing.Color.Purple;
            this.btn_entrarLogin.Location = new System.Drawing.Point(149, 159);
            this.btn_entrarLogin.Name = "btn_entrarLogin";
            this.btn_entrarLogin.Size = new System.Drawing.Size(96, 23);
            this.btn_entrarLogin.TabIndex = 6;
            this.btn_entrarLogin.Text = "Entrar";
            this.btn_entrarLogin.UseVisualStyleBackColor = false;
            this.btn_entrarLogin.Click += new System.EventHandler(this.btn_entrarLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(297, 241);
            this.Controls.Add(this.btn_entrarLogin);
            this.Controls.Add(this.btn_cadastrarLogin);
            this.Controls.Add(this.tb_senhaLogin);
            this.Controls.Add(this.tb_emailLogin);
            this.Controls.Add(this.lab_senhaLogin);
            this.Controls.Add(this.lab_emailLogin);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Login - Cadastro de Livro";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_emailLogin;
        private System.Windows.Forms.Label lab_senhaLogin;
        private System.Windows.Forms.TextBox tb_emailLogin;
        private System.Windows.Forms.TextBox tb_senhaLogin;
        private System.Windows.Forms.Button btn_cadastrarLogin;
        private System.Windows.Forms.Button btn_entrarLogin;
    }
}

