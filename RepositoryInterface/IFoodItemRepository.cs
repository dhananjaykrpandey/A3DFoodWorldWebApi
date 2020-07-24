using A3DFoodWorld.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A3DFoodWorld.Web.RepositoryInterface
{
    public interface IFoodItemRepository
    {

        void Add(mFoodMenuItems item);
        void Update(mFoodMenuItems item);
        mFoodMenuItems Remove(string key);
        mFoodMenuItems Get(string id);
        IEnumerable<mFoodMenuItems> GetAll();

    }
}
