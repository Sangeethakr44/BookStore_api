namespace BookStore.Models.Entities
{
    public class BookMaster
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl {  get; set; }
        public double Price { get; set; }
        public int StockCount {  get; set; } 
        public string? Categories { get; set; }
        public int CategoryId { get; set; }
        public string? Author {  get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
