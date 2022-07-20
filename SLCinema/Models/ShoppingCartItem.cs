using System.ComponentModel.DataAnnotations;

namespace SLCinema.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        
        public Movie Movie { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public int Amount { get; set; }
        
        public string ShoppingCartId { get; set; }
    }
}
