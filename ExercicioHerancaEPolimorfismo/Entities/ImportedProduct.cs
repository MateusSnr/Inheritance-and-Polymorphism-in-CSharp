using System.Globalization;

namespace ExercicioHerancaEPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() 
        { 

        }
        
        public ImportedProduct(string name, double price, double customsfee)
            :base(name, price) 
        {
            Name = name;
            Price = price;
            customsFee = customsfee;
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + customsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
