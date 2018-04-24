using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Modelos.DAL;

namespace Controller
{
    public class UsuarioController
    {
        //public void CadastrarUsuario(Usuario novoUsuario)
        //{
        //
        //    Contexto ctx = new Contexto();
        //
        //    ctx.Usuarios.Add(novoUsuario);
        //    ctx.SaveChanges();
        //}


        public string PesquisarUsuario(string usuarioNome, string usuarioSenha)
        {
            Contexto ctx = new Contexto();
            Usuario usuarioPesquisado = new Usuario();

            //var l = from x in ctx.Livros
            //        where x.LivroID == id
            //        select x;

            usuarioPesquisado = ctx.Usuarios.FirstOrDefault();


            // var Pesquisa =
            //   from Usuario usuario in MeuUsuario
            //   where cliente.PessoaID.Equals(idCliente)
            //    select cliente;

            if (usuarioNome.Equals(usuarioPesquisado.UsuarioNome) && (usuarioSenha.Equals(usuarioPesquisado.UsuarioSenha)))
            {
                return "correto";
            }
            else
            {
                return "errado";  
            }
   
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            Contexto ctx = new Contexto();

            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }

        public Usuario ListaUsuario()
        {
            Contexto ctx = new Contexto();

            return ctx.Usuarios.ToList().FirstOrDefault();
        }
    }
}