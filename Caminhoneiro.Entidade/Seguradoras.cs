using Caminhoneiro.DTO;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
	public class Seguradoras
    {
		public Seguradoras()
		{
			GetSeguradoras();
		}
		internal static List<TabelaApoioDTO> _Itens = null;
		public static List<TabelaApoioDTO> Itens() { return _Itens; }
		internal void GetSeguradoras()
        {
			_Itens = new List<TabelaApoioDTO>() {
				new TabelaApoioDTO  { Id = 1, Codigo = "3314", Texto = "Sim" },
				new TabelaApoioDTO  { Id = 2, Codigo = "4408", Texto = "Não" }
			};

		}
	}
}
