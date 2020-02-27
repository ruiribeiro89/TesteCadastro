//Lógica de dados
using Cadastro.Dominio;
using Cadastro.Dominio.contrato;
using Cadastro.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.RepositorioADO
{
   public class UsuarioARepositorioADO:IRepositorio<Usuario>
    {
        private Contexto contexto;

        private void Inserir(Usuario usuario)
        {

            var strQuery = "";
            strQuery = "INSERT INTO TBUSUARIO (Nome,DataNascimento,Email,Senha,Ativo,SexoId)";
            strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
            usuario.Nome, usuario.DataNascimento, usuario.Email, usuario.Senha, usuario.Ativo, usuario.SexoId
            );
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }

        private void Alterar(Usuario usuario)
        {

            var strQuery = "";
            strQuery = "UPDATE TBUSUARIO SET";
            strQuery += string.Format(" Nome = '{0}',", usuario.Nome);
            strQuery += string.Format(" DataNascimento = '{0}',", usuario.DataNascimento);
            strQuery += string.Format(" Email = '{0}',", usuario.Email);
            strQuery += string.Format(" Senha = '{0}',", usuario.Senha);
            strQuery += string.Format(" Ativo = '{0}'", usuario.Ativo);
            strQuery += string.Format(" WHERE UsuarioId = '{0}'", usuario.UsuarioId);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }

        public void Salvar(Usuario usuario)
        {
            if (usuario.UsuarioId > 0)
            {
                Alterar(usuario);
            }
            else
            {
                Inserir(usuario);
            }
        }

        public void Excluir(Usuario usuario)
        {
            //DELETE
            using (contexto = new Contexto())
            {
                var strQuery = string.Format("DELETE FROM TBUSUARIO WHERE USUARIOID = {0}", usuario.UsuarioId);
                contexto.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "SELECT * FROM TBUSUARIO";
                var retornoDataReader = contexto.ExecutaComandoRetorno(strQuery);
                return TransformarReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        public Usuario ListarPorId(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = String.Format("SELECT * FROM TBUSUARIO WHERE USUARIOID = {0} ", id);
                var retornoDataReader = contexto.ExecutaComandoRetorno(strQuery);
                return TransformarReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        private List<Usuario> TransformarReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var usuario = new List<Usuario>();
            while (reader.Read())
            {
                var temObjeto = new Usuario()
                {
                    UsuarioId = Int32.Parse(reader["UsuarioId"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString()),
                    Email = reader["Email"].ToString(),
                    Senha = reader["Senha"].ToString(),
                    Ativo = Boolean.Parse(reader["Ativo"].ToString()),
                    SexoId = Int32.Parse(reader["SexoId"].ToString()),

                };
                usuario.Add(temObjeto);
            }
            reader.Close();
            return usuario;

        }

    }
}
