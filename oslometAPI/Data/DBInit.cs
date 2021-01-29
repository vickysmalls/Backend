using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using oslometAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace oslometAPI.Data
{
    //Sletter og oppretter databasen, initialiserer informasjon som skal være i databasen ved opprettelse
    public static class DBInit
    {
        public static void Seed(IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.CreateScope();
            {
                var context = serviceScope.ServiceProvider.GetService<oslometContext>();

                // må slette og opprette databasen hver gang når den skal initieres (seed`es)
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                // Klasser/klassetrinn
                var klasse1 = new Klasser();
                klasse1.Id = 1;
                klasse1.Klassetrinn = "1-7";
                context.Add(klasse1);

                var klasse2 = new Klasser();
                klasse2.Id = 2;
                klasse2.Klassetrinn = "5-10";
                context.Add(klasse2);


                //Oblig fags
                var oblig1 = new ObligFags();
                oblig1.Id = 1;
                oblig1.Fagnavn = "Matte";
                oblig1.KlasseId = 1;
                context.Add(oblig1);

                var oblig2 = new ObligFags();
                oblig2.Id = 2;
                oblig2.Fagnavn = "Engelsk";
                oblig2.KlasseId = 1;
                context.Add(oblig2);

                var oblig3 = new ObligFags();
                oblig3.Id = 3;
                oblig3.Fagnavn = "Norsk";
                oblig3.KlasseId = 1;
                context.Add(oblig3);

                var oblig4 = new ObligFags();
                oblig4.Id = 4;
                oblig4.Fagnavn = "Matte";
                oblig4.KlasseId = 2;
                context.Add(oblig4);

                var oblig5 = new ObligFags();
                oblig5.Id = 5;
                oblig5.Fagnavn = "Engelsk";
                oblig5.KlasseId = 2;
                context.Add(oblig5);

                var oblig6 = new ObligFags();
                oblig6.Id = 6;
                oblig6.Fagnavn = "Norsk";
                oblig6.KlasseId = 2;
                context.Add(oblig6);


                //Masterfag
                
                var masterfag1 = new MasterFag();
                masterfag1.Id = 1;
                masterfag1.Fagnavn = "Matte";
                masterfag1.KlasseId = 1;
                context.Add(masterfag1);

                var masterfag2 = new MasterFag();
                masterfag2.Id = 2;
                masterfag2.Fagnavn = "Engelsk";
                masterfag2.KlasseId = 1;
                context.Add(masterfag2);

                var masterfag3 = new MasterFag();
                masterfag3.Id = 3;
                masterfag3.Fagnavn = "Pedagogikk";
                masterfag3.KlasseId = 1;
                context.Add(masterfag3);

                var masterfag4 = new MasterFag();
                masterfag4.Id = 4;
                masterfag4.Fagnavn = "Matte";
                masterfag4.KlasseId = 2;
                context.Add(masterfag4);

                var masterfag5 = new MasterFag();
                masterfag5.Id = 5;
                masterfag5.Fagnavn = "Engelsk";
                masterfag5.KlasseId = 2;
                context.Add(masterfag5);

                var masterfag6 = new MasterFag();
                masterfag6.Id = 6;
                masterfag6.Fagnavn = "Pedagogikk";
                masterfag6.KlasseId = 2;
                context.Add(masterfag6);

                //muligheter 1-7 trinn
                var muligheter1 = new Muligheter();
                muligheter1.Id = 1;
                muligheter1.Fagnavn = "Krle";
                muligheter1.MasterFagId = 1;
                context.Add(muligheter1);

                var muligheter2 = new Muligheter();
                muligheter2.Id = 2;
                muligheter2.Fagnavn = "Gym";
                muligheter2.MasterFagId = 1;
                context.Add(muligheter2);

                var muligheter3 = new Muligheter();
                muligheter3.Id = 3;
                muligheter3.Fagnavn = "Naturfag";
                muligheter3.MasterFagId = 1;
                context.Add(muligheter3);

                //Muligheter 5-10 trinn
                var muligheter4 = new Muligheter();
                muligheter4.Id = 4;
                muligheter4.Fagnavn = "Krle";
                muligheter4.MasterFagId = 2;
                context.Add(muligheter4);

                var muligheter5 = new Muligheter();
                muligheter5.Id = 5;
                muligheter5.Fagnavn = "Krle";
                muligheter5.MasterFagId = 2;
                context.Add(muligheter5);

                var muligheter6 = new Muligheter();
                muligheter6.Id = 6;
                muligheter6.Fagnavn = "Naturfag";
                muligheter6.MasterFagId = 2;
                context.Add(muligheter6);


                


                context.SaveChanges();
            }
        }
    }
}
