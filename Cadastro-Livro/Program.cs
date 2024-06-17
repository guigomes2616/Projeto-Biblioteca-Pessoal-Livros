using System;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro_Livro
{
    class Program
    {
        private static readonly MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; Database=grupo04; uid=root; Pwd='';");
        private static int usuarioId;

        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----- Bem-vindo ao sistema de login! -----");
                Console.WriteLine("\nAperte [1] para Entrar");
                Console.WriteLine("Aperte [2] para Cadastrar");
                Console.Write("\nEscolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    await RealizarLogin();
                }
                else if (escolha == "2")
                {
                    await RealizarCadastro();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                }
            }
        }

        private static async Task RealizarLogin()
        {
            Console.Clear();
            Console.Write("----- Tela de Login -----\n");
            Console.Write("\nDigite seu email: ");
            string email = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            int? usuarioIdTemp = await VerificarLoginAsync(email, senha);
            if (usuarioIdTemp.HasValue)
            {
                Console.WriteLine("\nLogin realizado com sucesso! Aguarde um momento...");
                usuarioId = usuarioIdTemp.Value;
                await Task.Delay(2000);  // Espera 2 segundos antes de prosseguir
                await MostrarTelaPrincipal();
            }
            else
            {
                Console.WriteLine("\nEmail ou senha incorretos. Tente novamente.");
                await Task.Delay(5000);  // Espera 5 segundos antes de prosseguir
            }
        }

        private static async Task MostrarTelaPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----- Tela Principal: -----");
                Console.WriteLine("\nAperte [1] para Listar Livros");
                Console.WriteLine("Aperte [2] para Cadastrar Livro");
                Console.WriteLine("Aperte [3] para Sair");
                Console.Write("\nEscolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    await ListarLivros();
                }
                else if (escolha == "2")
                {
                    await CadastrarLivro();
                }
                else if (escolha == "3")
                {
                    EncerrarSessao();
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                }
            }
        }

        private static async Task ListarLivros()
        {
            Console.Clear();
            try
            {
                await connection.OpenAsync();
                string query = "SELECT nome_livro, autor_livro, ano_publicacao FROM Livro WHERE id_usuario = @UsuarioId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        Console.WriteLine("Lista de Livros:");
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                Console.WriteLine($"Nome: {reader.GetString(0)}, Autor: {reader.GetString(1)}, Ano: {reader.GetInt32(2)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum livro encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar livros: {ex.Message}");
            }
            finally
            {
                await connection.CloseAsync();
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar à tela principal...");
            Console.ReadKey();
        }

        private static async Task CadastrarLivro()
        {
            Console.Clear();
            Console.WriteLine("----- Tela Cadastro de Livros: -----");
            Console.Write("\nDigite o nome do livro: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o ano de publicação: ");
            if (!int.TryParse(Console.ReadLine(), out int ano))
            {
                Console.WriteLine("\nAno inválido. Tente novamente...");
                await Task.Delay(5000);  // Espera 5 segundos antes de prosseguir
                return;
            }

            try
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Livro (nome_livro, autor_livro, ano_publicacao, id_usuario) VALUES (@Nome, @Autor, @Ano, @UsuarioId)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Ano", ano);
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    int result = await command.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        Console.WriteLine("\nLivro cadastrado com sucesso! Aguarde um momento...");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao cadastrar o livro. Tente novamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar livro: {ex.Message}");
            }
            finally
            {
                await connection.CloseAsync();
            }

            await Task.Delay(5000);  // Espera 5 segundos antes de prosseguir
        }

        private static async Task RealizarCadastro()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("----- Tela de Cadastro de Usuario ----- \n");
                Console.Write("\nDigite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite seu email: ");
                string email = Console.ReadLine();

                Console.Write("Digite seu nick: ");
                string nick = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
                string dataNascimento = Console.ReadLine();

                bool sucesso = await CadastrarUsuarioAsync(nome, email, nick, senha, dataNascimento);
                if (sucesso)
                {
                    Console.WriteLine("\nCadastro realizado com sucesso! Aguarde um momento... ");
                    await Task.Delay(5000);  // Espera 5 segundos antes de prosseguir
                    break;
                }
                else
                {
                    Console.WriteLine("Erro ao cadastrar. Tente novamente...");
                    await Task.Delay(5000);  // Espera 5 segundos antes de prosseguir
                }
            }
        }

        private static async Task<int?> VerificarLoginAsync(string email, string senha)
        {
            try
            {
                await connection.OpenAsync();
                string query = "SELECT id_usuario FROM Usuario WHERE email_usuario = @Email AND senha = @Senha";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    var result = await command.ExecuteScalarAsync();
                    return result == null ? (int?)null : Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar login: {ex.Message}");
                return null;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        private static async Task<bool> CadastrarUsuarioAsync(string nome, string email, string nick, string senha, string dataNascimento)
        {
            try
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Usuario (nome_usuario, email_usuario, nick_name, senha, data_nascimento) VALUES (@Nome, @Email, @Nick, @Senha, @DataNascimento)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Nick", nick);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento);

                    int result = await command.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar usuário: {ex.Message}");
                return false;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        private static void EncerrarSessao()
        {
            Console.Clear();
            Console.WriteLine("Sessão encerrada. Redirecionando para a tela de login...");
            // Outros procedimentos conforme necessário
        }
    }
}
