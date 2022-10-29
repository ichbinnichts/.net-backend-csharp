using Catalog.Dtos;
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
        private readonly IItemsRepository repository;


        // ----- Constructor -----

        //Dependency injection    
        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }
        // ----- Constructor END -----


        //Get all items

        //GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            //Creating item dto from item
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }
        //Get only one item

        //GET /item/id
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id); 
            if(item == null)
            {
                return NotFound();
            }
            return item.AsDto();
        }
        //Post method

        //POST /items
        [HttpPost]
        public ActionResult<ItemDto> Add(AddItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTime.Now
            };
            repository.Add(item);
            return CreatedAtAction(nameof(GetItem), new {id = item.Id}, item.AsDto());
        }
        //Put/Update item method

        //PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto itemDto)
        {
            var existItem = repository.GetItem(id);
            if(existItem is null)
            {
                return NotFound();
            }

            Item updatedItem = existItem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price
            };

            repository.Update(updatedItem);

            return NoContent();
        }
    }
}
