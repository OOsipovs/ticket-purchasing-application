using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; } 
        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Name is requird")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
