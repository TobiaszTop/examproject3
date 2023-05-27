using Microsoft.AspNetCore.Mvc;
using examproject3.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examproject3.Models
{
    public class Product : Controller
    {
        public Product() { }

        public int productID { get; set; }
        public String name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double price { get; set; }
        public String description { get; set; }
        public ICollection<Subproduct> Subproducts { get; set; }
        public Product(int _productID, String _name, double _price, String _description)
        {
            productID = _productID;
            name = _name;
            price = _price;
            description = _description;
        }

    }
}