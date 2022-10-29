using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record AddItemDto
    {
        //Name attribute
        [Required]
        public string Name { get; init; }
        //Price attribute
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; init; }
        //Created date attribute
    }
}
