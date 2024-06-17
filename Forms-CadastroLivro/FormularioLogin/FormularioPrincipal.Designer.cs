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
            lab_Listar.Location = new Point(167, 170);
            lab_Listar.Margin = new Padding(4, 0, 4, 0);
            lab_Listar.Name = "lab_Listar";
            lab_Listar.Size = new Size(108, 25);
            lab_Listar.TabIndex = 0;
            lab_Listar.Text = "Listar Livros:";
            // 
            // lab_CadLivro
            // 
            lab_CadLivro.AutoSize = true;
            lab_CadLivro.Location = new Point(167, 307);
            lab_CadLivro.Margin = new Padding(4, 0, 4, 0);
            lab_CadLivro.Name = "lab_CadLivro";
            lab_CadLivro.Size = new Size(134, 25);
            lab_CadLivro.TabIndex = 1;
            lab_CadLivro.Text = "Cadastrar Livro:";
            // 
            // btn_Listar
            // 
            btn_Listar.Location = new Point(356, 163);
            btn_Listar.Margin = new Padding(4, 5, 4, 5);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(191, 38);
            btn_Listar.TabIndex = 2;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = true;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // btn_CadLivro
            // 
            btn_CadLivro.Location = new Point(356, 300);
            btn_CadLivro.Margin = new Padding(4, 5, 4, 5);
            btn_CadLivro.Name = "btn_CadLivro";
            btn_CadLivro.Size = new Size(191, 38);
            btn_CadLivro.TabIndex = 3;
            btn_CadLivro.Text = "Cadastrar";
            btn_CadLivro.UseVisualStyleBackColor = true;
            btn_CadLivro.Click += btn_CadLivro_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(119, 488);
            btn_Sair.Margin = new Padding(4, 5, 4, 5);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(456, 38);
            btn_Sair.TabIndex = 4;
            btn_Sair.Text = "Sair do programa";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(686, 613);
            Controls.Add(btn_Sair);
            Controls.Add(btn_CadLivro);
            Controls.Add(btn_Listar);
            Controls.Add(lab_CadLivro);
            Controls.Add(lab_Listar);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
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