using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Cadastro de Livros ------------");

            int opcao;

            while (true)
            {

                Console.WriteLine("\nDigite [1] para Cadastrar um Usuario");
                Console.WriteLine("\nDigite [2] para Cadastrar um Livro");
                Console.WriteLine("\nDigite [3] para Vizualizar Usuarios");
                Console.WriteLine("\nDigite [4] para Vizualizar Livros");
                Console.WriteLine("\nDigite [5] para Vizualizar Livros de Usuarios");
                Console.WriteLine("\nDigite [6] para Sair");
                Console.Write("\nInsira a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao < 1 || opcao > 6 )
                {
                    Console.WriteLine("\nOpcao invalida! Tente novamente");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nCase 1 funcionando");
                        //usuarios.Add(CadastrarUsuario());
                        break;
                    case 2:
                        Console.WriteLine("\nCase 2 funcionando"); 
                        //livros.Add(CadastrarLivro(usuarios));
                        break;
                    case 3:
                        Console.WriteLine("\nCase 3 funcionando");
                        //MostrarUsuarios(usuarios);
                        break;
                    case 4:
                        Console.WriteLine("\nCase 4 funcionando");
                        //MostrarLivros(livros);
                        break;
                    case 5:
                        Console.WriteLine("\nCase 5 funcionando");
                        //VisualizarLivrosDeUsuario(usuarios, livros);
                        break;
                    case 6:
                        Console.WriteLine("\nSaindo...");
                        Console.WriteLine("\n");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
