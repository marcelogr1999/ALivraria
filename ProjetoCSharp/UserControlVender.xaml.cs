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
using Controller;
using Modelos;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for UserControlVender.xaml
    /// </summary>
    public partial class UserControlVender : UserControl
    {
        static List<Livro> lLivrosChecked = new List<Livro>();

        public UserControlVender()
        {
            InitializeComponent();
            objetosLista();
        }

        public void objetosLista()
        {
            LivroController lvc = new LivroController();
            List<Livro> lLivros = new List<Livro>();

            lLivros = lvc.ListaLivros();
            listLivros.ItemsSource = lLivros;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox chk = (CheckBox)sender;
            MessageBox.Show(chk.Tag.ToString());

            LivroController lvc = new LivroController();

            lLivrosChecked.Add(lvc.ProcurarLivro(int.Parse(chk.Tag.ToString())));

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            MessageBox.Show(chk.Tag.ToString());

            LivroController lvc = new LivroController();

            lLivrosChecked.Remove(lvc.ProcurarLivro(int.Parse(chk.Tag.ToString())));
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;

            foreach (var livro in lLivrosChecked)
            {
                total += livro.valorLivro;
            }
            MessageBox.Show(total.ToString());
        }
    }
}
