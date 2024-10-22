using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Dtos
{
    public class AddCustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string? Gender { get; set; }
        public int PinCode { get; set; }
        public DateTime? DOB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class AddOrderDetailsDto
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class AddBooksDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }

    public class AddBookRatingDto
    {
        public string BookId { get; set; }
        public string Review { get; set; }
        public string Remarks { get; set; }
        public string CustomerId { get; set; }
    }

    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }

}
