using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.FromResult(Items);
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            var items = Items.SingleOrDefault(item => item.Id == id);

            return await Task.FromResult(items);
        }

        public async Task CreateItemAsync(Item item)
        {
            Items.Add(item);
            await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = Items.FindIndex(exItem => exItem.Id == item.Id);
            Items[index] = item;
            await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index = Items.FindIndex(exItem => exItem.Id == id);
            Items.RemoveAt(index);
            await Task.CompletedTask;
        }
    }
}