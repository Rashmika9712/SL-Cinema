using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCinema.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie id is required")]
        [Display(Name ="Movie id")]
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }


        [Required(ErrorMessage = "Order id is required")]
        [Display(Name = "Order id")]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
