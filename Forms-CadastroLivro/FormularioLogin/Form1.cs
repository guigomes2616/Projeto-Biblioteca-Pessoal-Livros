using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormularioLogin
{
    public partial class Form1 : Form
    {
        private readonly MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=192.168.8.10; port=3306; Database=grupo04; uid=grupo04; Pwd='password';");
        }

        private async Task<int?> VerificarLoginAsync(string email, string senha)
        {
            try
            {
                await connection.OpenAsync();
                string query = "SELECT id_usuario FROM usuario WHERE email_usuario = @Email AND senha = @Senha";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                var result = await command.ExecuteScalarAsync();
                return result == null ? (int?)null : Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar login: {ex.Message}");
                return null;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        private async void btn_entrarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_emailLogin.Text) || string.IsNullOrWhiteSpace(tb_senhaLogin.Text))
            {
                MessageBox.Show("Por favor, insira um email e senha.");
                return;
            }

            int? usuarioId = await VerificarLoginAsync(tb_emailLogin.Text, tb_senhaLogin.Text);
            if (usuarioId.HasValue)
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                var formPrincipal = new FormularioPrincipal(usuarioId.Value);
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }

        private void btn_cadastrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCadastro = new FormularioCadastro();
            formCadastro.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento vazio, pode ser removido se não for necessário.
        }
    }
}
