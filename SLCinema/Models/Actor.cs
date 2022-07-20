using SLCinema.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SLCinema.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name ="Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
