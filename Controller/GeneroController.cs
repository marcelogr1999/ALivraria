using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Modelos.DAL;

namespace Controller
{
    public class GeneroController
    {
        public void CadastrarGenero(Genero novoGenero)
        {

            Contexto ctx = new Contexto();


            ctx.Generos.Add(novoGenero);
            ctx.SaveChanges();
        }

        public Genero ProcurarGenero(int id)
        {
            Contexto ctx = new Contexto();

            //var l = from x in ctx.Livros
            //        where x.LivroID == id
            //        select x;

            return ctx.Generos.Find(id);
        }

        public Boolean ProcurarGeneroPorNome(string nome)
        {
        
            Contexto ctx = new Contexto();
            Genero g = ctx.Generos.Where(gen => gen.GeneroNome == nome).FirstOrDefault();
            if (g != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Genero> ListaGeneros()
        {
            Contexto ctx = new Contexto();

            return ctx.Generos.ToList();
        }
    }
}
