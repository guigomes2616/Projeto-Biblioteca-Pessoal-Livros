using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FormularioListarLivro : Form
    {
        private readonly int _usuarioId; // Armazena o ID do usuário
        private readonly string _connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";

        public FormularioListarLivro(int idUsuario)
        {
            InitializeComponent();
            _usuarioId = idUsuario; // Recebe o ID do usuário passado no momento da inicialização

            // Adiciona o evento diretamente no botão
            btn_Voltar.Click += btn_Voltar_Click;

            CarregarLivros(); // Carrega os livros ao inicializar a tela
        }

        // Método para carregar os livros na tabela
        private void CarregarLivros()
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT nome_livro, autor_livro, ano_publicacao FROM Livro WHERE id_usuario = @UsuarioId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioId", _usuarioId);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            ListaLivro.DataSource = dataTable; // ListaLivro é o nome do DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os livros: " + ex.Message);
            }
        }

        // Evento para voltar à tela principal
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var formPrincipal = new FormularioPrincipal(_usuarioId); // Passa o ID do usuário ao formulário principal
            formPrincipal.FormClosed += (s, args) => this.Close(); // Fecha o formulário atual ao fechar o formulário principal
            formPrincipal.Show();
            this.Close(); // Esconde o formulário atual
        }
    }
}
