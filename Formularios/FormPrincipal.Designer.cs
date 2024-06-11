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
            this.btn_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.ForeColor = System.Drawing.Color.Purple;
            this.btn_Listar.Location = new System.Drawing.Point(198, 47);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(76, 25);
            this.btn_Listar.TabIndex = 0;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_CadLivro
            // 
            this.btn_CadLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadLivro.ForeColor = System.Drawing.Color.Purple;
            this.btn_CadLivro.Location = new System.Drawing.Point(198, 90);
            this.btn_CadLivro.Name = "btn_CadLivro";
            this.btn_CadLivro.Size = new System.Drawing.Size(76, 25);
            this.btn_CadLivro.TabIndex = 1;
            this.btn_CadLivro.Text = "Cadastrar";
            this.btn_CadLivro.UseVisualStyleBackColor = true;
            this.btn_CadLivro.Click += new System.EventHandler(this.btn_CadLivro_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Purple;
            this.btn_Sair.Location = new System.Drawing.Point(53, 151);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(240, 23);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lab_Listar
            // 
            this.lab_Listar.AutoSize = true;
            this.lab_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Listar.Location = new System.Drawing.Point(88, 51);
            this.lab_Listar.Name = "lab_Listar";
            this.lab_Listar.Size = new System.Drawing.Size(80, 15);
            this.lab_Listar.TabIndex = 3;
            this.lab_Listar.Text = "Listar livos:";
            // 
            // lab_CadLivro
            // 
            this.lab_CadLivro.AutoSize = true;
            this.lab_CadLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CadLivro.Location = new System.Drawing.Point(73, 94);
            this.lab_CadLivro.Name = "lab_CadLivro";
            this.lab_CadLivro.Size = new System.Drawing.Size(104, 15);
            this.lab_CadLivro.TabIndex = 4;
            this.lab_CadLivro.Text = "Cadastrar livro:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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