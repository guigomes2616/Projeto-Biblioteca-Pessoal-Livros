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
        private MySqlConnection connection;
        public FormLogin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        }

        private void btn_cadastrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            var formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private bool VerificarLogin(string email, string senha)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM usuario WHERE email_usuario = @Email AND senha = @Senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.Read(); // Se houver um registro, as credenciais são válidas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar login: {ex.Message}");
                return false; // Em caso de erro, retorna falso
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_entrarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_emailLogin.Text) || string.IsNullOrWhiteSpace(tb_senhaLogin.Text))
            {
                MessageBox.Show("Por favor, insira um email e senha.");
                return;
            }

            if (VerificarLogin(tb_emailLogin.Text, tb_senhaLogin.Text))
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                FormPrincipal FormPrincipal = new FormPrincipal();
                FormPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }
    }
}
