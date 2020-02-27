using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Aplicacao;
using Cadastro.Dominio;

namespace UI.Dos
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var UsuarioAplicacao = new UsuarioAplicacao();

            ////Console.WriteLine("Digite o nome do usuario: ");
            ////string nome = Console.ReadLine();

            ////Console.WriteLine("Digite o data do usuario: ");
            ////string data = Console.ReadLine();

            ////Console.WriteLine("Digite o email do usuario: ");
            ////string email = Console.ReadLine();

            ////Console.WriteLine("Digite o senha do usuario: ");
            ////string senha = Console.ReadLine();

            ////Console.WriteLine("Digite o ativo do usuario: ");
            ////string ativo = Console.ReadLine();

            ////Console.WriteLine("Digite o sexo do usuario: ");
            ////string sexo = Console.ReadLine();

            ////var usuario = new Usuario
            ////{
            ////    Nome = nome,
            ////    DataNascimento = Convert.ToDateTime(data),
            ////    Email = email,
            ////    Senha = senha,
            ////    Ativo = Convert.ToBoolean(ativo),
            ////    SexoId = Convert.ToInt32(sexo)
            ////};

            //var dados = new UsuarioAplicacao().ListarTodos();


            //foreach(var usuario in dados)
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, DataNascimento:{2}, Email:{3}, Ativo:{4}, Sexo:{5}", usuario.UsuarioId,usuario.Nome, usuario.DataNascimento, usuario.Email, usuario.Ativo, usuario.SexoId);
            //}
            //Console.ReadLine();
        }
    }
}
