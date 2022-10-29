namespace Catalog.Dtos
{
    public record AddItemDto
    {
        //Name attribute
        public string Name { get; init; }
        //Price attribute
        public decimal Price { get; init; }
        //Created date attribute
    }
}
