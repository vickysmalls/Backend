using Microsoft.EntityFrameworkCore;
using oslometAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oslometAPI.Data
{

    public class KlasserRepository : IKlasserRepository
    {

        private readonly oslometContext _db;

        public KlasserRepository(oslometContext db)
        {

            _db = db;

        }

        public async Task<List<Klasser>> GetKlasser()
        {

            try
            {
                List<Klasser> alleKlasser = await _db.Klasse.Select(k => new Klasser
                {
                    Id = k.Id,
                    Klassetrinn = k.Klassetrinn,

                }).ToListAsync();
                return alleKlasser;
            }
            catch
            {
                return null;
            }

        }

        public async Task<Klasser> GetKlasser(int id)
        {

            Klasser enKlasse = await _db.Klasse.FindAsync(id);
            var hentKlasse = new Klasser()
            {
                Id = enKlasse.Id,
                Klassetrinn = enKlasse.Klassetrinn,
           
            };
            return hentKlasse;

        }

    }

}
