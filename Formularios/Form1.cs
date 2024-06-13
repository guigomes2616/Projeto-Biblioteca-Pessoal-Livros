using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormLogin()
        {
            InitializeComponent();
        }

        private async Task<bool> VerificarLoginAsync(string email, string senha)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT COUNT(*) FROM Usuario WHERE email_usuario = @Email AND senha = @Senha";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        var result = await command.ExecuteScalarAsync();
                        return Convert.ToInt32(result) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btn_entrarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_emailLogin.Text) || string.IsNullOrWhiteSpace(tb_senhaLogin.Text))
            {
                MessageBox.Show("Por favor, insira um email e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (await VerificarLoginAsync(tb_emailLogin.Text, tb_senhaLogin.Text))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cadastrarLogin_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }
    }
}
