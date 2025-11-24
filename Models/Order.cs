using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ghazal.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime? Date { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
