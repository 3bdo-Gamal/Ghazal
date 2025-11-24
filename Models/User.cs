using System.ComponentModel.DataAnnotations;

namespace Ghazal.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(20)]
        public string PhoneNumberPrimary { get; set; }

        [MaxLength(150)]
        public string EmailAddress { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        public bool IsAdmin { get; set; }

        [MaxLength(20)]
        public string PhoneNumberSecondary { get; set; }

        [MaxLength(255)]
        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Cart> Carts { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<WishList> Wishlists { get; set; }
    }
}
