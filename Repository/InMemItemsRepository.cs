using Catalog.Entities;

namespace Catalog.Repository
{
    public class InMemItemsRepository
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
            return (Item)items.Where(item => item.Id == id);
        }
    }
}
