using MovieSwiper.DTOs.Movie;
using MovieSwiper.DTOs.Rating;

namespace MovieSwiper.Services.RatingService
{
    public interface IRatingService
    {
        Task<RatingCreateDto> CreateAsync(RatingCreateDto ratingCreateDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<RatingDto>> GetAllAsync();
        Task<RatingDto> GetByIdAsync(int id);
        Task<RatingDto> UpdateAsync(int id, RatingCreateDto ratingCreateDto);
    }
}
