using Catalog.Entities;
using Catalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    //Controller
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        //Getting our repository
        private readonly InMemItemsRepository repository;


        // ----- Constructor -----
        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }
        // ----- Constructor END -----


        //Get all items

        //GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return this.repository.GetItems();
        }
        //Get only one item

        //GET /item/id
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = this.repository.GetItem(id); 
            if(item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
