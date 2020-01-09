using Caminhoneiro.DTO.Cliente;
using Caminhoneiro.DTO.Shared;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Business
{
    public class ClienteBLL
    {
        public RetornoGenericoDTO<List<ClienteDTO>> Listar(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<ClienteDTO>> retorno = new RetornoGenericoDTO<List<ClienteDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ClienteDTO>(), ID = -1 };
            try
            {
                retorno.Item = Clientes.GetClientes().Where(w => w.CPF == filtro.Texto).ToList();
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
                var Apolice = Clientes.GetClientes().Where(w => w.Id == filtro.Id).FirstOrDefault();
                if (Apolice != null)
                {
                    Clientes.GetClientes().Remove(Apolice);
                    Clientes.GetClientes().Add(filtro);
                }
                else
                {
                    var IdApolice = Clientes.GetClientes().Max(w => w.Id);
                    filtro.Id = IdApolice++;
                    Clientes.GetClientes().Add(filtro);
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
                var Cliente = Clientes.GetClientes().Where(w => w.Id == filtro.ID).FirstOrDefault();
                if (Cliente != null)
                {
                    Clientes.GetClientes().Remove(Cliente);
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

        public RetornoGenericoDTO<ClienteDTO> Cliente(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { Mensagem = "Falha ao Carregar", Item = new ClienteDTO(), ID = -1 };
            try
            {
                var Cliente = Clientes.GetClientes().Where(w => w.Id == filtro.ID || w.CPF == filtro.Texto ).FirstOrDefault();
                if (Cliente != null)
                {
                    retorno.Item = Cliente;
                }

                retorno.ID = filtro.ID;
                retorno.Mensagem = "Sucesso ao Carregar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
    }
}
