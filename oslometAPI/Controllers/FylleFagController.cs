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
    public class FylleFagController : ControllerBase
    {

        private readonly oslometContext _db;
        private ILogger<ObligFagController> _log;

        public FylleFagController(oslometContext dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public ActionResult<IEnumerable<FylleFags>> GetFylleFag()
        {
            var fyllefag = _db.FylleFag.ToList();
            return fyllefag;
        }

        // GET: api/ObligFag/5
        [HttpGet("{id}")]
        public ActionResult<FylleFags> GetFylleFag(int id)

        {

            var fyllefag = _db.FylleFag.Find(id);

            if (fyllefag == null)
            {
                _log.LogInformation("Fyllefag ikke funnet");
                return NotFound();
            }
            return fyllefag;



        }
    }
}