using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record CreateItemDto
    {
        [Required]
        [MaxLength(35)]
        public string Name { get; init; }

        [Required]
        [Range(1,1000)]
        public decimal Price {get; init; }
    }
}