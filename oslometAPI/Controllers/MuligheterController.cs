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
    public class MuligheterController : ControllerBase
    {

        private readonly IMuligheterRepository _db;
        private ILogger<MuligheterController> _log;

        public MuligheterController(IMuligheterRepository dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public async Task<List<Muligheter>> GetMuligheter()
        {
            return await _db.GetMuligheter();
        }

        // GET: api/Muligheter/5
        [HttpGet("{id}")]
        public async Task<Muligheter> GetMuligheter(int id)
        {
            return await _db.GetMuligheter(id);
        }
    }
}
