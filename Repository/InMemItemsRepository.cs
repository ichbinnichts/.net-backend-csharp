using Catalog.Entities;
using System.Linq;

namespace Catalog.Repository
{
    public class InMemItemsRepository : IItemsRepository
    {
        //Create a bunch of items
        private readonly List<Item> items = new()
        {
            new Item {Id=Guid.NewGuid(), Name= "Potion", Price=9, CreatedDate = DateTime.Now},
            new Item {Id=Guid.NewGuid(), Name= "Iron Sword", Price=20, CreatedDate = DateTime.Now},
            new Item {Id=Guid.NewGuid(), Name= "Bronze Shield", Price=10, CreatedDate = DateTime.Now}
        };
        //Get all items
        public IEnumerable<Item> GetItems()
        {
            return this.items;
        }
        //Get only one item
        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
        //Post item method
        public void Add(Item item)
        {
            items.Add(item);
        }
    }
}
