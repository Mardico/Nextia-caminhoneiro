using System;

namespace Caminhoneiro.DTO
{
    public class ApoliceDadosDependenteDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string GrauDependencia { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNasc { get; set; }
    }
}
