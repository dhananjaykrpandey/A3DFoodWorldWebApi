using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A3DFoodWorld.Web.Models;
using A3DFoodWorld.Web.RepositoryInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A3DFoodWorld.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemRepository FoodItemRepository;

        public FoodItemController(IFoodItemRepository _FoodItemRepository)
        {
            FoodItemRepository = _FoodItemRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<mFoodMenuItems>> List()
        {
            return FoodItemRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<mFoodMenuItems> GetItem(string id)
        {
            mFoodMenuItems item = FoodItemRepository.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<mFoodMenuItems> Create([FromBody] mFoodMenuItems item)
        {
            FoodItemRepository.Add(item);
            return CreatedAtAction(nameof(GetItem), new { item.ID }, item);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Edit([FromBody] mFoodMenuItems item)
        {
            try
            {
                FoodItemRepository.Update(item);
            }
            catch (Exception)
            {
                return BadRequest("Error while editing item");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(string id)
        {
            mFoodMenuItems item = FoodItemRepository.Remove(id);

            if (item == null)
                return NotFound();

            return Ok();
        }
    }
}
