using System.Globalization;

namespace ExercicioHerancaEPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct() 
        { 

        }

        public UsedProduct(string name, double price, DateTime date)
            :base(name, price)
        {
            Name = name;
            Price = price;
            manufactureDate = date;
        }

        public override string priceTag()
        {
            return Name 
                + "(used) $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: " 
                + manufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
