using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oslometAPI.Models
{
    public class Muligheter
    {
        public int Id { get; set; }
        public int KlasseId { get; set; }
        public int MasterFagId { get; set; }
        public string Fagnavn { get; set; }
        public string Emnekode { get; set; }
        public int Semester { get; set; }
        public string Studiepoeng { get; set; }
        public string URL { get; set; }
        public string URL2 { get; set; }
        public string URL3 { get; set; }
        public Klasser Klasser { get; set; }
        public MasterFag MasterFag { get; set; }

    }
}
