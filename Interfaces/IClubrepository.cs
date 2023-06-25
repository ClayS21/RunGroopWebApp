using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IClubrepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetByIdAsync(int id);
        Task<IEnumerable<Club>> GetClubByCity(string city);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();
    }
}