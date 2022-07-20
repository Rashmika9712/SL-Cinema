using SLCinema.Data.Base;
using SLCinema.Models;

namespace SLCinema.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context): base(context) {}
    }    
}
