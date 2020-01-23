using System;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosDependenteViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string SexoId { get; set; }
        public string Sexo { get; set; }
        public int? GrauDependenciaId { get; set; }
        public string GrauDependencia { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNasc { get; set; }
    }
}
