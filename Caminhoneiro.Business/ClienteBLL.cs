using Caminhoneiro.DTO;
using Caminhoneiro.Entidade;
using Caminhoneiro.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caminhoneiro.Business
{
    public class ClienteBLL
    {
        public ClienteBLL()
        {
        }
        public RetornoGenericoDTO<List<ClienteDTO>> Listar(ClienteDTO filtro)
        {
            RetornoGenericoDTO<List<ClienteDTO>> retorno = new RetornoGenericoDTO<List<ClienteDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ClienteDTO>(), ID = -1 };
            try
            {
                retorno.Item = Clientes.Itens().Where(w => (filtro.CPF != null && w.CPF == filtro.CPF) || (filtro.Nome != null && w.Nome.Contains(filtro.Nome))).ToList();
                foreach (var cliente in retorno.Item)
                {
                    cliente.NumeroApolices = Apolices.Itens().Count(w => (filtro.CPF != null && w.DadosCliente.CPF == filtro.CPF) || (filtro.Nome != null && w.DadosCliente.Nome.Contains(filtro.Nome)));
                }
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Listar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<ClienteDTO> Salvar(ClienteDTO filtro)
        {
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { Mensagem = "Falha ao Processar", Item = new ClienteDTO(), ID = -1 };
            try
            {
                var Apolice = Clientes.Itens().Where(w => w.Id == filtro.Id).FirstOrDefault();
                if (Apolice != null)
                {
                    Clientes.Itens().Remove(Apolice);
                    Clientes.Itens().Add(filtro);
                }
                else
                {
                    var IdApolice = Clientes.Itens().Max(w => w.Id);
                    filtro.Id = IdApolice++;
                    Clientes.Itens().Add(filtro);
                }
                retorno.ID = retorno.Item.Id;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<bool> Excluir(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { Mensagem = "Falha ao Processar", Item = false, ID = -1 };
            try
            {
                var Cliente = Clientes.Itens().Where(w => w.Id == filtro.ID).FirstOrDefault();
                if (Cliente != null)
                {
                    Clientes.Itens().Remove(Cliente);
                }
                retorno.Item = true;
                retorno.ID = filtro.ID;
                retorno.Mensagem = "Sucesso ao Excluir";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<ClienteDTO> Cliente(ClienteDTO filtro)
        {
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { Mensagem = "Falha ao Carregar", Item = new ClienteDTO(), ID = -1 };
            try
            {
                var Cliente = Clientes.Itens().Where(w => (filtro.Id > 0 && w.Id == filtro.Id) || (filtro.CPF != null && w.CPF == filtro.CPF) || (filtro.Nome != null && w.Nome == filtro.Nome)).FirstOrDefault();
                if (Cliente != null)
                {
                    retorno.Item = Cliente;
                    retorno.ID = Cliente.Id;
                    retorno.Mensagem = "Sucesso ao Carregar";
                }
                else
                {
                    retorno.ID = 0;
                    retorno.Mensagem = "Registro Não Localizado";
                }

            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<ClienteDTO> BuscaCEP(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { Mensagem = "Falha ao Carregar", Item = new ClienteDTO(), ID = -1 };
            using (var client = new HttpClientUtil<dynamic>())
            {
                try
                {
                    var ret = client.Get(filtro.Texto.Replace("-", "") + "/json/");
                    retorno.Item.CEP = ret.cep;
                    retorno.Item.Endereco = ret.logradouro;
                    retorno.Item.Complemento = ret.complemento;
                    retorno.Item.Bairro = ret.bairro;
                    retorno.Item.Cidade = ret.localidade;
                    retorno.Item.UF = ret.uf;
                    retorno.ID = 0;
                    if (ret.erro == null)
                        retorno.ID = 1;
                }
                catch (Exception ex)
                {
                    retorno.Mensagem = ex.Message;
                }
            }
            return retorno;
        }
    }
}
