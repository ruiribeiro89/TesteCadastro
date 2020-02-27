//Repositorio do BD
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cadastro.Repositorio
{
    public class Contexto:IDisposable
    {
        private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            //tag da appconfig
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["CadastroConfig"].ConnectionString);
            minhaConexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);
            return cmdComando.ExecuteReader();
        }



        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open) ;
            minhaConexao.Close();
        }
    }
}
