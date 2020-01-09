using System.Collections.Generic;

namespace Caminhoneiro.ViewModel.Usuario
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<EmpresaS> Empressas { get; set; }

    }

    public class EmpresaS
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }

    }
}