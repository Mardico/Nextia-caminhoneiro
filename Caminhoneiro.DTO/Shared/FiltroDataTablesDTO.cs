using System.Collections.Generic;

namespace Caminhoneiro.DTO
{
    public class FiltroDataTablesDTO
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<DataTablesColunasDTO> columns { get; set; }
        public DataTablesFiltroDTO search { get; set; }
        public List<DataTablesOrdemDTO> order { get; set; }
    }
}
