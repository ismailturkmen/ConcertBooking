using ConcertBooking.Application.Common;
using ConcertBooking.Domain.Models;
using ConcertBooking.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Infrastructure.Repository
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        private readonly ApplicationDbContext _context;

        public ArtistRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void UpdateArtist(Artist artist)
        {
            _context.Artists.Update(artist);
        }
    }
}
