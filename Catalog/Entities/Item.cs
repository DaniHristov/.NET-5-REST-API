using System;

namespace Catalog.Entites
{
    public record Item
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string Name { get; init; }     

        public decimal Price { get; init; }

        public DateTimeOffset CreatedOn { get; init; }
        
    }
}