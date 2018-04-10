using System;
using System.Collections.Generic;
using Modelos;
using System.Linq;

namespace Controller
{
    public class UsuarioController
    {
        static Usuario MeuUsuario = new Usuario {nomeUsuario = "usuariopadrao", senha = "livraria"};
               

        public string PesquisarUsuario(string usuarioNome, string usuarioSenha)
        {
            Usuario usuarioPesquisado = new Usuario();

            // var Pesquisa =
            //   from Usuario usuario in MeuUsuario
            //   where cliente.PessoaID.Equals(idCliente)
            //    select cliente;

            if (usuarioNome.Equals(MeuUsuario.nomeUsuario) && (usuarioSenha.Equals(MeuUsuario.senha)))
            {
                return "correto";
            }
            else
            {
                return "errado";  
            }
   
        }
    }
}