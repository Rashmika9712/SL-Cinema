using SLCinema.Data.Base;
using SLCinema.Models;

namespace SLCinema.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService 
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
