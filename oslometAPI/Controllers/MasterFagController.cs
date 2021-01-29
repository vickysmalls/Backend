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
    public class MasterFagController : ControllerBase
    {
        
        private readonly oslometContext _db;
        private ILogger<MasterFagController> _log;

        public MasterFagController(oslometContext dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public ActionResult<IEnumerable<MasterFag>> GetMasterFag()
        {
            var masterfags = _db.MasterFag.ToList();
            return masterfags;
        }

        // GET: api/MasterFag/5
        [HttpGet("{id}")]
        public ActionResult<MasterFag> GetMasterFag(int id)

        {
            var masterfag = _db.MasterFag.Find(id);

            if (masterfag == null)
            {
                _log.LogInformation("Fant ikke masterfag");
                return NotFound();
            }

            return masterfag;
        }

    }
}
