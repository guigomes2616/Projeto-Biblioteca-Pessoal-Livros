using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FormularioPrincipal : Form
    {
        private readonly int usuarioId; // Utilize a propriedade readonly para armazenar o ID do usuário
        private readonly MySqlConnection connection;

        public FormularioPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.usuarioId = idUsuario; // Inicialize o ID do usuário
            connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=grupo04; Pwd='';");

            // Adicione eventos aos botões no momento da criação do formulário
            btn_Listar.Click += btn_Listar_Click;
            btn_CadLivro.Click += btn_CadLivro_Click;
            btn_Sair.Click += btn_Sair_Click;
        }

        // Evento para listar livros
        private void btn_Listar_Click(object? sender, EventArgs e)
        {
            ListarLivros();
        }

        // Método para listar livros
        private void ListarLivros()
        {
            var formListarLivros = new FormularioListarLivro(usuarioId);
            formListarLivros.Show();
            this.Close(); // Esconde a tela principal ao mostrar a nova tela
        }

        // Evento para cadastrar livro
        private void btn_CadLivro_Click(object? sender, EventArgs e)
        {
            var formCadLivro = new FormularioCadastroLivro(usuarioId);
            formCadLivro.Show();
            this.Close(); // Esconde a tela principal ao mostrar a nova tela
        }

        // Evento para encerrar a sessão e redirecionar para o login
        private void btn_Sair_Click(object? sender, EventArgs e)
        {
            EncerrarSessao();

            // Redireciona para o formulário de login
            var formLogin = new Form1();
            formLogin.Show();
            this.Hide(); // Esconde a tela principal
        }

        private void EncerrarSessao()
        {
            // Encerra a conexão com o banco de dados
            connection.Close();
            // Adicione outros procedimentos conforme necessário.
        }
    }
}
