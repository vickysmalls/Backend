﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace oslometAPI.Models
{
    public class MasterFag
    {
        public int Id { get; set; }
        public string Fagnavn { get; set; }
        public int KlasseId { get; set; }

    }
}
