using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBiblioteca3
{
    public class Livro
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Editora { get; set; }
        private int QuantidadeExemplares { get; set; }

        public int ObterIdLivro()
        {
            int id = Id;
            return id;
        }

        public string ObterTituloLivro()
        {
            string tituloLivro = Titulo;
            return tituloLivro;
        }

        public string ObterAutorLivro()
        {
            string autorLivro = Autor;
            return autorLivro;
        }
        public string ObterEditoraLivro()
        {
            string editoraLivro = Editora;
            return editoraLivro;
        }

        public int ObterQuantidadeExemplares()
        {
            int qtdExemplaresLivro = QuantidadeExemplares;
            return qtdExemplaresLivro;
        }

        public Livro(int id, string titulo, string autor, string editora, int quantidadeExemplares)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = quantidadeExemplares;
        }


        public void EmprestarLivro(int quantidadeEmprestada)
        {
            if (quantidadeEmprestada > 0 && quantidadeEmprestada <= QuantidadeExemplares)
            {
                QuantidadeExemplares -= quantidadeEmprestada;
                Console.WriteLine($"Livro emprestado com sucesso! Restam {QuantidadeExemplares} exemplares.");
            }
            else
            {
                Console.WriteLine("Não é possível emprestar essa quantidade de exemplares.");
            }
        }
        public void DevolverLivro(int quantidadeDevolvida)
        {
            if (quantidadeDevolvida > 0)
            {
                QuantidadeExemplares += quantidadeDevolvida;
                Console.WriteLine($"Livro devolvido com sucesso! Agora temos {QuantidadeExemplares} exemplares disponíveis.");
            }
            else
            {
                Console.WriteLine("A quantidade devolvida precisa ser maior que zero.");
            }
        }

       /* public string ObterNomeLivro(Livro l)
        {
            return Titulo;
        }*/
    }
}
