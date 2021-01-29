using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oslometAPI.Data;
using oslometAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oslometAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuligheterController : ControllerBase
    {

        private readonly oslometContext _db;
        private ILogger<MuligheterController> _log;

        public MuligheterController(oslometContext dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public ActionResult<IEnumerable<Muligheter>> GetMasterFag()
        {
            var muligheter = _db.Mulighet.ToList();
            return muligheter;
        }

        // GET: api/Muligheter/5
        [HttpGet("{id}")]
        public ActionResult<Muligheter> GetMasterFag(int id)

        {
            var muligheter = _db.Mulighet.Find(id);

            if (muligheter == null)
            {
                _log.LogInformation("Fant ikke kategori");
                return NotFound();
            }

            return muligheter;
        }


        [HttpGet("GetMasterFagByKlasser/{id}")]
        public IQueryable<MasterFag> GetMasterFagByKategori(int id)
        {
            Klasser klasser = new Klasser();
            if (id != klasser.Id)
            {
                _log.LogInformation("Fant ikke master basert på klasse id");
                return (IQueryable<MasterFag>)NotFound();
            }
            var masterByKat = _db.MasterFag.Where(q => q.KlasseId == id);
            return (IQueryable<MasterFag>)Ok(masterByKat);

        }

    }
}
