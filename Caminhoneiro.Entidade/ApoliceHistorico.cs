using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class ApoliceHistorico
    {
        public ApoliceHistorico()
        {
            ListaApoliceHistorico();
        }
        public static List<ApoliceHistoricoDTO> _Itens = null;
        public static List<ApoliceHistoricoDTO> Itens() { return _Itens; }
        internal void ListaApoliceHistorico()
        {
            List<string> TipoEndosso = new List<string>() { "Inclusão de Proposta", "Alteração dados do Segurado", "Alteração dados do Caminhão" };
            List<string> Endosso = new List<string>() { "Inclusao de Proposta", "Alteração Endereço", "Alteração Placa" };

            int ContId = 0;
            Random r = new Random();
            _Itens = new List<ApoliceHistoricoDTO>();
            foreach (var itemApolice in Apolices.Itens())
            {
                int numops = r.Next(1, 100);
                for (int i = 0; i < numops; i++)
                {
                    ContId++;
                    DateTime start = new DateTime(1995, 1, 1);
                    DateTime dtPagamento = new DateTime();
                    var ticks = new DateTime(2016, 1, 1).Ticks;
                    var ans = DateTime.Now.Ticks - ticks;
                    var uniqueId = ans.ToString("x");
                    var intEndosso = r.Next(0, 2);
                    var intUsuario = r.Next(1, 10);
                    _Itens.Add(new ApoliceHistoricoDTO()
                    {
                        Id = ContId,
                        ClienteId = itemApolice.DadosClienteId,
                        ApoliceId = itemApolice.Id,
                        Data = dtPagamento.AddDays(r.Next((DateTime.Today - start).Days)),
                        Codigo = uniqueId,
                        Endosso= Endosso[intEndosso],
                        NrEndosso = intEndosso,
                        TipoEndosso = TipoEndosso[intEndosso],
                        Usuario = Usuarios.Itens()[intUsuario].Nome
                    });
                }
            }
        }
    }
}
