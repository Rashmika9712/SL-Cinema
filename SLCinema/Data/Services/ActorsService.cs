using Microsoft.EntityFrameworkCore;
using SLCinema.Data.Base;
using SLCinema.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLCinema.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) {} 
       
    }
}
