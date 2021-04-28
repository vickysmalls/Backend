using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public interface IMuligheterRepository
    {
        Task<List<Muligheter>> GetMuligheter();
        Task<Muligheter> GetMuligheter(int id);
        
    }
}
