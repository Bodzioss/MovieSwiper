using MovieSwiper.DTOs.MovieList;
using MovieSwiper.DTOs.MovieListItem;

namespace MovieSwiper.Services.MovieListService
{
    public interface IMovieListService
    {
        Task<IEnumerable<MovieListDto>> GetAllAsync();
        Task<MovieListCreateDto> CreateAsync(MovieListCreateDto movieListCreateDto, string userId);
        Task<MovieListDto> DeleteAsync(MovieListDto movieListDto);
        Task AddMovieToListAsync(int movieListId, MovieListItemDto movieListItemDto);
        Task RemoveMovieFromListAsync(int movieListId, MovieListItemDto movieListItemDto);
        Task<MovieListCreateDto> UpdateAsync(MovieListCreateDto movieListCreateDto);
        Task<MovieListDto> GetByIdAsync(int id);
    }

}
