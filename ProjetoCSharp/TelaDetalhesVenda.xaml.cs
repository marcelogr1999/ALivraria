using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Modelos.DAL;
using Modelos;
using Controller;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for TelaDetalhesVenda.xaml
    /// </summary>
    public partial class TelaDetalhesVenda : Window
    {
        public TelaDetalhesVenda(int id)
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Window_PreviewKeyDown);

            VendaController vc = new VendaController();
            Venda v = vc.ListaVendaComItem(id);
            objetosLista(v);

            boxID.Text = v.VendaID.ToString();
            boxValor.Text = v.ValorTotal.ToString();
            boxData.Text = v.VendaDia;
            boxHorario.Text = v.VendaHorario;

        }

        public void objetosLista(Venda v)
        {

            listVendas.ItemsSource = v.ItemVenda;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
    }


}
