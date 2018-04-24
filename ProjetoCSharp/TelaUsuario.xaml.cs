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
using Modelos;
using Controller;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for TelaUsuario.xaml
    /// </summary>
    public partial class TelaUsuario : Window
    {
        Livro novoLivro = new Livro();

        public TelaUsuario()
        {
            InitializeComponent();           

        }


        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Boolean esc = true;
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    gridConteudo.Children.Clear();
                    gridConteudo.Background = Brushes.Transparent;
                    gridConteudo.Children.Add(new UserControlCadastrarLivro());
                    break;
                case 1:
                    gridConteudo.Children.Clear();
                    gridConteudo.Background = Brushes.Transparent;
                    gridConteudo.Children.Add(new UserControlCadastrarGenero());                    
                    break;
                case 2:
                    gridConteudo.Children.Clear();
                    gridConteudo.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE65100"));
                    gridConteudo.Children.Add(new UserControlListar(esc));
                    break;
                case 3:
                    gridConteudo.Children.Clear();
                    gridConteudo.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF662907"));
                    gridConteudo.Children.Add(new UserControlVender());
                    break;
                case 4:
                    gridConteudo.Children.Clear();
                    gridConteudo.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE65100"));
                    gridConteudo.Children.Add(new UserControlListarVenda());
                    
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TransitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (151 + (40 * index)), 0, 0);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
