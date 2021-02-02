﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oslometAPI.Models
{
    public class FylleFags
    {
        public int Id { get; set; }
        public string Fagnavn { get; set; }
        public string Emnekode { get; set; }
        public int KlasseId { get; set; }
        public int Semester { get; set; }
        public Klasser Klasser { get; set; }
    }
}
