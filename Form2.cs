using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormCadastro : Form
    {
        private MySqlConnection connection;
        public FormCadastro()
        {
            InitializeComponent();
            InitializeComponent();
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string dataNascimento = tb_dataNascimento.Text;
            string email = tb_email.Text;
            string nickname = tb_nickname.Text; // Ajuste aqui
            string senha = tb_senha.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(dataNascimento) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nickname) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                connection.Open();
                string query = "INSERT INTO usuario (nome_usuario, data_nascimento, email_usuario, nick_name, senha) VALUES (@Nome, @DataNascimento, @Email, @Nickname, @Senha)"; // Ajuste aqui
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Nickname", nickname); // Ajuste aqui
                command.Parameters.AddWithValue("@Senha", senha);
                command.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos(); // Limpa os campos após o cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private void LimparCampos()
        {
            tb_nome.Text = "";
            tb_dataNascimento.Text = "";
            tb_email.Text = "";
            tb_nickname.Text = ""; // Ajuste aqui
            tb_senha.Text = "";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormLogin = new FormLogin();
            FormLogin.Show();
        }
    }
}
