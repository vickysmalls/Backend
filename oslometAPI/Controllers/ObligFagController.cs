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

        private readonly IObligFagsRepository _db;
        private ILogger<ObligFagController> _log;

        public ObligFagController(IObligFagsRepository dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public async Task<List<ObligFags>> GetObligFag()
        {
            return await _db.GetObligFag();
        }

        // GET: api/ObligFag/5
        [HttpGet("{id}")]
        public async Task<ObligFags> GetObligFag(int id)
        {

            return await _db.GetObligFag(id);
        }
    }
}