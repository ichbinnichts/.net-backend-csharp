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
        //Constructor
        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }
        //Get all items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return (IEnumerable<Item>)this.repository.GetItems();
        }
    }
}
