using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class ApolicePagamentos
    {
        public ApolicePagamentos()
        {
            ListaApolicePagamentos();
        }
        public static List<ApolicePagamentoDTO> _Itens = null;
        public static List<ApolicePagamentoDTO> Itens() { return _Itens; }
        internal void ListaApolicePagamentos()
        {
            List<string> StatusPgto = new List<string>() { "Pago", "Em Atrazo", "Pentende" };
            List<string> TipoPagto = new List<string>() { "Crédito", "Débito", "Outros" };
            List<string> TipoTransacao = new List<string>() { "Cartão de Crédito", "Boleto", "TED" };
            int ContId = 0;
            _Itens = new List<ApolicePagamentoDTO>();
            foreach (var itemApolice in Apolices.Itens())
            {
                int numops = new Random().Next(1, 100);
                for (int i = 0; i < numops; i++)
                {
                    ContId++;
                    int oParcelas = new Random().Next(1, 24);
                    int intStatus = new Random().Next(0, 2);
                    int intTipoPgto = new Random().Next(0, 2);
                    int intTipoTrans = new Random().Next(0, 2);
                    int Valor = new Random().Next(1, 100000000);
                    DateTime start = new DateTime(1995, 1, 1);
                    DateTime dtPagamento = new DateTime();
                    DateTime dtVencimento = new DateTime();
                    _Itens.Add(new ApolicePagamentoDTO()
                    {
                        Id = ContId,
                        ApoliceId = itemApolice.Id,
                        ClienteId = itemApolice.DadosClienteId,
                        DataPagamento = dtPagamento.AddDays(new Random().Next((DateTime.Today - start).Days)),
                        DataVencimento = dtVencimento.AddDays(new Random().Next((DateTime.Today - start).Days)),
                        MeioPagamento = "Cartão",
                        NrParcelas = oParcelas,
                        StatusPagamento = StatusPgto[intStatus],
                        TipoPagamento = TipoPagto[intTipoPgto],
                        TipoTransacao = TipoTransacao[intTipoTrans],
                        Valor = Valor
                    });
                }
            }
        }
    }
}
