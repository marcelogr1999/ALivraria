using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemVenda
    {
        public int ItemVendaID { get; set; }
        public int LivroID { get; set; }
        public Livro Livro{ get; set; }
        public Double ItemVendaValor { get; set; }
        public int VendaID { get; set; }
    }
}
