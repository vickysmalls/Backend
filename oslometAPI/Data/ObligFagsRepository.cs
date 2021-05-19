using Microsoft.EntityFrameworkCore;
using oslometAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oslometAPI.Data
{
    public class ObligFagsRepository : IObligFagsRepository
    {

        private readonly oslometContext _db;

        public ObligFagsRepository(oslometContext db)
        {
            _db = db;
        }

        public async Task<List<ObligFags>> GetObligFag()
        {
            try
            {
                List<ObligFags> alleObligFag = await _db.ObligFag.Select(o => new ObligFags
                {
                    Id = o.Id,
                    Fagnavn = o.Fagnavn,
                    Emnekode = o.Emnekode,
                    Semester = o.Semester,
                    Studiepoeng = o.Studiepoeng,
                    URL = o.URL,
                    URL2 = o.URL2,
                    KlasseId = o.KlasseId,

                }).ToListAsync();
                    return alleObligFag;
                }
                catch
                {
                return null;
            }
        }

        public async Task<ObligFags> GetObligFag(int id)
        {
            ObligFags etObligFag = await _db.ObligFag.FindAsync(id);
            var hentetObligFag = new ObligFags()
            {
                Id = etObligFag.Id,
                Fagnavn = etObligFag.Fagnavn,
                Emnekode = etObligFag.Emnekode,
                Semester = etObligFag.Semester,
                Studiepoeng = etObligFag.Studiepoeng,
                URL = etObligFag.URL,
                URL2 = etObligFag.URL2,
                KlasseId = etObligFag.KlasseId,

            };
            return hentetObligFag;
        }
    }
}
