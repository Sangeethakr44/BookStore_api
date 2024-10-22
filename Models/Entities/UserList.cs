using Microsoft.AspNetCore.Identity;

namespace BookStore.Models.Entities
{
    public class UserList:IdentityUser
    {
        public Guid Id { get; set; }
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
        public int RoleId { get; set; } 
    }
}
