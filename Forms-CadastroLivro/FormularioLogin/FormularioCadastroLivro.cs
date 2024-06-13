using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FormularioCadastroLivro : Form
    {
        private readonly MySqlConnection connection;
        private readonly int usuarioId;

        public FormularioCadastroLivro(int idUsuario)
        {
            InitializeComponent();
            this.usuarioId = idUsuario;
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");

            btn_Cadastrar.Click += btn_Cadastrar_Click;
            btn_Voltar.Click += btn_Voltar_Click;
        }

        // Evento para cadastrar livro
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeLivro = tb_nomeLivro.Text;
                string autorLivro = tb_autorLivro.Text;
                int anoPublicacao = Convert.ToInt32(tb_anoPublicacao.Text);

                if (string.IsNullOrEmpty(nomeLivro) || string.IsNullOrEmpty(autorLivro) || string.IsNullOrEmpty(tb_anoPublicacao.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                connection.Open();
                string query = "INSERT INTO Livro (nome_livro, autor_livro, ano_publicacao, id_usuario) VALUES (@NomeLivro, @AutorLivro, @AnoPublicacao, @UsuarioId)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeLivro", nomeLivro);
                    command.Parameters.AddWithValue("@AutorLivro", autorLivro);
                    command.Parameters.AddWithValue("@AnoPublicacao", anoPublicacao);
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Livro cadastrado com sucesso!");
                LimparCampos(); // Limpa os campos após o cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o livro: " + ex.Message);
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
        }

        // Evento para voltar à tela principal
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var formPrincipal = new FormularioPrincipal(usuarioId); // Passa o ID do usuário ao formulário principal
            formPrincipal.Show();
            Close(); // Fecha o formulário atual
        }
    }
}
