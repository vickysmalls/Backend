using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public interface IObligFagsRepository
    {
        Task<List<ObligFags>> GetObligFag();
        Task<ObligFags> GetObligFag(int id);
    }
}
