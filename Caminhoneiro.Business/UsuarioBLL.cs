using Caminhoneiro.DTO;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Caminhoneiro.Business
{
    public class UsuarioBLL
    {
        public UsuarioBLL()
        {
           
        }
        public RetornoGenericoDTO<UsuarioDTO> Logar(FiltroLoginDTO login)
        {
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>() { ID=-1, Mensagem = "Falha ao Logar"};
            var DadosUsuario = Usuarios.Itens().Where(w => w.Codigo == login.usuario).FirstOrDefault();
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
            else
            {
                retorno.Mensagem = "Usuario ou Senha Inválido";
            }
            return retorno;
        }

        public RetornoGenericoDTO<UsuarioDTO> Usuario(FiltroGenericoDTO login)
        {
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>() { ID = -1, Mensagem = "Falha ao Logar" };
            var DadosUsuario = Usuarios.Itens().Where(w => w.Codigo == login.Texto).FirstOrDefault();
            if (DadosUsuario != null)
            {
                retorno.ID = DadosUsuario.Id;
                retorno.Item = DadosUsuario;
                retorno.Mensagem = "Sucesso ao Consultar";
            }
            return retorno;
        }

        public RetornoGenericoDTO<UsuarioDTO> SolicitaSenha(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>() { ID = -1, Mensagem = "Falha ao Logar" };
            var DadosUsuario = Usuarios.Itens().Where(w => w.Email == filtro.Texto).FirstOrDefault();
            if (DadosUsuario != null)
            {
                retorno.ID = DadosUsuario.Id;
                retorno.Item = DadosUsuario;
                retorno.Mensagem = "Sucesso ao Consultar";
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<UsuarioDTO>> ListaUsuariosDoVinculo(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<UsuarioDTO>> retorno = new RetornoGenericoDTO<List<UsuarioDTO>>() { ID = -1, Mensagem = "Falha ao Logar" };
            var DadosUsuario = Usuarios.Itens().Where(w => w.Vinculos.Any(v=> v.Id == filtro.ID)).ToList();
            if (DadosUsuario != null)
            {
                retorno.ID = DadosUsuario.Count;
                retorno.Item = DadosUsuario;
                retorno.Mensagem = "Sucesso ao Consultar";
            }
            return retorno;

        }
    }
}
