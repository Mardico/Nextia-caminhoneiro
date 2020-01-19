using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Entidade
{
    public class ApoliceStatus
    {
        public ApoliceStatus()
        {
            ListaStatus();
        }
        public static List<ApoliceStatusDTO> _Itens = null;
        public static List<ApoliceStatusDTO> Itens() { return _Itens; }

        internal void ListaStatus()
        {
            _Itens = new List<ApoliceStatusDTO>()
            {
                new ApoliceStatusDTO() { Id = 0, codigo = "AP", Nome = "Pendente" },
                new ApoliceStatusDTO() { Id = 1, codigo = "CA", Nome = "Cancelada" },
                new ApoliceStatusDTO() { Id = 2, codigo = "PR", Nome = "Processando" },
                new ApoliceStatusDTO() { Id = 3, codigo = "AT", Nome = "Ativa" },
                new ApoliceStatusDTO() { Id = 4, codigo = "AT", Nome = "Erro" }
            };
        }
    }
}
