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
using System.Collections.ObjectModel;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for UserControlListar.xaml
    /// </summary>
    public partial class UserControlListar : UserControl
    {
        Boolean esc = new Boolean();

        public UserControlListar(Boolean abc)
        {
            esc = abc;
            InitializeComponent();
            objetosLista();
        }

        public void objetosLista()
        {
            LivroController lvc = new LivroController();
            List<Livro> lLivros = new List<Livro>();

            lLivros = lvc.ListaLivrosGeneros();
            listLivros.ItemsSource = lLivros;
        }

        private void listLivros_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (esc)
            {
                TelaDetalhesEditar tde = new TelaDetalhesEditar(int.Parse(listLivros.SelectedValue.ToString()));
                tde.ShowDialog();
                objetosLista();
            }
        }
    }
}
