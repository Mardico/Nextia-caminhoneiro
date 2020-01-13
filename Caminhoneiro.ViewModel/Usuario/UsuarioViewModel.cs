using System.Collections.Generic;

namespace Caminhoneiro.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }//CPF
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }//Chave Local
        public List<VinculoViewModel> Vinculos { get; set; }

    }
}