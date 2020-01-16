using System.Collections.Generic;

namespace Caminhoneiro.ViewModel
{
    public class FiltroDataTablesViewModel
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<DataTablesColunasViewModel> columns { get; set; }
        public DataTablesFiltroViewModel search { get; set; }
        public List<DataTablesOrdemViewModel> order { get; set; }
    }
}
