﻿namespace Caminhoneiro.DTO
{
    public class FiltroGenericoDTO
    {
        public int ID { get; set; }
        public bool SimNao { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }
        public string Data { get; set; }
        public string DataPeriodo { get; set; }
        public string Usuario { get; set; }
        public string DataExecucao { get; set; }
    }
}