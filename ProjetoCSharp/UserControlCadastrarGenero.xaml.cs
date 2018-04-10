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
                g.nomeGenero = boxNomeGenero.Text;

                GeneroController gc = new GeneroController();

                gc.CadastrarGenero(g);

                MessageBox.Show("Cadastrado com sucesso!!!");

                boxNomeGenero.Text = string.Empty;
            }
        }

    }
}
