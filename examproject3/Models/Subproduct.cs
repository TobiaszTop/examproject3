using Microsoft.AspNetCore.Mvc;
using examproject3.Models;

namespace examproject3.Models
{
    public class Subproduct : Controller
    {
        public Subproduct() { }
        public int subproductID { get; set; }
        public int productFK { get; set; }
        public int stock { get; set; }
        public int size { get; set; }
        public ICollection<Orderline> Orderlines { get; set; }
        public Product Product { get; set; }
        
    }
}
