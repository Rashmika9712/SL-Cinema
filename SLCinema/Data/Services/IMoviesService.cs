using SLCinema.Data.Base;
using SLCinema.Data.ViewModels;
using SLCinema.Models;
using System.Threading.Tasks;

namespace SLCinema.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
