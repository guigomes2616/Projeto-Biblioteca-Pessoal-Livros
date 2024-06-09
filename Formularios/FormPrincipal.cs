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
        private MySqlConnection connection;

        public FormPrincipal()
        {
            InitializeComponent();
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
            lab_Listar.Text = "---------- Lista de Seus Livros ---------- \n";

            try
            {
                connection.Open();
                string query = "SELECT * FROM livro WHERE id_usuario = @IdUsuario";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lab_Listar.Text += $"Título: {reader.GetString("nome_livro")} | Autor: {reader.GetString("autor_livro")} | Ano de Publicação: {reader.GetInt32("ano_publicacao")} | Gênero: {reader.GetInt32("genero_livro")}\n";
                        }
                    }
                    else
                    {
                        lab_Listar.Text = "Nenhum livro cadastrado.";
                    }
                }
            }
            catch (Exception ex)
            {
                lab_Listar.Text = $"Erro ao listar os livros: {ex.Message}";
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_CadLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro formCadLivro = new FormCadastroLivro();
            formCadLivro.Show();
            this.Hide(); // Esconde a tela principal ao mostrar a nova tela
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo ao clicar no botão "Sair"
        }
    }
}
