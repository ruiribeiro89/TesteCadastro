using Cadastro.Aplicacao;
using Cadastro.Dominio;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly UsuarioAplicacao appUsuario;

        public UsuarioController()
        {
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoEF();
        }

        // GET: api/Usuario
        public IEnumerable<Usuario> Get()
        {
            return appUsuario.ListarTodos();
        }

        // GET: api/Usuario/5
        public Usuario Get(string id)
        {
            return appUsuario.ListarPorId(id);
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
