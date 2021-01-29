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
    public class ObligFagController : ControllerBase
    {

        private readonly oslometContext _db;
        private ILogger<ObligFagController> _log;

        public ObligFagController(oslometContext dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public ActionResult<IEnumerable<ObligFags>> GetObligFag()
        {
            var obligfag = _db.ObligFag.ToList();
            return obligfag;
        }

        // GET: api/ObligFag/5
        [HttpGet("{id}")]
        public ActionResult<ObligFags> GetObligFag(int id)

        {

            var obligfag = _db.ObligFag.Find(id);

            if (obligfag == null)
            {
                _log.LogInformation("Obligfag ikke funnet");
                return NotFound();
            }
            return obligfag;



        }
    }
}