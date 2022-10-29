using Catalog.Entities;

namespace Catalog.Repository
{
    //Repository interface
    public interface IItemsRepository
    {
        //Get an item
        Item GetItem(Guid id);
        //Get all items
        IEnumerable<Item> GetItems();   
    }
}
