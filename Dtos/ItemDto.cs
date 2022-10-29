namespace Catalog.Dtos
{
    public record ItemDto
    {
        //Id of the model
        public Guid Id { get; init; }
        //Name attribute
        public string Name { get; init; }
        //Price attribute
        public decimal Price { get; init; }
        //Created date attribute
        public DateTime CreatedDate { get; set; }
    }
}
