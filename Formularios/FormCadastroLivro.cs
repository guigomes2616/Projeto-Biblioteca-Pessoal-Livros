using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormCadastroLivro : Form
    {
        private MySqlConnection connection;

        public FormCadastroLivro()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeLivro = tb_nomeLivro.Text;
            string autorLivro = tb_autorLivro.Text;
            string anoPublicacaoStr = tb_anoPublicacao.Text;
            int generoLivro = cb_Generos.SelectedIndex + 1; // Assume-se que os índices dos gêneros estão de 1 a 13
            int anoPublicacao;

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(nomeLivro) || string.IsNullOrWhiteSpace(autorLivro) || string.IsNullOrWhiteSpace(anoPublicacaoStr) || generoLivro < 1 || generoLivro > 13)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            // Verificação se o ano de publicação é válido
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
            tb_nomeLivro.Clear();
            tb_autorLivro.Clear();
            tb_anoPublicacao.Clear();
            cb_Generos.SelectedIndex = -1; // Reseta o ComboBox
        }

        private void tb_AnoPublicacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
