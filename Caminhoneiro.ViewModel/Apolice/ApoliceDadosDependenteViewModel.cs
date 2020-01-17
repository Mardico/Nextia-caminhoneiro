using System;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosDependenteViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNasc { get; set; }
    }
}
