namespace ApiOne.Services.ItemService
{
    public interface IItemService
    {
        List<Item> GetAllItems();
        Item GetSingleItem(int id);
        List<Item> AddItems(Item item1);
        List<Item>? UpdateItem(int id, Item request);
        List<Item>? DeleteItem(int id);
    }
}