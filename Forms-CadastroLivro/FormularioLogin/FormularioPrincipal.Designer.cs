namespace FormularioLogin
{
    partial class FormularioPrincipal
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
            lab_Listar = new Label();
            lab_CadLivro = new Label();
            btn_Listar = new Button();
            btn_CadLivro = new Button();
            btn_Sair = new Button();
            SuspendLayout();
            // 
            // lab_Listar
            // 
            lab_Listar.AutoSize = true;
            lab_Listar.Location = new Point(117, 102);
            lab_Listar.Name = "lab_Listar";
            lab_Listar.Size = new Size(72, 15);
            lab_Listar.TabIndex = 0;
            lab_Listar.Text = "Listar Livros:";
            // 
            // lab_CadLivro
            // 
            lab_CadLivro.AutoSize = true;
            lab_CadLivro.Location = new Point(117, 184);
            lab_CadLivro.Name = "lab_CadLivro";
            lab_CadLivro.Size = new Size(89, 15);
            lab_CadLivro.TabIndex = 1;
            lab_CadLivro.Text = "Cadastrar Livro:";
            // 
            // btn_Listar
            // 
            btn_Listar.Location = new Point(249, 98);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(134, 23);
            btn_Listar.TabIndex = 2;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = true;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // btn_CadLivro
            // 
            btn_CadLivro.Location = new Point(249, 180);
            btn_CadLivro.Name = "btn_CadLivro";
            btn_CadLivro.Size = new Size(134, 23);
            btn_CadLivro.TabIndex = 3;
            btn_CadLivro.Text = "Cadastrar";
            btn_CadLivro.UseVisualStyleBackColor = true;
            btn_CadLivro.Click += btn_CadLivro_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(83, 293);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(319, 23);
            btn_Sair.TabIndex = 4;
            btn_Sair.Text = "Sair do programa";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 368);
            Controls.Add(btn_Sair);
            Controls.Add(btn_CadLivro);
            Controls.Add(btn_Listar);
            Controls.Add(lab_CadLivro);
            Controls.Add(lab_Listar);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_Listar;
        private Label lab_CadLivro;
        private Button btn_Listar;
        private Button btn_CadLivro;
        private Button btn_Sair;
    }
}