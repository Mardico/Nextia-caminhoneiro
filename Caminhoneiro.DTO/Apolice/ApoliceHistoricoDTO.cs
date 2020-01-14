using System;

namespace Caminhoneiro.DTO
{
    public class ApoliceHistoricoDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ApoliceId { get; set; }
        public string Codigo { get; set; }
        public int NrEndosso { get; set; }
        public string TipoEndosso { get; set; }
        public string Endosso { get; set; }
        public DateTime Data { get; set; }
        public string Usuario { get; set; }
    }
}
