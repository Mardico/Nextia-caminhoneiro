using System;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.DTO
{
    public class ClienteDTO
    {
        private string _cpf = null;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                if (_cpf != null && _cpf.Length == 11)
                    _cpf = _cpf.Substring(0, 3) + "." + _cpf.Substring(3, 3) + "." + _cpf.Substring(6, 3) + "-" + _cpf.Substring(9, 2);
                return _cpf;
            }
            set
            {
                if (value != null)
                    _cpf = value.Replace(".", "").Replace("-", "");
            }
        }
        public int SexoId { get; set; }
        public string Sexo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public int EstadoCivilId { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneSecundario { get; set; }
        public string TelefoneAdicional { get; set; }
        public int ContactarPorId { get; set; }
        public string ContactarPor { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int NumeroApolices { get; set; }
    }
}
