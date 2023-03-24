using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBiblioteca3
{
    public class Pessoa
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string Telefone { get; set; }

        private List<Livro> LivrosEmprestados = new List<Livro>();


        
        public List<Livro> ObterQtdLivrosEmprestados()
        {
            List<Livro> qtdLivrosEmpresatos = LivrosEmprestados;
            return qtdLivrosEmpresatos;
        }
        public int ObterIdPessoa()
        {
            int idPessoa = Id;
            return idPessoa;
        }

        public string ObterNomePessoa()
        {
            string nomePessoa = Nome;
            return nomePessoa;
        }
        public string ObterCpfPessoa()
        {
            string CpfPessoa = Cpf;
            return CpfPessoa;
        }
        public string ObterTelefonePessoa()
        {
            string telefonePessoa = Telefone;
            return telefonePessoa;
        }

        public Pessoa(int id, string nome, string cpf, string telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            LivrosEmprestados = new List<Livro>();

        }


        public void AdicionarLivroLista(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        public string RemoverLivroLista(int idLivro)
        {
            Livro livro = LivrosEmprestados.Find(l => l.ObterIdLivro() == idLivro);
            if (livro == null) return "não existe esse livro";
            LivrosEmprestados.Remove(livro);
            return "Livro removido";
        }

        public List<Pessoa> ObeterLivrosEmprestados(List<Pessoa> p)
        {

            List<Pessoa> PcomLEmp = p;//.LivrosEmprestados.SelectMany(LivrosEmprestados => LivrosEmprestados).where(LivrosEmprestados.Count != 0);
            
            foreach (var item in p)
            {
                if (LivrosEmprestados != null || LivrosEmprestados.Count != 0 )
                {
                    PcomLEmp.Add(item);
                }
                Console.WriteLine(item);
            }

            return PcomLEmp;
        }

    }
}
                

                   

        


 


            
        

