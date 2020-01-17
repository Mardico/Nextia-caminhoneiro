using System;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosBeneficiarioViewModel
    {
        public string Nome { get; set; }
        public string NDocumento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] 
        public DateTime? DataNasc { get; set; }
        public string Sexo { get; set; }
        public int SexoId { get; set; }
        public int Parentescoid { get; set; }
        public string Parentesco { get; set; }
        public float Porcentagem { get; set; }
    }
}
