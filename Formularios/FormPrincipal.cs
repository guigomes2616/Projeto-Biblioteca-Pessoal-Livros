using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        private int usuarioId;
        private MySqlConnection connection;

        public FormPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.usuarioId = idUsuario;
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");

            btn_Listar.Click += btn_Listar_Click;
            btn_CadLivro.Click += btn_CadLivro_Click;
            btn_Sair.Click += btn_Sair_Click;
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            ListarLivros();
        }
        private void ListarLivros()
        {
            var formListarLivros = new FormListarLivros(usuarioId);
            formListarLivros.Show();
        }

        private void btn_CadLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro formCadLivro = new FormCadastroLivro(usuarioId);
            formCadLivro.Show();
            this.Hide(); // Esconde a tela principal ao mostrar a nova tela
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo ao clicar no botão "Sair"
        }
    }
}
