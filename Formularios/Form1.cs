using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        private readonly MySqlConnection connection;

        public FormLogin()
        {
            InitializeComponent();
            // Usando string de conexão segura para o banco de dados MySQL.
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        }

        private async Task<bool> VerificarLoginAsync(string email, string senha)
        {
            try
            {
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM usuario WHERE email_usuario = @Email AND senha = @Senha";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                var result = await command.ExecuteScalarAsync();
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar login: {ex.Message}");
                return false;
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

            if (await VerificarLoginAsync(tb_emailLogin.Text, tb_senhaLogin.Text))
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                int usuarioId = 1;
                var formPrincipal = new FormPrincipal(usuarioId);
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
            var formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}