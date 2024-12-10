using ConcertBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Services.Interfaces
{
    public interface IConcertService
    {
        IEnumerable<Concert> GetAllConcert();
        Concert GetConcert(int id);
        Task SaveConcert(Concert concert);
        Task DeleteConcert(Concert concert);
        void UpdateConcert(Concert concert);
    }
}
