using MovieSwiper.DTOs.MovieListItem;

namespace MovieSwiper.Services.MovieListItemService
{
    public interface IMovieListItemService
    {
        Task<MovieListItemDto> AddAsync(MovieListItemDto movieListItemDto);
        Task<MovieListItemDto> DeleteAsync(MovieListItemDto movieListItemDto);
    }
}
