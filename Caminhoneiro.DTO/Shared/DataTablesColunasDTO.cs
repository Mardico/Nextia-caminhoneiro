using Caminhoneiro.Enumeradores;

namespace Caminhoneiro.DTO
{
    public class DataTablesColunasDTO
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public FieldTypeEnum Type { get; set; }
        public DataTablesFiltroDTO search { get; set; }
    }
}
