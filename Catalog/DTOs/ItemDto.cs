using System;

namespace Catalog.DTOs
{
    public record ItemDto
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string Name { get; init; }     

        public decimal Price { get; init; }

        public DateTimeOffset CreatedOn { get; init; }
        
    }
}