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


namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for TelaTerminal.xaml
    /// </summary>
    public partial class TelaTerminal : Window
    {
        public TelaTerminal()
        {
            Boolean esc = false;
            InitializeComponent();
            gridConteudo.Children.Clear();
            gridConteudo.Children.Add(new UserControlListar(esc));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }


        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
