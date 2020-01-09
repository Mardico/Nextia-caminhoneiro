namespace Caminhoneiro.DTO.Shared
{
    public class RetornoGenericoDTO<T>
    {
        public RetornoGenericoDTO()
        {

        }
        public RetornoGenericoDTO(int id)
        {
            this.ID = id;
        }
        public RetornoGenericoDTO(int id, string mensagem) : this(id)
        {
            this.Mensagem = mensagem;
        }

        public RetornoGenericoDTO(int id, string mensagem, T item) : this(id, mensagem)
        {
            this.Item = item;
        }

        public int ID { get; set; }
        public T Item { get; set; }
        public string Mensagem { get; set; }
    }
}
