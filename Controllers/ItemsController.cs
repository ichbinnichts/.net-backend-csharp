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
            return (IEnumerable<Item>)this.repository.GetItems();
        }
        //Get only one item

        //GET /item/id
        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            return this.repository.GetItem(id);
        }
    }
}
