using MovieSwiper.DTOs.Review;

namespace MovieSwiper.Services.ReviewService
{
    public interface IReviewService
    {
        Task<ReviewCreateDto> CreateAsync(ReviewCreateDto reviewDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<ReviewDto>> GetAllAsync();
        Task<ReviewDto> GetByIdAsync(int id);
        Task<ReviewCreateDto> UpdateAsync(int id, ReviewCreateDto reviewDto);
    }
}
