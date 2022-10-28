namespace Catalog.Entities
{
    //This is a model
    public record Item
    {
        //Id of the model
        public Guid Id { get; set; }
        //Name attribute
        public string Name { get; set; }
        //Price attribute
        public decimal Price { get; set; }
        //Created date attribute
        public DateTime CreatedDate { get; set; }   
    }
}
