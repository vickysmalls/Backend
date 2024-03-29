﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oslometAPI.Models;

namespace oslometAPI.Data
{
    public class oslometContext : DbContext
    {
        public oslometContext(DbContextOptions<oslometContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Klasser> Klasse { get; set; }
        public DbSet<ObligFags> ObligFag { get; set; }
        public DbSet<MasterFag> MasterFag { get; set; }
        public DbSet<Muligheter> Mulighet { get; set; }
    }
}
