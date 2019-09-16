using System;

namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("pumpkin", 200.00m);
            //var productPrice = new Product(200);

            

            Console.WriteLine($"The product name is {product.Name} and costs {product.Price}");
     
        }
    }
}
