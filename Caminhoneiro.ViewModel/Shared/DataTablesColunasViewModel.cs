using Caminhoneiro.Enumeradores;

namespace Caminhoneiro.ViewModel
{
    public class DataTablesColunasViewModel
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public FieldTypeEnum Type { get; set; }
        public DataTablesFiltroViewModel search { get; set; }
    }
}
