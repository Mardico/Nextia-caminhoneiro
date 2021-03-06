﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int? SexoId { get; set; }
        public string Sexo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNascimento { get; set; }
        public int? EstadoCivilId { get; set; }
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
        public bool EWhatApp1 { get; set; }
        public bool EWhatApp2 { get; set; }
        public bool EWhatApp3 { get; set; }
        public int? ContactarPorId { get; set; }
        public string ContactarPor { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int NumeroApolices { get; set; }
    }
}
