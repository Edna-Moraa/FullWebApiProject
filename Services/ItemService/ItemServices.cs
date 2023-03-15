namespace ApiOne.Services.ItemService
{
    public class ItemService : IItemService
    {
        private static List<Item> items = new List<Item> {
            new Item{Id = 1, FirstName = "Edna", LastName = "Maburi", Place = "Nairobi"},
            new Item{Id = 2, FirstName = "Cyril", LastName = "Tumbo", Place = "Busia"},
            new Item{Id = 3, FirstName = "Agnes", LastName = "Morangi", Place = "Nairobi"}
        };
        public  List<Item> GetAllItems() 
        {
            return items;
        }
        public Item GetSingleItem(int id)
        {
            var item1 = items.Find(x => x.Id ==id);
            if (item1 is null)
                return null;
        
        return item1;
  
        }
        public List<Item> AddItems(Item item1)
        {
            items.Add(item1);
            return items;

        }
        public List<Item>? UpdateItem(int id, Item request)
        {
            var item1 = items.Find(x => x.Id == id);
            if (item1 is null)
        
                return null;

            item1.FirstName = request.FirstName;
            item1.LastName = request.LastName;
            item1.Place = request.Place;
        
        return items;
  
        }
        public List<Item>? DeleteItem(int id)
        {
            var item1 = items.Find(x => x.Id == id);
            if (item1 is null)
        
                return null;

            items.Remove(item1);
            return items;
        }
        
    }
   
}