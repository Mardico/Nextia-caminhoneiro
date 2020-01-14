using System;

namespace Caminhoneiro.DTO
{
    public class ApolicePagamentoDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ApoliceId { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public string TipoPagamento { get; set; }
        public string MeioPagamento { get; set; }
        public int NrParcelas { get; set; }
        public float Valor { get; set; }
        public string TipoTransacao { get; set; }
        public string StatusPagamento { get; set; }
    }
}
