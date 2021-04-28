using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public class MasterFagRepository : IMasterFagRepository
    {
        private readonly oslometContext _db;

        public MasterFagRepository(oslometContext db)
        {
            _db = db;
        }

        public async Task<List<MasterFag>> GetMasterFag()
        {
            try
            {
                List<MasterFag> alleMasterFag = await _db.MasterFag.Select(m => new MasterFag
                {
                    Id = m.Id,
                    Fagnavn = m.Fagnavn,
                    KlasseId = m.KlasseId,

                }).ToListAsync();
                return alleMasterFag;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MasterFag> GetMasterFag(int id)
        {
            MasterFag etMasterFag = await _db.MasterFag.FindAsync(id);
            var hentMasterFag = new MasterFag()
            {
                Id = etMasterFag.Id,
                Fagnavn = etMasterFag.Fagnavn,
                KlasseId = etMasterFag.KlasseId

            };
            return hentMasterFag;
        }
      
        public async Task<MasterFag> GetMasterFagByKategori(int id)
        {
            MasterFag masterFagKategori = await _db.MasterFag.FindAsync(id);
            Klasser klasser = new Klasser()
            {
                Id = masterFagKategori.Id,

            };
          
            if (id != klasser.Id)
            {
                return null;
            }
            var masterByKat = _db.MasterFag.Where(q => q.KlasseId == id);
            return (MasterFag)masterByKat;

        }
    }

}
