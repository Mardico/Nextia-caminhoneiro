using System;

namespace Caminhoneiro.ViewModel.Cliente
{
    public class ClienteViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
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
        public string ContactarPor { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
