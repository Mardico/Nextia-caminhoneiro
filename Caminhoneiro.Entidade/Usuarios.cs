using Caminhoneiro.DTO.Shared;
using Caminhoneiro.DTO.Usuario;
using System.Collections.Generic;
using System.Linq;
namespace Caminhoneiro.Entidade
{
    public static class Usuarios
    {
        public static List<UsuarioDTO> GetUsuario()
        {

            List<Vinculo> sindicatos = Sindicatos.GetSindicatos().Select(s => new Vinculo { Codigo = s.Codigo, Nome = s.Texto }).ToList();
            return new List<UsuarioDTO>() {
                new UsuarioDTO() {Id =1, Codigo = "522.083.521-14", Nome="Luis Paulo", Email="luis.paulo@gmail.com", Senha = "123@Mudar", Vinculos = sindicatos.Where(w=>w.Codigo=="0001").ToList() },
                new UsuarioDTO() { Id = 2, Codigo = "402.027.612-90", Nome="Danilo Jose" , Email="danilo.jose@gmail.com" , Senha = "123@Mudar" , Vinculos = sindicatos.Where(w=>w.Codigo=="0002").ToList()},
                new UsuarioDTO() { Id = 3, Codigo = "414.755.773-20", Nome="Jose Paulo da Silva", Email="jose.paulo@gmail.com" , Senha = "123@Mudar" , Vinculos = sindicatos.Where(w=>w.Codigo=="0003").ToList()},
                new UsuarioDTO() { Id = 4, Codigo = "720.380.568-97", Nome="Marcos Antonio Oliveira", Email="marco.oliveira@gmail.com", Senha = "@Mudar123" , Vinculos= sindicatos.Where(w=>w.Codigo!="0001").ToList()},
                new UsuarioDTO() { Id = 5, Codigo = "738.870.150-88", Nome="Eduardo Martins Garcia Martins Oliveira", Email="eduardo.martins@gmail.com" , Senha = "@Mudar123", Vinculos = sindicatos.Where(w=>w.Codigo=="0004").ToList()},
                new UsuarioDTO() { Id = 6, Codigo = "708.740.205-65", Nome="Maria Carmen Martins", Email="maria.carmen@uol.com" , Senha = "@Mudar123", Vinculos = sindicatos.Where(w=>w.Codigo=="0005").ToList()},
                new UsuarioDTO() { Id = 7, Codigo = "671.033.760-00", Nome="Daniela Aparecida", Email="daniaparecida@ig.com", Senha = "Random", Vinculos = sindicatos.Where(w=>w.Codigo=="0006").ToList()},
                new UsuarioDTO() { Id = 8, Codigo = "817.568.556-50", Nome="Marcia Regina ", Email="m.regina@microsoft.com", Senha = "Umasenharealmentemuitograndeforadopadrao", Vinculos = sindicatos.Where(w=>w.Codigo=="0007").ToList()},
                new UsuarioDTO() { Id = 9, Codigo = "352.332.284-75", Nome="Carmen Lucia G", Email="carmenluciagmartinsoliveira@bol.com.br", Senha = "sm", Vinculos = sindicatos.Where(w=>w.Codigo=="0005" || w.Codigo=="0006" ).ToList()},
                new UsuarioDTO() { Id = 10, Codigo = "212.770.861-09", Nome="Leonardo Rafael", Email="leonardorafa@datamidia.com.br", Senha = "", Vinculos = sindicatos.Where(w=>w.Codigo=="0002").ToList()},
                new UsuarioDTO() { Id = 11, Codigo = "046.117.672-64", Nome="Carlos Jose da Silva Quadros", Email="jose-paulo@inovabra.com.br", Senha = "letras", Vinculos= sindicatos.Where(w=>w.Codigo=="0002").ToList()}
            };
        }
    }
}
