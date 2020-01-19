using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.DTO
{
    public class ApoliceDadosBeneficiarioDTO
    {
        private int _SexoId = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NDocumento { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public int SexoId
        {
            get
            {
                if (Id % 2 == 0)
                    return 0;
                else
                    return 1;
            }
            set
            {
                _SexoId = value;
            }
        }
        public int Parentescoid { get; set; }
        public string Parentesco { get; set; }
        public float Porcentagem { get; set; }
    }
}
