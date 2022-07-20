using SLCinema.Data.Base;
using SLCinema.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCinema.Models
{
    public class Movie:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price{ get; set; }

        [Display(Name ="Image URL")]
        public string ImageURL { get; set; }

        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name ="End Date")]
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }



        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
