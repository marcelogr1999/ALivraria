using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Livro
    {
        public int LivroID { get; set; }

        public string LivroNome { get; set; }

        public int LivroValor { get; set; }

        public string LivroCod { get; set; }       

        public string LivroDescricao { get; set; }
        
        public int GeneroID { get; set; }

        public Genero _Genero { get; set; }

        //public Livro()
        //{
        //    _Genero = new Genero();
        //}

    }

}
