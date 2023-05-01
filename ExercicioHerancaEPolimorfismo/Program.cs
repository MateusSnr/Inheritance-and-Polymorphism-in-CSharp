﻿using ExercicioHerancaEPolimorfismo.Entities;
using System.Globalization;

namespace ExercicioHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Product> products = new List <Product> ();//Criando a lista de produtos

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product # {i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (ch == 'u') 
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufacturedate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
