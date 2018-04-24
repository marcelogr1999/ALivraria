using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venda
    {
        
        public int VendaID { get; set; }
        public string VendaDia { get; set; }
        public string VendaHorario { get; set; }
        public Double ValorTotal { get; set; }
        public List<ItemVenda> ItemVenda { get; set; }

        public Venda()
        {
            ItemVenda = new List<ItemVenda>();
        }
    }
}
