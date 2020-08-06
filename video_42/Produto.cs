using System.Globalization;

namespace video_42
{
    class Produto
    {
        //Padrão para atributos privados: Underline na frente e primeira letra minuscula
        private string _nome;
        public double Preco { get; private set; }    //Criando uma Auto-Property, é usada quando a property
        public int Quantidade { get; private set; } //não tem lógica especifíca.. está dizendo que é permitida
                                                   //somente a visualização.

        public Produto(string nome, double preco, int quantidade) //Crindo um CONSTRUTOR que pede assim que é 
        {                                                        //Instanciado que os atributos sejam
            _nome = nome;                                       //Inseridos.
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) //Criando uma SOBRECARGA de construtor que solicita 
        {                                        //somente alguns parametros
            _nome = nome;                       //Construtor Opcional
            Preco = preco;
            Quantidade = 0;
        }



        // Criando as properties para o encapsulamento dos atributos da classe //
        public string Nome{
            get
            {
                return _nome;
            }
            set
            {
                if (value!=null && value.Length > 1)
                {
                    _nome = Nome;
                }
            }
        }
        /* As auto-Properties substituem este código 
         * 
        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public int Quantidade
        {
            get
            {
               return _quantidade;
            }
        }
        */
        //--------------------------------------------------------------------------------//


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }


        //somente estes dois métodos poderam modificar quantidade//
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        //--------------------------------------------------------------------------------//

        public override string ToString() //o override SOBREESCREVE um método de uma outra classe!
        {
            return Nome
                + ", $"
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", Quantidade: " 
                + Quantidade
                + ", Valor Total no estoque: "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
