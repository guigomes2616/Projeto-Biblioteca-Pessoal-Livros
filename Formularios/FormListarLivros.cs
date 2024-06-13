using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class FormListarLivros : Form
    {
        private int usuarioId;
        private readonly string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormListarLivros(int id_usuario)
        {
            InitializeComponent();
            this.usuarioId = id_usuario; // Armazena o ID do usuário passado no momento da inicialização
            CarregarLivros();
            btn_Voltar.Click += Btn_Voltar_Click;
        }

        private async void CarregarLivros()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT nome_livro, autor_livro, ano_publicacao FROM Livro WHERE id_usuario = @UsuarioId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);
                            dataGridViewLivros.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os livros: " + ex.Message);
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            var formPrincipal = new FormPrincipal(usuarioId);
            formPrincipal.Show();
            Close();
        }
    }
}
