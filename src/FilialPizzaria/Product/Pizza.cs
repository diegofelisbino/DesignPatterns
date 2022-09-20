namespace FilialPizzaria.Product
{
    
    public abstract class Pizza
    {
        //public TipoProduto TipoProduto { get; set; }
        public string Name { get; set; }

        public string Preparar()
        {
            return $"Preparando a pizza de {Name}";
        }
    }
}
