using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ghazal.Models
{
    public class WishList
    {
        [Key]
        public int WishlistId { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }

        public ICollection<WishListItem> WishlistItems { get; set; }
    }
}
