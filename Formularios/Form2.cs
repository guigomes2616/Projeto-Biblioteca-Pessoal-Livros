using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormCadastro : Form
    {
        private readonly MySqlConnection connection;

        public FormCadastro()
        {
            InitializeComponent();
            // Usando string de conexão segura para o banco de dados MySQL.
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        }

        private async Task CadastrarUsuarioAsync()
        {
            string nome = tb_nome.Text;
            string dataNascimento = tb_dataNascimento.Text;
            string email = tb_email.Text;
            string nickname = tb_nickname.Text;
            string senha = tb_senha.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(dataNascimento) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nickname) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                await connection.OpenAsync();
                string query = "INSERT INTO usuario (nome_usuario, data_nascimento, email_usuario, nick_name, senha) VALUES (@Nome, @DataNascimento, @Email, @Nickname, @Senha)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Nickname", nickname);
                command.Parameters.AddWithValue("@Senha", senha);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        private void LimparCampos()
        {
            tb_nome.Text = "";
            tb_dataNascimento.Text = "";
            tb_email.Text = "";
            tb_nickname.Text = "";
            tb_senha.Text = "";
        }

        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {
            await CadastrarUsuarioAsync();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
