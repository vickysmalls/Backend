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
        
        private readonly IMasterFagRepository _db;
        private ILogger<MasterFagController> _log;

        public MasterFagController(IMasterFagRepository dB)
        {
            _log = _log;
            _db = dB;
        }

        // GET: api/Kategori
        [HttpGet]
        public async Task<List<MasterFag>> GetMasterFag()
        {
            return await _db.GetMasterFag();
        }

        // GET: api/MasterFag/5
        [HttpGet("{id}")]
        public async Task<MasterFag> GetMasterFag(int id)
        {
            return await _db.GetMasterFag(id);
        }

        [HttpGet("GetMasterFagByKlasser/{id}")]
        public async Task<MasterFag> GetMasterFagByKategori(int id)

        {
            return await _db.GetMasterFagByKategori(id);
        }

    }
}
