using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entites;

namespace Catalog.Repositories
{


    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> Items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 5, CreatedOn = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Diamond Sword", Price = 55, CreatedOn = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bazooka", Price = 100, CreatedOn = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return Items;
        }

        public Item GetItem(Guid id)
        {
            return Items.SingleOrDefault(item => item.Id == id);
        }

        public void CreateItem(Item item)
        {
            Items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = Items.FindIndex(exItem => exItem.Id == item.Id);
            Items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = Items.FindIndex(exItem => exItem.Id == id);
            Items.RemoveAt(index);
        }
    }
}