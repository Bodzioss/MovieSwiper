using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSwiper.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; } 
        public string UserId { get; set; } 

        [ForeignKey("MovieId")] 
        public Movie Movie { get; set; }

        [ForeignKey("UserId")]  
        User User { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
