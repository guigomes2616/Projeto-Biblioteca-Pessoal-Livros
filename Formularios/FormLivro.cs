using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormLivro : Form
    {
        private int usuarioId;
        private readonly MySqlConnection connection;

        public FormLivro(int usuarioId)
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
            this.usuarioId = usuarioId;
            btn_Voltar.Click += Btn_Voltar_Click;
            btn_Cadastrar.Click += Btn_Cadastrar_Click;
        }

        private async void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
            var formPrincipal = new FormPrincipal(usuarioId);
            formPrincipal.Show();
        }

        private async void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeLivro = tb_nomeLivro.Text.Trim();
            string autorLivro = tb_autorLivro.Text.Trim();
            string anoPublicacaoStr = tb_anoPublicacao.Text.Trim();
            int anoPublicacao;

            if (string.IsNullOrWhiteSpace(nomeLivro) || string.IsNullOrWhiteSpace(autorLivro) || string.IsNullOrWhiteSpace(anoPublicacaoStr))
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
                await connection.OpenAsync();

                // Inserir livro na tabela Livro
                string query = "INSERT INTO Livro (nome_livro, autor_livro, ano_publicacao, id_usuario) VALUES (@Nome, @Autor, @Ano, @UsuarioId)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nomeLivro);
                    command.Parameters.AddWithValue("@Autor", autorLivro);
                    command.Parameters.AddWithValue("@Ano", anoPublicacao);
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    await command.ExecuteNonQueryAsync();
                }

                MessageBox.Show("Livro cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar livro: {ex.Message}");
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        private void LimparCampos()
        {
            tb_nomeLivro.Text = "";
            tb_autorLivro.Text = "";
            tb_anoPublicacao.Text = "";
        }
    }
}
