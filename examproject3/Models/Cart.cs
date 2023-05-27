using Microsoft.AspNetCore.Mvc;
using examproject3.Models;

namespace examproject3.Models
{
    public class Cart
    {
        public  Cart(){}
        public int cartID { get; set; }
        public ICollection<Orderline> Orderlines { get; set; }

    }

}
