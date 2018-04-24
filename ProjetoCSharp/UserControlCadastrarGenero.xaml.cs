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
    /// Interaction logic for UserControlCadastrarGenero.xaml
    /// </summary>
    public partial class UserControlCadastrarGenero : UserControl
    {
        public UserControlCadastrarGenero()
        {
            InitializeComponent();
            Loaded += UserControlCadastrarGenero_Loaded;

        }
        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if ((boxNomeGenero.Text.Equals("")))
            {
                MessageBox.Show("Dados incompletos!!!");
            }
            else
            {
                
                Genero g = new Genero();
                g.GeneroNome = boxNomeGenero.Text.ToUpper();
                GeneroController gc = new GeneroController();
                if (gc.ProcurarGeneroPorNome(g.GeneroNome))
                {
                    MessageBox.Show("Esse gênero já foi cadastrado!!!");
                }
                else
                {
                    gc.CadastrarGenero(g);

                    MessageBox.Show("Cadastrado com sucesso!!!");
                }
                boxNomeGenero.Text = string.Empty;
            }
        }

        private void UserControlCadastrarGenero_Loaded(object sender, RoutedEventArgs e)
        {
            boxNomeGenero.Focus();
        }

    }
}
