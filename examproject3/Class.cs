using System.Text;
using examproject3.Models;

namespace examproject3
{
    public class Class
    {
        /*
        static void Main(string[] args)
        {
            InsertData();
            PrintData();
        }
        */
        private static void InsertData()
        {
            using (var context = new webshopContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds some books
                context.Product.Add(new Product 
                {
                    productID = 1,
                    name = "Blue Shirt",
                    price = 199.00,
                    description = "very nice shirt"

                }); ;

                // Saves changes
                context.SaveChanges();

                
            }
        }
        private static void PrintData()
        {
            // Gets and prints all books in database
            using (var context = new webshopContext())
            {
                var products = context.Product;
                foreach(var product in products)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ID: {product.productID}");
                    data.AppendLine($"Name: {product.name}");
                    data.AppendLine($"Price: {product.price}");
                    data.AppendLine($"Description: {product.description}");
                    Console.WriteLine(data.ToString());
                }
            }
        }

    }
}
