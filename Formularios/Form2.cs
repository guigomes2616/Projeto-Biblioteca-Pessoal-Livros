using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormCadastro : Form
    {
        private readonly string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormCadastro()
        {
            InitializeComponent();
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
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "INSERT INTO Usuario (nome_usuario, data_nascimento, email_usuario, nick_name, senha) VALUES (@Nome, @DataNascimento, @Email, @Nickname, @Senha)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Nickname", nickname);
                        command.Parameters.AddWithValue("@Senha", senha);
                        await command.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
