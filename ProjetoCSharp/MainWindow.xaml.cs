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
            this.boxNome.Focus();
            InicializarGenero();
            InicializarLivro();
            InicializarUsuario();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            nome = boxNome.Text;
            senha = boxSenha.Password;

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
            if (lvc.ListaLivros().Count==0)
            {
                Livro teste = new Livro();
                teste.LivroNome = "TARTARUGA";
                teste.LivroCod = "100";
                teste.GeneroID = 1;
                teste.LivroDescricao = "A história da tartaruga que se perdeu";
                //teste._Genero = gc.ProcurarGenero(1);
                teste.LivroValor = 40;
                lvc.CadastrarLivro(teste);
            }
        }

        private void InicializarGenero()
        {
            GeneroController gc = new GeneroController();
            if (gc.ListaGeneros().Count==0)
            {
                Genero teste = new Genero();
                teste.GeneroNome = "TERROR";
                gc.CadastrarGenero(teste);
            }
        }

        private void InicializarUsuario()
        {
            UsuarioController uc = new UsuarioController();
            if(uc.ListaUsuario()==null)
            {
                Usuario usuario = new Usuario();

                usuario.UsuarioNome = "usuariopadrao";
                usuario.UsuarioSenha = "livraria";
                uc.CadastrarUsuario(usuario);

            }
        }

        private void btnTerminal_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            TelaTerminal tt = new TelaTerminal();
            tt.Show();

        }
    }
        
}
