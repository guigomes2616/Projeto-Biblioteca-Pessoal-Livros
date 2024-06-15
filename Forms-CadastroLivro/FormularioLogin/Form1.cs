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
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");

            // Configurações para não permitir maximização
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
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
                var formPrincipal = new FormularioPrincipal(usuarioId.Value);
                formPrincipal.FormClosed += (s, args) => this.Show(); // Mostra o formulário de login quando o principal é fechado
                formPrincipal.Show();
                this.Hide(); // Esconde o formulário atual
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }

        private void btn_cadastrarLogin_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormularioCadastro(this); // Passa a instância atual do Form1 para o FormularioCadastro
            formCadastro.FormClosed += (s, args) => this.Show(); // Mostra o formulário de login quando o cadastro é fechado
            formCadastro.Show();
            this.Hide(); // Esconde o formulário atual
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento vazio, pode ser removido se não for necessário.
        }
    }
}
