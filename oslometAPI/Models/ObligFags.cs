using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace oslometAPI.Models
{
    public class ObligFags
    {
        public int Id { get; set; }
        public string Fagnavn { get; set; }
        public int KlasseId { get; set; }
        public Klasser Klasser { get; set; }
    }
}
