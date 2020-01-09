namespace Caminhoneiro.DTO.Usuario
{
    public class AlteraSenhaDTO
    {
        public string Usuario { get; set; }
        public string SenhaAtual { get; set; }
        public string NovaSenha { get; set; }
        public string ConfirmaNovaSenha { get; set; }
        public string URLRedirect { get; set; }
        public string ChaveAplicativo { get; set; }
        public string ChaveLink { get; set; }
    }
}
