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
    /// Interaction logic for UserControlCadastrarLivro.xaml
    /// </summary>
    public partial class UserControlCadastrarLivro : UserControl
    {
        public UserControlCadastrarLivro()
        {
            InitializeComponent();
            objetosLista();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if ((boxNomeLivro.Text.Equals("")) || (boxCod.Text.Equals("") || (boxValor.Text.Equals("")) || (listGeneros.SelectedValue==null)))
            {
                MessageBox.Show("Dados incompletos!!!");
            }
            else
            {
                Livro l = new Livro();
                LivroController lvc = new LivroController();
                l.nomeLivro = boxNomeLivro.Text;
                l.cod = boxCod.Text;
                l.valorLivro = int.Parse(boxValor.Text);
                l.livroIdGenero = int.Parse(listGeneros.SelectedValue.ToString());     

                lvc.CadastrarLivro(l);

                MessageBox.Show("Cadastrado com sucesso!!!");

                boxNomeLivro.Text = string.Empty;
                boxCod.Text = string.Empty;
            }
        }

        public void objetosLista()
        {
            GeneroController gc = new GeneroController();
            List<Genero> lGeneros = new List<Genero>();

            lGeneros = gc.ListaGeneros();
            listGeneros.ItemsSource = lGeneros;
        }


    }
}
