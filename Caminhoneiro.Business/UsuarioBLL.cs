using Caminhoneiro.DTO.Shared;
using Caminhoneiro.DTO.Usuario;
using Caminhoneiro.Entidade;
using System.Linq;
namespace Caminhoneiro.Business
{
    public class UsuarioBLL
    {
        public RetornoGenericoDTO<UsuarioDTO> Logar(FiltroLoginDTO login)
        {
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>() { ID=-1, Mensagem = "Falha ao Logar"};
            var DadosUsuario = Usuarios.GetUsuario().Where(w => w.Codigo == login.usuario).FirstOrDefault();
            if (DadosUsuario != null)
            {
                retorno.ID = DadosUsuario.Id;
                if (DadosUsuario.Senha == login.senha)
                {
                    retorno.Item = DadosUsuario;
                    retorno.Mensagem = "Sucesso ao Logar";
                }
                else
                {
                    retorno.Mensagem = "Usuario ou Senha Inválido";
                }
            }
            return retorno;
        }

        public RetornoGenericoDTO<UsuarioDTO> Usuario(FiltroGenericoDTO login)
        {
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>() { ID = -1, Mensagem = "Falha ao Logar" };
            var DadosUsuario = Usuarios.GetUsuario().Where(w => w.Codigo == login.Texto).FirstOrDefault();
            if (DadosUsuario != null)
            {
                retorno.ID = DadosUsuario.Id;
                retorno.Item = DadosUsuario;
                retorno.Mensagem = "Sucesso ao Consultar";
            }
            return retorno;
        }
    }
}
