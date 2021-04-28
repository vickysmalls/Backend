using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public interface IKlasserRepository
    {
        Task<List<Klasser>> GetKlasser();
        Task<Klasser> GetKlasser(int id);
    }
}
