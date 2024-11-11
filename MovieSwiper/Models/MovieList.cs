using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSwiper.Models
{
    public class MovieList
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; } 
        public string? UserId { get; set; } 

        public List<MovieListItem> Items { get; set; } = new List<MovieListItem>();
    }

}
