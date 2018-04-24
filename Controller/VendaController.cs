using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Modelos.DAL;
using System.Data.Entity;

namespace Controller
{
    public class VendaController
    {

        public void CadastrarVenda(Venda novoVenda)
        {
            double total = 0;
            LivroController lvc = new LivroController();
            Contexto ctx = new Contexto();       

            for (int i = 0; i < novoVenda.ItemVenda.Count; i++)
            {
                total += lvc.ProcurarLivro(novoVenda.ItemVenda[i].LivroID).LivroValor;
            }
            novoVenda.ValorTotal = total;
            novoVenda.VendaDia = (DateTime.Now.Date.ToString("d"));
            novoVenda.VendaHorario = (DateTime.Now.ToString("HH:mm"));
            ctx.Vendas.Add(novoVenda);
            ctx.SaveChanges();
        }

        public List<Venda> ListaVenda()
        {

            Contexto ctx = new Contexto();

            return ctx.Vendas.ToList();
        }

        public Venda ListaVendaComItem(int id)
        {
            Contexto ctx = new Contexto();
            LivroController lvc = new LivroController();

            var venda = ctx.Vendas
                .Where(v => v.VendaID == id)               
                .FirstOrDefault();

            var itens = ctx.ItensVenda
                .Where(iv => iv.VendaID == id)
                .ToList();


            for (int i = 0; i < itens.Count; i++)
            {
                itens[i].Livro = lvc.ProcurarLivro(itens[i].LivroID);
                if (venda.ItemVenda[i].LivroID == itens[i].LivroID)
                {
                    venda.ItemVenda[i].Livro = itens[i].Livro;
                    venda.ItemVenda[i].ItemVendaID = itens[i].ItemVendaID;
                    venda.ItemVenda[i].VendaID = itens[i].VendaID;
                }
                else
                {
                    venda.ItemVenda.Add(itens[i]);
                }
            }
            

            return venda;
        }
    }
}
