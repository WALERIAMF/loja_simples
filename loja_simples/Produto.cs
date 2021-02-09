using System.Globalization;


namespace loja_simples
{
    class Produto
    {
        public string _nome;
        public double Preco { get; private set; }
        private int Quantidade { get; set; }

        public Produto()
        { }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public string preco
        {
            get { return preco; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    preco = value;
                }
            }
        }

        public string quantidade
        {
            get { return quantidade; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    quantidade = value;
                }
            }
        }
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $"
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

