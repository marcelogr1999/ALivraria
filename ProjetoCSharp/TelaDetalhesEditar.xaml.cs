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
using Modelos.DAL;
using Controller;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for TelaDetalhesEditar.xaml
    /// </summary>
    public partial class TelaDetalhesEditar : Window
    {
        Livro l = new Livro();

        public TelaDetalhesEditar(int id)
        {           
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Window_PreviewKeyDown);

            GeneroController gc = new GeneroController();
            LivroController lvc = new LivroController();

            l = lvc.ProcurarLivro(id);

            listGeneros.ItemsSource = gc.ListaGeneros();
            listGeneros.SelectedValue = l.GeneroID;
            boxCod.Text = l.LivroCod;
            boxNomeLivro.Text = l.LivroNome;
            boxValor.Text = l.LivroValor.ToString();
            boxDescricao.Text = l.LivroDescricao;
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            btnEditar.IsDefault = false;
            btnSalvar.Visibility = Visibility.Visible;
            btnSalvar.IsDefault = true;
            btnEditar.Visibility = Visibility.Hidden;
            boxCod.IsEnabled = true;
            boxNomeLivro.IsEnabled = true;
            boxValor.IsEnabled = true;
            boxDescricao.IsEnabled = true;
            listGeneros.IsEnabled = true;

            boxCod.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF9800"));
            boxNomeLivro.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF9800"));
            boxValor.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF9800"));
            listGeneros.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF9800"));
            boxDescricao.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF9800"));
            btnEditar.Visibility = Visibility.Hidden;

            boxNomeLivro.Focus();

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if ((boxNomeLivro.Text.Equals("")) || (boxCod.Text.Equals("") || (boxValor.Text.Equals("")) || (listGeneros.SelectedValue == null) || (boxDescricao.Text.Equals(""))))
            {
                MessageBox.Show("Dados incompletos!!!");
            }
            else
            {
                try
                {
                    LivroController lvc = new LivroController();
                    l.LivroValor = int.Parse(boxValor.Text);
                    l.LivroCod = boxCod.Text;
                    l.LivroNome = boxNomeLivro.Text.ToUpper();
                    l.LivroDescricao = boxDescricao.Text;
                    int pesquisa = int.Parse(listGeneros.SelectedValue.ToString());
                    l.GeneroID = pesquisa;

                    if (lvc.ProcurarLivroPorNome(l.LivroNome, l.LivroID))
                    {
                        MessageBox.Show("Esse livro já foi cadastrado!!!");
                    }
                    else
                    {
                        lvc.EditarLivro(l);
                        MessageBox.Show("Editado com sucesso!!!");
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Dado informado no formato incorreto!!!");
                }
            }
        }

        private void TelaDetalhesEditar_Loaded(object sender, RoutedEventArgs e)
        {
            boxNomeLivro.Focus();
        }


        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }


    }
}
