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
    public class KlasserController : ControllerBase
    {

        private readonly oslometContext _db;
        private ILogger<KlasserController> _log;

        public KlasserController(oslometContext dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Klasser
        [HttpGet]
        public ActionResult<IEnumerable<Klasser>> GetKlasser()
        {
            var klasser = _db.Klasse.ToList();
            return klasser;
        }

        // GET: api/Klasser/5
        [HttpGet("{id}")]
        public ActionResult<Klasser> GetKlasser(int id)

        {
            var klasser = _db.Klasse.Find(id);

            if (klasser == null)
            {
                _log.LogInformation("Fant ikke klassen");
                return NotFound();
            }

            return klasser;
        }

    }
}
