using System.Collections.Generic;

namespace Caminhoneiro.DTO.Usuario
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }//CPF
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }//Chave Local
        public List<Vinculo> Vinculos { get; set; }

    }

    public class Vinculo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }
}