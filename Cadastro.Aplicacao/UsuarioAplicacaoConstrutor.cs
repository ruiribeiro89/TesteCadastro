using Cadastro.RepositorioADO;
using Cadastro.RepositorioEF;

//Fábrica de Objetos

namespace Cadastro.Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioAplicacaoADO()
        {
            return new UsuarioAplicacao(new UsuarioARepositorioADO());
        }

        public static UsuarioAplicacao UsuarioAplicacaoEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
