﻿using System;

namespace Caminhoneiro.DTO
{
    public class ApoliceDadosPagamentoDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int MeioPgtoId { get; set; }
        public string Conta { get; set; }
        public string NomeResponsavel { get; set; }
        public string DataExpiracao { get; set; }
        public string CVV { get; set; }
        public int NParcelasId { get; set; }
    }
}
