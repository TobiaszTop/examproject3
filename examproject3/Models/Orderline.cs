using Microsoft.AspNetCore.Mvc;
using examproject3.Models;
namespace examproject3.Models
{
    public class Orderline : Controller
    {
        public Orderline() { }
        public int orderlineID { get; set; }
        public int cartFK { get; set; }
        public int productFK { get; set; }
        public int amount { get; set; }
        public Cart Cart { get; set; }
        public Subproduct Subproduct { get; set; }
       
    }
}
