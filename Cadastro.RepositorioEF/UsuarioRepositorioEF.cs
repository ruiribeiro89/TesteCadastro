using Cadastro.Dominio;
using Cadastro.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuario>
    {

        private readonly Contexto contexto;

        public UsuarioRepositorioEF()
        {
            contexto = new Contexto();
        }

        void IRepositorio<Usuario>.Excluir(Usuario entidade)
        {

            var usuarioExcluir = contexto.Usuarios.First(x => x.UsuarioId == entidade.UsuarioId);
            contexto.Set<Usuario>().Remove(usuarioExcluir);
            contexto.SaveChanges();
        }

        Usuario IRepositorio<Usuario>.ListarPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint);
            return contexto.Usuarios.First(x => x.UsuarioId == idint);
        }

        IEnumerable<Usuario> IRepositorio<Usuario>.ListarTodos()
        {
            return contexto.Usuarios;
        }

        void IRepositorio<Usuario>.Salvar(Usuario entidade)
        {
                if (entidade.UsuarioId > 0)
                {
                    var usuarioAlterar = contexto.Usuarios.First(x => x.UsuarioId == entidade.UsuarioId);
                    usuarioAlterar.Nome = entidade.Nome;
                    usuarioAlterar.DataNascimento = entidade.DataNascimento;
                    usuarioAlterar.Email = entidade.Email;
                    usuarioAlterar.Senha = entidade.Senha;
                    usuarioAlterar.Ativo = entidade.Ativo;
                    usuarioAlterar.SexoId = entidade.SexoId;
                }
                else
                {
                    contexto.Usuarios.Add(entidade);
                }
                contexto.SaveChanges();
            
        }
    }
}
