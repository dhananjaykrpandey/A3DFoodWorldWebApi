using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A3DFoodWorld.Web.Models
{
    public class mFoodMenuItems
    {
        [Key]
        public string ID { get; set; }
        public string FoodMenuItemGroupCode { get; set; }
        public string FoodMenuItemCode { get; set; }
        public string FoodMenuItemDesc { get; set; }
        public double FoodMenuItemPrice { get; set; }
        public int FoodMenuItemQty { get; set; }
        public bool? IsFoodMenuItemAdded { get; set; } = default;

    }
}
