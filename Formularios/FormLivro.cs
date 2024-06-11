using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormLivro : Form
    {
        private int usuarioId;
        private MySqlConnection connection;

        public FormLivro(int usuarioId)
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
            btn_Voltar.Click += new EventHandler(btn_Voltar_Click);
            btn_Cadastrar.Click += new EventHandler(btn_Cadastrar_Click);
            this.usuarioId = usuarioId;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var formPrincipal = new FormPrincipal(usuarioId);
            formPrincipal.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeLivro = tb_nomeLivro.Text;
            string autorLivro = tb_autorLivro.Text;
            string anoPublicacaoStr = tb_anoPublicacao.Text;
            int anoPublicacao;
            int generoLivro = cb_Generos.SelectedIndex + 1; // Assume-se que os índices dos gêneros estão de 1 a 13

            if (string.IsNullOrWhiteSpace(nomeLivro) || string.IsNullOrWhiteSpace(autorLivro) || string.IsNullOrWhiteSpace(anoPublicacaoStr) || generoLivro < 1 || generoLivro > 13)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            if (!int.TryParse(anoPublicacaoStr, out anoPublicacao) || anoPublicacao > DateTime.Now.Year)
            {
                MessageBox.Show("Ano de publicação inválido. Por favor, insira um ano válido.");
                return;
            }

            try
            {
                connection.Open();
                string query = "INSERT INTO livro (genero_livro, nome_livro, autor_livro, ano_publicacao) VALUES (@Genero, @Nome, @Autor, @Ano)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Genero", generoLivro);
                command.Parameters.AddWithValue("@Nome", nomeLivro);
                command.Parameters.AddWithValue("@Autor", autorLivro);
                command.Parameters.AddWithValue("@Ano", anoPublicacao);
                command.ExecuteNonQuery();
                MessageBox.Show("Livro cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar livro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void LimparCampos()
        {
            tb_nomeLivro.Text = "";
            tb_autorLivro.Text = "";
            tb_anoPublicacao.Text = "";
            cb_Generos.SelectedIndex = -1;
        }
    }
}
