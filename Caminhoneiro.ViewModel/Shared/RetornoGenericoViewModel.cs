namespace Caminhoneiro.ViewModel.Shared
{
    public class RetornoGenericoViewModel<T>
    {
        public RetornoGenericoViewModel()
        {

        }
        public RetornoGenericoViewModel(int id)
        {
            this.ID = id;
        }
        public RetornoGenericoViewModel(int id, string mensagem) : this(id)
        {
            this.Mensagem = mensagem;
        }

        public RetornoGenericoViewModel(int id, string mensagem, T item) : this(id, mensagem)
        {
            this.Item = item;
        }

        public int ID { get; set; }
        public T Item { get; set; }
        public string Mensagem { get; set; }

    }
}
