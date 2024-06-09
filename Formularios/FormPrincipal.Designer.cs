namespace Formularios
{
    partial class FormPrincipal
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
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_CadLivro = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lab_Listar = new System.Windows.Forms.Label();
            this.lab_CadLivro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(86, 67);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(63, 25);
            this.btn_Listar.TabIndex = 0;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_CadLivro
            // 
            this.btn_CadLivro.Location = new System.Drawing.Point(255, 67);
            this.btn_CadLivro.Name = "btn_CadLivro";
            this.btn_CadLivro.Size = new System.Drawing.Size(63, 25);
            this.btn_CadLivro.TabIndex = 1;
            this.btn_CadLivro.Text = "Cadastrar";
            this.btn_CadLivro.UseVisualStyleBackColor = true;
            this.btn_CadLivro.Click += new System.EventHandler(this.btn_CadLivro_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(24, 151);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(294, 23);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lab_Listar
            // 
            this.lab_Listar.AutoSize = true;
            this.lab_Listar.Location = new System.Drawing.Point(21, 73);
            this.lab_Listar.Name = "lab_Listar";
            this.lab_Listar.Size = new System.Drawing.Size(59, 13);
            this.lab_Listar.TabIndex = 3;
            this.lab_Listar.Text = "Listar livos:";
            // 
            // lab_CadLivro
            // 
            this.lab_CadLivro.AutoSize = true;
            this.lab_CadLivro.Location = new System.Drawing.Point(172, 73);
            this.lab_CadLivro.Name = "lab_CadLivro";
            this.lab_CadLivro.Size = new System.Drawing.Size(77, 13);
            this.lab_CadLivro.TabIndex = 4;
            this.lab_CadLivro.Text = "Cadastrar livro:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 186);
            this.Controls.Add(this.lab_CadLivro);
            this.Controls.Add(this.lab_Listar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_CadLivro);
            this.Controls.Add(this.btn_Listar);
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_CadLivro;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lab_Listar;
        private System.Windows.Forms.Label lab_CadLivro;
    }
}