using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormCadastroLivro : Form
    {
        private int usuarioId;
        private string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormCadastroLivro(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId; // Recebe o ID do usuário passado no momento da inicialização
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var formPrincipal = new FormPrincipal(usuarioId); // Passa o ID do usuário para a próxima tela
            formPrincipal.Show();
            Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeLivro = tb_nomeLivro.Text.Trim();
            string autorLivro = tb_autorLivro.Text.Trim();
            string anoPublicacaoStr = tb_anoPublicacao.Text.Trim();
            int generoId = cb_Generos.SelectedIndex + 1; // Assume-se que os índices dos gêneros estão de 1 a 13
            int anoPublicacao;

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(nomeLivro) || string.IsNullOrWhiteSpace(autorLivro) || string.IsNullOrWhiteSpace(anoPublicacaoStr) || generoId < 1 || generoId > 13)
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

            // Verificar se o gênero existe na tabela de gêneros
            if (!GeneroExiste(generoId))
            {
                MessageBox.Show("Gênero inválido. Por favor, selecione um gênero válido.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Livro (nome_livro, autor_livro, ano_publicacao) VALUES (@Nome, @Autor, @Ano);";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nomeLivro);
                        command.Parameters.AddWithValue("@Autor", autorLivro);
                        command.Parameters.AddWithValue("@Ano", anoPublicacao);
                        command.ExecuteNonQuery();
                    }

                    int livroId;
                    query = "SELECT LAST_INSERT_ID();";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        livroId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    query = "INSERT INTO LivroGenero (livroId, generoId) VALUES (@Livro, @Genero);";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Livro", livroId);
                        command.Parameters.AddWithValue("@Genero", generoId);
                        command.ExecuteNonQuery();
                    }

                    query = "INSERT INTO UsuarioLivro (usuarioId, livroId) VALUES (@Usuario, @Livro);";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuarioId);
                        command.Parameters.AddWithValue("@Livro", livroId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Livro cadastrado com sucesso!");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar livro: {ex.Message}");
            }
        }

        private bool GeneroExiste(int generoId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Genero WHERE id_genero = @GeneroId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GeneroId", generoId);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar gênero: {ex.Message}");
                return false;
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
