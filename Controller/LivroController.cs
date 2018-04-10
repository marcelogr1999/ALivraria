using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Collections.ObjectModel;

namespace Controller
{
    public class LivroController
    {
        static List<Livro> MeusLivros = new List<Livro>();
        static int ultimoIdLivro = 0;

        public void CadastrarLivro(Livro novoLivro)
        {
            int idLivro = 0;
            idLivro = ultimoIdLivro + 1;
            ultimoIdLivro = idLivro;

            novoLivro.idLivro = idLivro;

            MeusLivros.Add(novoLivro);
        }

        public List<Livro> ListaLivros()
        {
            return MeusLivros;
        }

        public Livro ProcurarLivro(int id)
        {
            Livro l = new Livro();

            foreach (var Livro in MeusLivros)
            {
                if (id == Livro.idLivro)
                {
                    l = Livro;
                    return Livro;
                }
            }

            return null;
        }
    }
    
}
