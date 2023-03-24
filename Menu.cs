using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBiblioteca3
{
    public class Menu
    {
        public static Biblioteca Biblioteca = new Biblioteca();
        public static void mostrarMenu()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("BIBLIOTECA");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Cadastrar Livro");
                Console.WriteLine("3 - Emprestar Livro");
                Console.WriteLine("4 - Devolver Livro");
                Console.WriteLine("5 - Listar todos os livros");
                Console.WriteLine("6 - Listar todas as pessoas cadastradas");
                Console.WriteLine("7 - Listar todos os livros emprestados");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcao > 7 || opcao < 0);

            Cases(opcao);
        }

        public static void Cases(int opcao)
        {

            switch (opcao)
            {
                case 1:
                    Console.Write("Id da Pessoa: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome da Pessoa: ");
                    string nome = Console.ReadLine();
                    Console.Write("CPF da Pessoa: ");
                    string cpf = Console.ReadLine();
                    Console.Write("Telefone da Pessoa: ");
                    string telefone = Console.ReadLine();
                    var inst = new Pessoa(id, nome, cpf, telefone);
                    Biblioteca.CadastrarPessoa(inst);
                    break;

                case 2:
                    Console.Write("Id do Livro: ");
                    int id2 = int.Parse(Console.ReadLine());
                    Console.Write("Nome do Livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor do Livro: ");
                    string autor = Console.ReadLine();
                    Console.Write("Editora do Livro: ");
                    string editora = Console.ReadLine();
                    Console.Write("Quantidade de Livros: ");
                    int quantidadeExemplares = int.Parse(Console.ReadLine());
                    var inst2 = new Livro(id2, titulo, autor, editora, quantidadeExemplares);
                    Biblioteca.CadastrarLivro(inst2);
                    break;

                case 3:
                    Console.Write("Digite o Id da Pessoa: ");
                    int idPessoa = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Id do Livro: ");
                    int idLivro = int.Parse(Console.ReadLine());
                    if (Biblioteca.CaçarPessoa(idPessoa))
                    {
                        Console.Write("Pessoa não cadastrada\n");
                        mostrarMenu();
                    }
                    if (Biblioteca.CaçarLivro(idLivro))
                    {
                        Console.Write("Livro não cadastrado\n");
                        mostrarMenu();
                    }
                    var consultaLivro = Biblioteca.LivroPeloId(idLivro);
                    var consultaPessoa = Biblioteca.PessoaPeloId(idPessoa);
                    Biblioteca.EmprestarLivroBiblioteca(idLivro, idPessoa);
                    Console.Write($"O Livro {consultaLivro.ObterTituloLivro()} foi emprestado para a pessoa {consultaPessoa.ObterNomePessoa()}\n");

                    break;

                case 4:
                    Console.Write("Digite o Id da Pessoa: ");
                    int pessoaDevolver = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Id do Livro: ");
                    int livroDevolver = int.Parse(Console.ReadLine());
                    if (Biblioteca.CaçarPessoa(pessoaDevolver))
                    {
                        Console.Write("Pessoa não cadastrada\n");
                        mostrarMenu();
                    }
                    if (Biblioteca.CaçarLivro(livroDevolver))
                    {
                        Console.Write("Livro não cadastrado\n");
                        mostrarMenu();
                    }
                    var livro = Biblioteca.LivroPeloId(livroDevolver);
                    var pessoa = Biblioteca.PessoaPeloId(pessoaDevolver);
                    Biblioteca.DevolverLivroBiblioteca(livroDevolver, pessoaDevolver);
                    Console.Write($"O Livro {livro.ObterTituloLivro()} que estava com a pessoa {pessoa.ObterNomePessoa()} foi devolvido com sucesso\n");

                    break;

                case 5:
                    List<Livro> livros = Biblioteca.Livros;
                    Biblioteca.ListarLivros(livros);

                    break;
                case 6:
                    List<Pessoa> pessoas = Biblioteca.Pessoas;
                    Biblioteca.ListarPessoas(pessoas);

                    break;
                case 7:
                    List<Pessoa> z = Biblioteca.Pessoas;                    
                    Biblioteca.LivrosEmprestados1(z);

                    break;
            }
            if (opcao != 0)
            {
                mostrarMenu();
            }


        }
    }
}
