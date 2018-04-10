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
using System.Collections.ObjectModel;

namespace ProjetoCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nome;
        string senha;   


        public MainWindow()
        {
            InitializeComponent();
            InicializarGenero();
            InicializarLivro();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            nome = boxNome.Text;
            senha = boxSenha.Text;

            UsuarioController uc = new UsuarioController();

            string result = uc.PesquisarUsuario(nome, senha);

            if (result.Equals("correto"))
            {
                TelaUsuario tu = new TelaUsuario();
                this.Hide();
                tu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta");         
            }


        }

        private void InicializarLivro()
        {
            LivroController lvc = new LivroController();

            Livro teste = new Livro();

            teste.nomeLivro = "Tartaruga";
            teste.cod = "100";
            teste.livroIdGenero = 1;
            teste.valorLivro = 40;
            lvc.CadastrarLivro(teste);
        }

        private void InicializarGenero()
        {
            GeneroController gc = new GeneroController();

            Genero teste = new Genero();

            teste.nomeGenero = "Terror";

            gc.CadastrarGenero(teste);
        }

     
    }
        
}
