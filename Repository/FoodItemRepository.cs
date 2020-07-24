using A3DFoodWorld.Web.Models;
using A3DFoodWorld.Web.RepositoryInterface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A3DFoodWorld.Web.Repository
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private static ConcurrentDictionary<string, mFoodMenuItems> FoodMenuItems = new ConcurrentDictionary<string, mFoodMenuItems>();

        public FoodItemRepository()
        {
            AddFoodMenuItems();
        }

        public IEnumerable<mFoodMenuItems> GetAll()
        {
            return FoodMenuItems.Values;
        }

        public void Add(mFoodMenuItems item)
        {
            item.ID = Guid.NewGuid().ToString();
            FoodMenuItems[item.ID] = item;
        }

        public mFoodMenuItems Get(string id)
        {
            FoodMenuItems.TryGetValue(id, out mFoodMenuItems item);
            return item;
        }

        public mFoodMenuItems Remove(string id)
        {
            FoodMenuItems.TryRemove(id, out mFoodMenuItems item);
            return item;
        }

        public void Update(mFoodMenuItems item)
        {
            FoodMenuItems[item.ID] = item;
        }
        private void AddFoodMenuItems()
        {


            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AG", FoodMenuItemDesc = "Aloo gobi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AT", FoodMenuItemDesc = "Aloo tikki", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AM", FoodMenuItemDesc = "Aloo matar", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AP", FoodMenuItemDesc = "Aloo methi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AS", FoodMenuItemDesc = "Aloo shimla mirch", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "BH", FoodMenuItemDesc = "Bhatura", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "PP", FoodMenuItemDesc = "Paneer paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "OP", FoodMenuItemDesc = "Onion paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "MP", FoodMenuItemDesc = "mint paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CSP", FoodMenuItemDesc = "carom seeds paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CDP", FoodMenuItemDesc = "Chana dal paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "DAP", FoodMenuItemDesc = "Dhaba style aloo paratha.", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });



            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "OP", FoodMenuItemDesc = "Onion paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "MP", FoodMenuItemDesc = "mint paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CSP", FoodMenuItemDesc = "carom seeds paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CDP", FoodMenuItemDesc = "Chana dal paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "DAP", FoodMenuItemDesc = "Dhaba style aloo paratha.", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });



            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });


            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PTM", FoodMenuItemDesc = "Paneer Tikka Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "TR", FoodMenuItemDesc = "Tandoori Roti, Tandoori Roti On A Tava", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PMD", FoodMenuItemDesc = "Paneer Makhani", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "KUL", FoodMenuItemDesc = "Kulcha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PRP", FoodMenuItemDesc = "Punjabi Reshmi Paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "CBH", FoodMenuItemDesc = "Chole Bhature", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });


            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); 
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); 
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); 
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            Add(new mFoodMenuItems { ID = Guid.NewGuid().ToString(), FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            
        }
    }
}
