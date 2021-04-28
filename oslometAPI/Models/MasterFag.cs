using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oslometAPI.Models
{
    public class MasterFag
    {
        public int Id { get; set; }
        public string Fagnavn { get; set; }
        public int KlasseId { get; set; }
       // public Klasser Klasser { get; set; }

    }
}
