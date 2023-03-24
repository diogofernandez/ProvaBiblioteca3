using System;

namespace ProvaBiblioteca3
{
    public class Biblioteca
    {
        public List<Livro> Livros = new List<Livro>();
        public List<Pessoa> Pessoas = new List<Pessoa>();

        public Biblioteca()
        {
            Livros = new List<Livro>();
            Pessoas = new List<Pessoa>();
        }

        public Boolean CaçarPessoa(int idPessoa)
        {
            var consulta = Pessoas.FirstOrDefault(p => p.ObterIdPessoa() == idPessoa);
            if (consulta != null) return false;
            else return true;
        }
        public void CadastrarPessoa(Pessoa pessoa)
        {
            if (CaçarPessoa(pessoa.ObterIdPessoa()))
            {
                Pessoas.Add(pessoa);
                Console.WriteLine($"\nPessoa {pessoa.ObterNomePessoa()} cadastrada com sucesso!\n");
            }
            else Console.WriteLine("Pessoa já cadastrada");
        }
        public Boolean CaçarLivro(int idLivro)
        {
            var consulta = Livros.FirstOrDefault(p => p.ObterIdLivro() == idLivro);
            if (consulta != null) return false;
            else return true;
        }

        public Livro LivroPeloId(int idLivro)
        {
            var consulta = Livros.FirstOrDefault(p => p.ObterIdLivro() == idLivro);
            if (consulta != null) return consulta;
            return null;
        }

        public Pessoa PessoaPeloId(int idPessoa)
        {
            var consulta = Pessoas.FirstOrDefault(p => p.ObterIdPessoa() == idPessoa);
            if (consulta != null) return consulta;
            return null;
        }
        public void CadastrarLivro(Livro livro)
        {
            if (CaçarLivro(livro.ObterIdLivro()))
            {
                Livros.Add(livro);
                Console.WriteLine($"\nLivro {livro.ObterTituloLivro()} cadastrada com sucesso!\n");
            }
            else Console.WriteLine("\nLivro já cadastrada\n");
        }
        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(x => x.ObterIdLivro() == idLivro);
            livro.EmprestarLivro(1);

            Pessoa pessoas = Pessoas.Find(x => x.ObterIdPessoa() == idPessoa);
            pessoas.AdicionarLivroLista(livro);

        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(x => x.ObterIdLivro() == idLivro);
            livro.DevolverLivro(1);

            Pessoa pessoas = Pessoas.Find(x => x.ObterIdPessoa() == idPessoa);
            pessoas.RemoverLivroLista(idLivro);
        }


        public void ListarLivros(List<Livro> param)
        {
            foreach (var x in param)
            {
                Console.WriteLine(x.ObterTituloLivro());
            }
        }

        public void ListarPessoas(List<Pessoa> param)
        {
            foreach (var x in param)
            {
                Console.WriteLine(x.ObterNomePessoa());
            }
        }

        public void LivrosEmprestados1(List<Pessoa> param)
        {
           
            List<Pessoa> PcomLEmp = new List<Pessoa>();

            foreach (var item in param)
            {
                if (item.ObterQtdLivrosEmprestados() != null)
                {
                    PcomLEmp.Add(item);
                }
                
            }

            Console.WriteLine("Essas pessoas possuem Livros Emprestados:\n");
            foreach (var item in PcomLEmp)
            {
                

                foreach (var item2 in item.ObterQtdLivrosEmprestados()) 
                {
                    Console.WriteLine($"A pessoa: {item.ObterNomePessoa()} possuí o Livro {item2.ObterTituloLivro()} emprestado!\n");
                }
            }


        }
    }
}