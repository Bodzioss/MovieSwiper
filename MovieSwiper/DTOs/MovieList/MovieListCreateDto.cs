using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieSwiper.DTOs.MovieList
{
    public class MovieListCreateDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserId { get; set; }

    }

}
