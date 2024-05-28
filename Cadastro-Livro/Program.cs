    using System;
    using System.Collections.Generic;
using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MySql.Data;
    using MySql.Data.MySqlClient;

    namespace Cadastro_Livro
    {
        internal class Program
        {
            static MySqlConnection connection;

        static void Main(string[] args)
            {
            connection = GetConnection();
            connection.Open();
            RealizarLogin();

                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            ListarLivros();
                            break;
                        case "2":
                            CadastrarLivro();
                            break;
                    case "X":
                        SairPrograma();
                        Environment.Exit(0);
                        break;

                    default:
                            Console.Write("\nOpção inválida! tente novamente: \n");
                            opcaoUsuario = Console.ReadLine();
                            break;
                    }
                    opcaoUsuario = ObterOpcaoUsuario();
                }
                SairPrograma();
                connection.Close();

                RealizarLogin();
            }
        //----------------------------------------------------------------------------------------------------------------------------------
        public static void RealizarLogin()
        {
            Console.WriteLine("------------ Faça Login para acessar o Programa de Cadastro de Livro ------------\n");

            Console.Write("Digite [1] para se Cadastrar\n");
            Console.Write("Digite [2] para Entrar no programa\n");
            Console.Write("Digite [X] para Sair do programa \n");

            Console.Write("\nInsira a opção desejada: ");

            string opcaoLogin = Console.ReadLine().ToUpper();

            switch (opcaoLogin)
            {
                case "1":
                    CadastrarUsuario();
                    RealizarLogin();
                    break;

                case "2":
                    bool loginSucesso = false;

                    while (!loginSucesso)
                    {
                        if (VerificarLogin() != null)
                        {
                            loginSucesso = true;
                        }
                        else
                        {
                            Console.Write("\nFalha no Login, deseja continuar?(S/N): \n");
                            string resLogin = Console.ReadLine();

                            if (resLogin.ToUpper() == "S")
                            {
                                VerificarLogin();
                            }
                            else if (resLogin.ToUpper() == "N")
                            {
                                RealizarLogin();
                            }
                        }
                    }
                    break;

                case "X":
                    loginSucesso = false;
                    SairPrograma();
                    Environment.Exit(0);
                    break;

                default:
                    while (opcaoLogin != "X" && opcaoLogin != "1" && opcaoLogin != "2")
                    {
                        Console.Write("\nOpcao invalida! tente novamente: ");
                        opcaoLogin = Console.ReadLine();
                    }
                    RealizarLogin();
                    break;
            }
                    connection = GetConnection();
                    connection.Open();
        }
    // -------------------------------------------------------------------------------------------------------------------------------
            public static string ObterOpcaoUsuario()
            {
                Console.Write("------------ Menu de Opcoes ------------\n");

                Console.WriteLine("\nDigite [1] para Listar livros");
                Console.WriteLine("Digite [2] para Inserir novo livro");
                Console.WriteLine("Digite [X] para Sair");
                Console.Write("\nInsira a opcao desejada: ");

                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();

                return opcaoUsuario;
            }

            public static MySqlConnection GetConnection()
            {
                string connectionString = "server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';";
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            // -------------------------------------------------------------------------------------------------------------------------------
            public static Usuario CadastrarUsuario()
            {
                Console.Clear();
                Console.Write("------------ Cadastro de Usuario ------------\n");

                Console.Write("\nDigite o seu Nome completo: ");
                string nomeUser = Console.ReadLine();

                Console.Write("\nDigite a sua Data de Nascimento (Formato: dd/mm/aa): ");
                string datanascimentoUser = Console.ReadLine();

                Console.Write("\nDigite o seu Email: ");
                string emailUser = Console.ReadLine();

                Console.Write("\nDigite como gostaria de ser Chamado(a): ");
                string nickUser = Console.ReadLine();

                Console.Write("\nCrie uma Senha: ");
                string senhaUser = Console.ReadLine();

                Usuario novoUsuario = new Usuario(nomeUser, datanascimentoUser, emailUser, nickUser, senhaUser);    

                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO usuario (nome_usuario, data_nascimento, email_usuario, nick_name, senha) VALUES (@Nome, @DataNascimento, @Email, @Nickname, @Senha)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", novoUsuario.DataNascimento);
                    command.Parameters.AddWithValue("@Email", novoUsuario.useremail);
                    command.Parameters.AddWithValue("@Nickname", novoUsuario.Nickname);
                    command.Parameters.AddWithValue("@Senha", novoUsuario.password);
                    command.ExecuteNonQuery();
                }
                return novoUsuario;
            }
     //----------------------------------------------------------------------------------------------------------------------------
            public static void ListarLivros()
            {
                Console.WriteLine("---------- Lista de seus Livros ---------- \n");

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso.");

                    string query = "SELECT * FROM livro";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Título: {reader.GetString("nome_livro")} | Autor: {reader.GetString("autor_livro")} | Ano de Publicação: {reader.GetInt32("ano_publicacao")} | Gênero: {reader.GetString("genero_livro")}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum livro cadastrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao listar os livros: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
     // --------------------------------------------------------------------------------------------------------------------------------
            public static Livro CadastrarLivro()
            {
                Console.Clear();
                Console.Write("------------ Cadastrar Livro - Genero ------------\n");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.Write("\n{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.WriteLine("\n"); // Pula linha

                Console.Write("Digite o Genero do livro entre as opcoes acima: ");
                int generoLiv = int.Parse(Console.ReadLine());

                while (generoLiv <= 0 || generoLiv > 13)
                {
                    Console.Write("\nOperacao invalida, tente novamente!\n");

                    Console.Write("\nDigite o Genero do livro entre as opcoes acima: ");
                    generoLiv = int.Parse(Console.ReadLine());
                }

                Console.Write("\n------------ Cadastrar Livro - Informacoes ------------\n");

                Console.Write("\nDigite o Titulo do Livro: ");
                string titLiv = Console.ReadLine();

                Console.Write("\nDigite o Autor do Livro: ");
                string autorLiv = Console.ReadLine();

                Console.Write("\nDigite o Ano de lançamento do Livro: ");
                int anoLiv = Convert.ToInt32(Console.ReadLine());

                int anoAtual = DateTime.Now.Year;

                while (anoLiv > anoAtual)
                {
                    Console.Write("\nAno de publicacao invalido, tente novamente! \n");

                    Console.Write("\nDigite o Ano de lançamento do Livro ");
                    anoLiv = int.Parse(Console.ReadLine());
                }

                Livro novoLivro = new Livro((Genero)generoLiv, titLiv, autorLiv, anoLiv);

                Console.Write("\n---------- Livro Cadastrado com Sucesso! ---------- \n");

                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO livro (genero_livro, nome_livro, autor_livro, ano_publicacao) VALUES (@Genero, @Titulo, @Autor, @AnoPubli)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Genero", novoLivro.Genero);
                    command.Parameters.AddWithValue("@Titulo", novoLivro.Titulo);
                    command.Parameters.AddWithValue("@Autor", novoLivro.Autor);
                    command.Parameters.AddWithValue("@AnoPubli", novoLivro.AnoPubli);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("\nLivro cadastrado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nErro ao cadastrar o livro: {ex.Message}");
                    }
                }
                return novoLivro;
            }

        //---------------------------------------------------------------------------------------------------------------------------------------

        public static Login VerificarLogin() // Método para verificar o login
        {
            Console.Clear();
            Console.Write("------------ Login ------------\n");

            Console.Write("\nDigite o seu Email: ");
            string emailLogin = Console.ReadLine();

            Console.Write("Digite a sua Senha: ");
            string senhaLogin = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM usuario WHERE email_usuario = @Email AND senha = @Senha";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", emailLogin);
                    command.Parameters.AddWithValue("@Senha", senhaLogin);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Usuário encontrado
                            string nomeUsuario = reader.GetString("nome_usuario");
                            string dataNascimentoStr = reader.GetString("data_nascimento");
                            DateTime? dataNascimento = null;
                            if (!string.IsNullOrEmpty(dataNascimentoStr))
                            {
                                if (DateTime.TryParseExact(dataNascimentoStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                                {
                                    dataNascimento = parsedDate;
                                }
                                else
                                {
                                    Console.WriteLine("Erro ao converter data de nascimento.");
                                }
                            }
                            string emailUsuario = reader.GetString("email_usuario");
                            string nickName = reader.GetString("nick_name");
                            string senhaUsuario = reader.GetString("senha");

                            return new Usuario(nomeUsuario, dataNascimento?.ToString("yyyy-MM-dd"), emailUsuario, nickName, senhaUsuario);
                        }
                        else
                        {
                            // Usuário não encontrado
                            Console.WriteLine("Email ou senha incorretos.");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar login: {ex.Message}");
                return null;
            }
        }

        public static bool SairPrograma()
            {
                Console.WriteLine("\nObrigado por utilizar o nosso Programa! \nSaindo do programa...\n");
                Thread.Sleep(3000);

                return false;
            }
        }
    }
