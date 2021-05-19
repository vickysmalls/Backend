﻿using System;
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
        public string Emnekode { get; set; }
        public int Semester { get; set; }
        public string Studiepoeng { get; set; }
        public string URL { get; set; }
        public string URL2 { get; set; }
        public int KlasseId { get; set; }
    }
}
