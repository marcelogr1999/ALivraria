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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modelos;
using Controller;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for UserControlListarVenda.xaml
    /// </summary>
    public partial class UserControlListarVenda : UserControl
    {
        public UserControlListarVenda()
        {
            InitializeComponent();
            objetosLista();
        }

        private void objetosLista()
        {
            VendaController vc = new VendaController();
            List<Venda> lVendas = new List<Venda>();

            lVendas = vc.ListaVenda();
            listVendas.ItemsSource = lVendas;
        }

        private void listVendas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TelaDetalhesVenda tde = new TelaDetalhesVenda(int.Parse(listVendas.SelectedValue.ToString()));
            tde.ShowDialog();
            objetosLista();
        }
    }
}
