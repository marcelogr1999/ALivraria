using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controller
{
    public class GeneroController
    {
        static List<Genero> MeusGeneros = new List<Genero>();
        static int ultimoIdGenero = 0;

        public void CadastrarGenero(Genero novoGenero)
        {
            int idGenero = 0;
            idGenero = ultimoIdGenero + 1;
            ultimoIdGenero = idGenero;

            novoGenero.idGenero = idGenero;
            MeusGeneros.Add(novoGenero);
        }

        public Genero ProcurarGenero(int id)
        {
            Genero g = new Genero();

            foreach (var genero in MeusGeneros)
            {
                if (id==genero.idGenero)
                {
                    g = genero;
                    return genero;
                }
            }

            return null;
        }
        public List<Genero> ListaGeneros()
        {
            return MeusGeneros;
        }
    }
}
