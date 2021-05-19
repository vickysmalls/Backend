using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oslometAPI.Data;
using oslometAPI.Models;

namespace oslometAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlasserController : ControllerBase
    {

        private readonly IKlasserRepository _db;
        private ILogger<KlasserController> _log;

        public KlasserController(IKlasserRepository dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Klasser
        [HttpGet]
        public async Task<List<Klasser>> GetKlasser()
        {
            return await _db.GetKlasser();
        }

        // GET: api/Klasser/5
        [HttpGet("{id}")]
        public async Task<Klasser> GetKlasser(int id)
        {
            return await _db.GetKlasser(id);
        }
    }
}
