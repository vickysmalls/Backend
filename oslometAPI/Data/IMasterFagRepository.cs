using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public interface IMasterFagRepository
    {
        Task<List<MasterFag>> GetMasterFag();
        Task<MasterFag> GetMasterFag(int id);
        Task<MasterFag> GetMasterFagByKategori(int id);
    }
}
