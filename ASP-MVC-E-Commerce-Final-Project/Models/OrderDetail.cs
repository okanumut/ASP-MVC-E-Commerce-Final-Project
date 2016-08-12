using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_E_Commerce_Final_Project.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual FoodItem FoodItem { get; set; }
        public virtual int FoodItemID { get; set; }
        public virtual Order Order { get; set; }
        public virtual int OrderId { get; set; }
    }
}