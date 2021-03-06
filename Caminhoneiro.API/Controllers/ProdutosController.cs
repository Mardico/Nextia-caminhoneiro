﻿using Caminhoneiro.Business;
using Caminhoneiro.DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Caminhoneiro.API.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<ProdutoDTO>>> ListaProdutos(UsuarioDTO filtro)
        {
            logar.Debug("Inicio ListaProdutos");
            RetornoGenericoDTO<List<ProdutoDTO>> retorno = new RetornoGenericoDTO<List<ProdutoDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ProdutosBLL produtos = new ProdutosBLL();
                retorno = produtos.Listar(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListaProdutos");
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<ProdutoDTO>> Item(ProdutoDTO filtro)
        {
            logar.Debug("Inicio Item");
            RetornoGenericoDTO<ProdutoDTO> retorno = new RetornoGenericoDTO<ProdutoDTO>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ProdutosBLL produtos = new ProdutosBLL();
                retorno = produtos.Produto(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino Item");
            return Json(retorno);
        }
    }
}