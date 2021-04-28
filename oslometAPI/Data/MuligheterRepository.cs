using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public class MuligheterRepository : IMuligheterRepository
    {
        private readonly oslometContext _db;

        public MuligheterRepository(oslometContext db)
        {
            _db = db;
        }

        public async Task<List<Muligheter>> GetMuligheter()
        {
            try
            {
                List<Muligheter> alleMuligheter = await _db.Mulighet.Select(m => new Muligheter
                {
                    Id = m.Id,
                    KlasseId = m.KlasseId,
                    MasterFagId = m.MasterFagId,
                    Fagnavn = m.Fagnavn,
                    Emnekode = m.Emnekode,
                    Semester = m.Semester,
                    Studiepoeng = m.Studiepoeng,
                    URL = m.URL,
                    URL2 = m.URL2,
                    URL3 = m.URL3,



                }).ToListAsync();
                return alleMuligheter;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Muligheter> GetMuligheter(int id)
        {
            Muligheter enMulighet = await _db.Mulighet.FindAsync(id);
            var hentMulighet = new Muligheter()
            {
                Id = enMulighet.Id,
                KlasseId = enMulighet.KlasseId,
                MasterFagId = enMulighet.MasterFagId,
                Fagnavn = enMulighet.Fagnavn,
                Emnekode = enMulighet.Emnekode,
                Semester = enMulighet.Semester,
                Studiepoeng = enMulighet.Studiepoeng,
                URL = enMulighet.URL,
                URL2 = enMulighet.URL2,
                URL3 = enMulighet.URL3,

            };
            return hentMulighet;
        }

    }
}


