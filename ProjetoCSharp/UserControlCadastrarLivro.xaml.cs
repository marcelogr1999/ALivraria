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
            Loaded += UserControlCadastrarLivro_Loaded;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if ((boxNomeLivro.Text.Equals("")) || (boxCod.Text.Equals("") || (boxValor.Text.Equals("")) || 
            (listGeneros.SelectedValue==null) || (boxDescricao.Text.Equals(""))))
            {
                MessageBox.Show("Dados incompletos!!!");
            }
            else
            {
                try
                {
                    Livro l = new Livro();
                    LivroController lvc = new LivroController();
                    GeneroController gc = new GeneroController();
                    l.LivroValor = int.Parse(boxValor.Text);
                    l.LivroCod = boxCod.Text;
                    l.LivroNome = boxNomeLivro.Text.ToUpper();
                    l.LivroDescricao = boxDescricao.Text;
                    int pesquisa = int.Parse(listGeneros.SelectedValue.ToString());
                    //MessageBox.Show(pesquisa.ToString());
                    l.GeneroID = pesquisa;
                    //l._Genero = gc.ProcurarGenero(pesquisa);

                    if (lvc.ProcurarLivroPorNome(l.LivroNome, 0))
                    {
                        MessageBox.Show("Esse livro já foi cadastrado!!!");
                    }
                    else
                    {
                        lvc.CadastrarLivro(l);
                        MessageBox.Show("Cadastrado com sucesso!!!");

                    }
                    listGeneros.SelectedIndex = -1;
                    boxNomeLivro.Text = string.Empty;
                    boxCod.Text = string.Empty;
                    boxValor.Text = string.Empty;
                    boxDescricao.Text = string.Empty;
                    boxNomeLivro.Focus();
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Dado informado no formato incorreto!!!");
                }
            }
        }

        public void objetosLista()
        {
            GeneroController gc = new GeneroController();
            List<Genero> lGeneros = new List<Genero>();

            lGeneros = gc.ListaGeneros();
            listGeneros.ItemsSource = lGeneros;
        }

        private void UserControlCadastrarLivro_Loaded(object sender, RoutedEventArgs e)
        {
            boxNomeLivro.Focus();
        }


    }
}
