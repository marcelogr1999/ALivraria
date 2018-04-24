using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Modelos.DAL;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace Controller
{
    public class LivroController
    {

        public void CadastrarLivro(Livro novoLivro)
        {
            Contexto ctx = new Contexto();

            ctx.Livros.Add(novoLivro);
            ctx.SaveChanges();
            
        }

        public List<Livro> ListaLivros()
        {
            Contexto ctx = new Contexto();


            //return ctx.Livros.Where(l => l.LivroNome.StartsWith("m")).ToList();
            return ctx.Livros.ToList();
        }

        public List<Livro> ListaLivrosGeneros()
        {
            Contexto ctx = new Contexto();
            
            var result = ctx.Livros
                          .OrderBy(l => l.LivroNome)
                          .Include(g => g._Genero)
                          .ToList();

            return result;
        }

        public Livro ProcurarLivro(int id)
        {
            Contexto ctx = new Contexto();

            //var l = from x in ctx.Livros
            //        where x.LivroID == id
            //        select x;

            //return ctx.Livros.Find(id);

            var result = ctx.Livros
                          .Where(i => i.LivroID == id)
                          .Include(g => g._Genero)
                          .FirstOrDefault();
            return result;

        }

        public Boolean ProcurarLivroPorNome(string nome, int id)
        {
            Contexto ctx = new Contexto();

            Livro l = ctx.Livros.Where(liv => liv.LivroNome == nome).FirstOrDefault();

            if ((l != null)&&(l.LivroID!=id)){
                return true;
            }
            else
            {
                return false;
            }

        }

        public void EditarLivro(Livro l)
        {
            Contexto ctx = new Contexto();
            Livro livroPesquisado = new Livro();
            livroPesquisado = ctx.Livros.Find(l.LivroID);

            if (livroPesquisado != null)
            {
                ctx.Entry(livroPesquisado).CurrentValues.SetValues(l);
                ctx.SaveChanges();
            }
        }

        //public void ApagarLivro(int id)
        //{
        //    Contexto ctx = new Contexto();
        //
        //    Livro l = ctx.Livros.Find(id);
        //
        //    ctx.Entry(l).State =
        //        System.Data.Entity.EntityState.Deleted;
        //
        //    ctx.SaveChanges();
        //}

    }
    
}
