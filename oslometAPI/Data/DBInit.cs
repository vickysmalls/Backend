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


                // Klassetrinn 1-7
                var klasse1 = new Klasser();
                klasse1.Id = 1;
                klasse1.Klassetrinn = "1-7";
                context.Add(klasse1);

                //Oblig fags 1-7

                //obligatorisk mattefag
                var oblig_matte1 = new ObligFags();
                oblig_matte1.Id = 1;
                oblig_matte1.KlasseId = 1;
                oblig_matte1.Fagnavn = "Matematikk 1, emne 1";
                oblig_matte1.Semester = 1;
                oblig_matte1.Emnekode = "M1GMT1100";
                oblig_matte1.Studiepoeng = "10";
                oblig_matte1.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GMT1100/2021/H%C3%98ST";
                context.Add(oblig_matte1);

                var oblig_matte2 = new ObligFags();
                oblig_matte2.Id = 2;
                oblig_matte2.KlasseId = 1;
                oblig_matte2.Fagnavn = "Matematikk 1, emne 2";
                oblig_matte2.Semester = 2;
                oblig_matte2.Emnekode = "M1GMT1200";
                oblig_matte2.Studiepoeng = "10";
                oblig_matte2.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GMT1200/2021/H%C3%98ST";
                context.Add(oblig_matte2);

                var oblig_matte3 = new ObligFags();
                oblig_matte3.Id = 3;
                oblig_matte3.KlasseId = 1;
                oblig_matte3.Fagnavn = "Matematikk 1, emne 3";
                oblig_matte3.Semester = 3;
                oblig_matte3.Emnekode = "M1GMT2100";
                oblig_matte3.Studiepoeng = "10";
                oblig_matte3.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GMT2100/2021/H%C3%98ST";
                context.Add(oblig_matte3);


                //obligatorisk norskfag
                var oblig_norsk1 = new ObligFags();
                oblig_norsk1.Id = 4;
                oblig_norsk1.KlasseId = 1;
                oblig_norsk1.Fagnavn = "Norsk 1, emne 1";
                oblig_norsk1.Semester = 1;
                oblig_norsk1.Emnekode = "M1GNO1100";
                oblig_norsk1.Studiepoeng = "10";
                oblig_norsk1.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GNO1100/2021/H%C3%98ST";
                context.Add(oblig_norsk1);

                var oblig_norsk2 = new ObligFags();
                oblig_norsk2.Id = 5;
                oblig_norsk2.KlasseId = 1;
                oblig_norsk2.Fagnavn = "Norsk 1, emne 2";
                oblig_norsk2.Semester = 2;
                oblig_norsk2.Emnekode = "M1GNO1200";
                oblig_norsk2.Studiepoeng = "10";
                oblig_norsk2.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GNO1200/2021/H%C3%98ST";
                context.Add(oblig_norsk2);

                var oblig_norsk3 = new ObligFags();
                oblig_norsk3.Id = 6;
                oblig_norsk3.KlasseId = 1;
                oblig_norsk3.Fagnavn = "Norsk 1, emne 3";
                oblig_norsk3.Semester = 3;
                oblig_norsk3.Emnekode = "M1GNO2100";
                oblig_norsk3.Studiepoeng = "10";
                oblig_norsk3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GNO2100/2021/H%C3%98ST";
                context.Add(oblig_norsk3);


                //obligatoriske PEL og VM
                //PEL1
                var oblig_pel = new ObligFags();
                oblig_pel.Id = 7;
                oblig_pel.KlasseId = 1;
                oblig_pel.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 1";
                oblig_pel.Semester = 1;
                oblig_pel.Emnekode = "M1GPE1100";
                oblig_pel.Studiepoeng = "10";
                oblig_pel.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GPE1100/2021/H%C3%98ST";
                context.Add(oblig_pel);

                //PEL2
                var oblig_pel2 = new ObligFags();
                oblig_pel2.Id = 8;
                oblig_pel2.KlasseId = 1;
                oblig_pel2.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 2";
                oblig_pel2.Semester = 2;
                oblig_pel2.Emnekode = "M1GPE1200";
                oblig_pel2.Studiepoeng = "10";
                oblig_pel2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GPE1200/2021/H%C3%98ST";
                context.Add(oblig_pel2);

                //PEL3
                var oblig_pel3 = new ObligFags();
                oblig_pel3.Id = 9;
                oblig_pel3.KlasseId = 1;
                oblig_pel3.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 3";
                oblig_pel3.Semester = 3;
                oblig_pel3.Emnekode = "M1GPE1200";
                oblig_pel3.Studiepoeng = "10";
                oblig_pel3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GPE2100/2021/H%C3%98ST";
                context.Add(oblig_pel3);

                //PEL4
                var oblig_pel4 = new ObligFags();
                oblig_pel4.Id = 10;
                oblig_pel4.KlasseId = 1;
                oblig_pel4.Fagnavn = "Pedagogikk og elevkunnskap 2, emne 1";
                oblig_pel4.Semester = 8;
                oblig_pel4.Emnekode = "M1GPE4100";
                oblig_pel4.Studiepoeng = "15";
                oblig_pel4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GPE4100/2021/H%C3%98ST";
                context.Add(oblig_pel4);

                //PEL5
                var oblig_pel5 = new ObligFags();
                oblig_pel5.Id = 11;
                oblig_pel5.KlasseId = 1;
                oblig_pel5.Fagnavn = "Pedagogikk og elevkunnskap 2, emne 2";
                oblig_pel5.Semester = 9;
                oblig_pel5.Emnekode = "M1GPE5100";
                oblig_pel5.Studiepoeng = "15";
                oblig_pel5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GPE5100/2021/H%C3%98ST";
                context.Add(oblig_pel5);

                //V&M
                var oblig_VM = new ObligFags();
                oblig_VM.Id = 12;
                oblig_VM.KlasseId = 1;
                oblig_VM.Fagnavn = "Vitenskapsteori og metodikk";
                oblig_VM.Semester = 7;
                oblig_VM.Emnekode = "MGVM4100";
                oblig_VM.Studiepoeng = "15";
                oblig_VM.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGVM4100/2021/H%C3%98ST";
                context.Add(oblig_VM);


                //Masterfag 1 Norsk
                var masterfag_norsk = new MasterFag();
                masterfag_norsk.Id = 1;
                masterfag_norsk.KlasseId = 1;
                masterfag_norsk.Fagnavn = "Norsk";
                context.Add(masterfag_norsk);

                    //muligheter masterFagId 1
                    var norsk_muligheter1 = new Muligheter();
                    norsk_muligheter1.Id = 1;
                    norsk_muligheter1.MasterFagId = 1;
                    norsk_muligheter1.KlasseId = 1;
                    norsk_muligheter1.Fagnavn = "Norsk 2, emne 4";
                    norsk_muligheter1.Semester = 5;
                    norsk_muligheter1.Emnekode = "M1GNO3100";
                    norsk_muligheter1.Studiepoeng = "30";
                    norsk_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GNO3100/2021/H%C3%98ST";
                    context.Add(norsk_muligheter1);

                    //muligheter masterFagId 1
                    var norsk_muligheter2 = new Muligheter();
                    norsk_muligheter2.Id = 2;
                    norsk_muligheter2.MasterFagId = 1;
                    norsk_muligheter2.Fagnavn = "Norsk og norskdidaktikk 1";
                    norsk_muligheter2.Semester = 7;
                    norsk_muligheter2.Emnekode = "MGNO4100";
                    norsk_muligheter2.Studiepoeng = "15";
                    norsk_muligheter2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNO4100/2021/H%C3%98ST";
                    context.Add(norsk_muligheter2);

                    //muligheter masterFagId 1
                    var norsk_muligheter3 = new Muligheter();
                    norsk_muligheter3.Id = 3;
                    norsk_muligheter3.MasterFagId = 1;
                    norsk_muligheter3.Fagnavn = "Norsk og norskdidaktikk 2";
                    norsk_muligheter3.Semester = 8;
                    norsk_muligheter3.Emnekode = "MGNO4200";
                    norsk_muligheter3.Studiepoeng = "15";
                    norsk_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNO4200/2021/H%C3%98ST";
                    context.Add(norsk_muligheter3);

                    //muligheter masterFagId 1
                    var norsk_muligheter4 = new Muligheter();
                    norsk_muligheter4.Id = 4;
                    norsk_muligheter4.MasterFagId = 1;
                    norsk_muligheter4.Fagnavn = "Norsk og norskdidaktikk 3";
                    norsk_muligheter4.Semester = 9;
                    norsk_muligheter4.Emnekode = "MGNO5100";
                    norsk_muligheter4.Studiepoeng = "15";
                    norsk_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNO5100/2021/H%C3%98ST";
                    context.Add(norsk_muligheter4);

                    //muligheter masterFagId 1 MASTERSØK
                    var norsk_muligheter5 = new Muligheter();
                    norsk_muligheter5.Id = 5;
                    norsk_muligheter5.MasterFagId = 1;
                    norsk_muligheter5.Fagnavn = "Masteroppgave i norsk";
                    norsk_muligheter5.Semester = 10;
                    norsk_muligheter5.Emnekode = "";
                    norsk_muligheter5.Studiepoeng = "30";
                    context.Add(norsk_muligheter5);


                //Masterfag 2 Matte
                var masterfag_matte = new MasterFag();
                masterfag_matte.Id = 2;
                masterfag_matte.KlasseId = 1;
                masterfag_matte.Fagnavn = "Matematikk";
                context.Add(masterfag_matte);

                    //Muligheter masterFagId 2
                    var matte_muligheter1 = new Muligheter();
                    matte_muligheter1.Id = 6;
                    matte_muligheter1.MasterFagId = 2;
                    matte_muligheter1.KlasseId = 1;
                    matte_muligheter1.Fagnavn = "Matematikk 2, emne 4";
                    matte_muligheter1.Semester = 5;
                    matte_muligheter1.Emnekode = "M1GMT3100";
                    matte_muligheter1.Studiepoeng = "30";
                    matte_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GMT3100/2021/H%C3%98ST";
                    context.Add(matte_muligheter1);

                    //Muligheter masterFagId 2
                    var matte_muligheter2 = new Muligheter();
                    matte_muligheter2.Id = 7;
                    matte_muligheter2.MasterFagId = 2;
                    matte_muligheter2.Fagnavn = "Matematikk og matematikkdidaktikk 1";
                    matte_muligheter2.Semester = 7;
                    matte_muligheter2.Emnekode = "MGMT4100";
                    matte_muligheter2.Studiepoeng = "15";
                    matte_muligheter2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT4100/2021/H%C3%98ST";
                    context.Add(matte_muligheter2);

                    //Muligheter masterFagId 2
                    var matte_muligheter3 = new Muligheter();
                    matte_muligheter3.Id = 8;
                    matte_muligheter3.MasterFagId = 2;
                    matte_muligheter3.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                    matte_muligheter3.Semester = 8;
                    matte_muligheter3.Emnekode = "MGMT4200";
                    matte_muligheter3.Studiepoeng = "15";
                    matte_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT4200/2021/H%C3%98ST";
                    context.Add(matte_muligheter3);

                    //Muligheter masterFagId 2
                    var matte_muligheter4 = new Muligheter();
                    matte_muligheter4.Id = 9;
                    matte_muligheter4.MasterFagId = 2;
                    matte_muligheter4.Fagnavn = "Matematikk og matematikkdidaktikk 3";
                    matte_muligheter4.Semester = 9;
                    matte_muligheter4.Emnekode = "MGMT5100";
                    matte_muligheter4.Studiepoeng = "15";
                    matte_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT5100/2021/H%C3%98ST";
                    context.Add(matte_muligheter4);

                    //Muligheter masterFagId 2 MASTERSØK
                    var matte_muligheter5 = new Muligheter();
                    matte_muligheter5.Id = 10;
                    matte_muligheter5.MasterFagId = 2;
                    matte_muligheter5.Fagnavn = "Masteroppgave i matematikk";
                    matte_muligheter5.Semester = 10;
                    matte_muligheter5.Emnekode = "";
                    matte_muligheter5.Studiepoeng = "30";
                    context.Add(matte_muligheter5);


                //Masterfag 3 brukeropplæring
                var brukeropplæring = new MasterFag();
                brukeropplæring.Id = 3;
                brukeropplæring.KlasseId = 1;
                brukeropplæring.Fagnavn = "Begynneropplæring";
                context.Add(brukeropplæring);

                    //Muligheter masterFagId 3
                    var opplæring_fyll = new Muligheter();
                    opplæring_fyll.Id = 11;
                    opplæring_fyll.MasterFagId = 3;
                    opplæring_fyll.Fagnavn = "30Sp fra matematikk eller norsk";
                    opplæring_fyll.Emnekode = "M1GNO3100 eller M1GMT3100";
                    opplæring_fyll.Semester = 5;
                    context.Add(opplæring_fyll);

                    //Muligheter masterFagId 3
                    var brukeropplæring1 = new Muligheter();
                    brukeropplæring1.Id = 12;
                    brukeropplæring1.MasterFagId = 3;
                    brukeropplæring1.Fagnavn = "Begynneropplæring 1";
                    brukeropplæring1.Semester = 7;
                    brukeropplæring1.Emnekode = "M1GBO4100";
                    brukeropplæring1.Studiepoeng = "15";
                    brukeropplæring1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GBO4100/2021/H%C3%98ST";
                    context.Add(brukeropplæring1);

                    //Muligheter masterFagId 3
                    var brukeropplæring2 = new Muligheter();
                    brukeropplæring2.Id = 13;
                    brukeropplæring2.MasterFagId = 3;
                    brukeropplæring2.Fagnavn = "Begynneropplæring 2";
                    brukeropplæring2.Semester = 8;
                    brukeropplæring2.Emnekode = "M1GBO4200";
                    brukeropplæring2.Studiepoeng = "15";
                    brukeropplæring2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GBO4200/2021/H%C3%98ST";
                    context.Add(brukeropplæring2);

                    //Muligheter masterFagId 3
                    var brukeropplæring3 = new Muligheter();
                    brukeropplæring3.Id = 14;
                    brukeropplæring3.MasterFagId = 3;
                    brukeropplæring3.Fagnavn = "Begynneropplæring 3";
                    brukeropplæring3.Semester = 9;
                    brukeropplæring3.Emnekode = "M1GBO5100";
                    brukeropplæring3.Studiepoeng = "15";
                    brukeropplæring3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GBO5100/2021/H%C3%98ST";
                    context.Add(brukeropplæring3);

                    //Muligheter masterFagId 3
                    var brukeropplæring4 = new Muligheter();
                    brukeropplæring4.Id = 15;
                    brukeropplæring4.MasterFagId = 3;
                    brukeropplæring4.Fagnavn = "Masteroppgave i begynneropplæring";
                    brukeropplæring4.Semester = 10;
                    brukeropplæring4.Emnekode = "";
                    brukeropplæring4.Studiepoeng = "30";
                    context.Add(brukeropplæring4); 


                //Masterfag 4 Engelsk
                var masterfag_engelsk = new MasterFag();
                masterfag_engelsk.Id = 4;
                masterfag_engelsk.KlasseId = 1;
                masterfag_engelsk.Fagnavn = "Engelsk";
                context.Add(masterfag_engelsk);

                    //Muligheter masterFagId 4
                    var engelsk_muligheter1 = new Muligheter();
                    engelsk_muligheter1.Id = 16;
                    engelsk_muligheter1.MasterFagId = 4;
                    engelsk_muligheter1.KlasseId = 1;
                    engelsk_muligheter1.Fagnavn = "Engelsk 1, emne 1 og 2";
                    engelsk_muligheter1.Semester = 4;
                    engelsk_muligheter1.Emnekode = "M1GEN2100, M1GEN2200";
                    engelsk_muligheter1.Studiepoeng = "15 / 15";
                    engelsk_muligheter1.URL = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GEN2100/2021/H%C3%98ST";
                    engelsk_muligheter1.URL2 = "https://student.oslomet.no/en/studier/-/studieinfo/emne/M1GEN2200/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter1);

                    //Muligheter masterFagId 4
                    var engelsk_muligheter3 = new Muligheter();
                    engelsk_muligheter3.Id = 17;
                    engelsk_muligheter3.MasterFagId = 4;
                    engelsk_muligheter3.KlasseId = 1;
                    engelsk_muligheter3.Fagnavn = "Engelsk 2, emne 3";
                    engelsk_muligheter3.Semester = 5;
                    engelsk_muligheter3.Emnekode = "M1GEN2200, M1GEN3100";
                    engelsk_muligheter3.Studiepoeng = "30";
                    engelsk_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GEN3100/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter3);

                    //Muligheter masterFagId 4
                    var engelsk_muligheter4 = new Muligheter();
                    engelsk_muligheter4.Id = 18;
                    engelsk_muligheter4.MasterFagId = 4;
                    engelsk_muligheter4.Fagnavn = "Engelsk og engelskdidaktikk 1";
                    engelsk_muligheter4.Semester = 7;
                    engelsk_muligheter4.Emnekode = "MGEN4100";
                    engelsk_muligheter4.Studiepoeng = "15";
                    engelsk_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN4100/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter4);

                    //Muligheter masterFagId 4
                    var engelsk_muligheter5 = new Muligheter();
                    engelsk_muligheter5.Id = 19;
                    engelsk_muligheter5.MasterFagId = 4;
                    engelsk_muligheter5.Fagnavn = "Engelsk og engelskdidaktikk 2";
                    engelsk_muligheter5.Semester = 8;
                    engelsk_muligheter5.Emnekode = "MGEN4200";
                    engelsk_muligheter5.Studiepoeng = "15";
                    engelsk_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN4200/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter5);

                    //Muligheter masterFagId 4
                    var engelsk_muligheter6 = new Muligheter();
                    engelsk_muligheter6.Id = 20;
                    engelsk_muligheter6.MasterFagId = 4;
                    engelsk_muligheter6.Fagnavn = "Engelsk og engelskdidaktikk 3";
                    engelsk_muligheter6.Semester = 9;
                    engelsk_muligheter6.Emnekode = "MGEN5100";
                    engelsk_muligheter6.Studiepoeng = "15";
                    engelsk_muligheter6.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN5100/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter6);

                    //Muligheter masterFagId 4 MASTERSØK
                    var engelsk_muligheter7 = new Muligheter();
                    engelsk_muligheter7.Id = 21;
                    engelsk_muligheter7.MasterFagId = 4;
                    engelsk_muligheter7.Fagnavn = "Masteroppgave i engelsk";
                    engelsk_muligheter7.Semester = 10;
                    engelsk_muligheter7.Emnekode = "";
                    engelsk_muligheter7.Studiepoeng = "30";
                    context.Add(engelsk_muligheter7);


                //Masterfag 5 RLE
                var masterfag_RLE = new MasterFag();
                masterfag_RLE.Id = 5;
                masterfag_RLE.Fagnavn = "RLE";
                masterfag_RLE.KlasseId = 1;
                context.Add(masterfag_RLE);

                    //Muligheter masterFagId 5
                    var RLE_muligheter1 = new Muligheter();
                    RLE_muligheter1.Id = 22;
                    RLE_muligheter1.MasterFagId = 5;
                    RLE_muligheter1.KlasseId = 1;
                    RLE_muligheter1.Fagnavn = "RLE 1, emne 1 og 2";
                    RLE_muligheter1.Semester = 4;
                    RLE_muligheter1.Emnekode = "M1GRL2100, M1GRL2200";
                    RLE_muligheter1.Studiepoeng = "15 / 15";
                    RLE_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GRL2100/2021/H%C3%98ST";
                    RLE_muligheter1.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GRL2200/2021/H%C3%98ST";
                    context.Add(RLE_muligheter1);

                    //Muligheter masterFagId 5
                    var RLE_muligheter3 = new Muligheter();
                    RLE_muligheter3.Id = 23;
                    RLE_muligheter3.MasterFagId = 5;
                    RLE_muligheter3.KlasseId = 1;
                    RLE_muligheter3.Fagnavn = "RLE 2, emne 3";
                    RLE_muligheter3.Semester = 5;
                    RLE_muligheter3.Emnekode = "M1GRL3100";
                    RLE_muligheter3.Studiepoeng = "30";
                    RLE_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GRL3100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter3);

                    //Muligheter masterFagId 5
                    var RLE_muligheter4 = new Muligheter();
                    RLE_muligheter4.Id = 24;
                    RLE_muligheter4.MasterFagId = 5;
                    RLE_muligheter4.Fagnavn = "RLE og RLE-didaktikk 1";
                    RLE_muligheter4.Semester = 7;
                    RLE_muligheter4.Emnekode = "MGRL4100";
                    RLE_muligheter4.Studiepoeng = "15";
                    RLE_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL4100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter4);

                    //Muligheter masterFagId 5
                    var RLE_muligheter5 = new Muligheter();
                    RLE_muligheter5.Id = 25;
                    RLE_muligheter5.MasterFagId = 5;
                    RLE_muligheter5.Fagnavn = "RLE og RLE-didaktikk 2";
                    RLE_muligheter5.Semester = 8;
                    RLE_muligheter5.Emnekode = "MGRL4200";
                    RLE_muligheter5.Studiepoeng = "15";
                    RLE_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL4200/2021/H%C3%98ST";
                    context.Add(RLE_muligheter5);

                    //Muligheter masterFagId 5
                    var RLE_muligheter6 = new Muligheter();
                    RLE_muligheter6.Id = 26;
                    RLE_muligheter6.MasterFagId = 5;
                    RLE_muligheter6.Fagnavn = "RLE og RLE-didaktikk 3";
                    RLE_muligheter6.Semester = 9;
                    RLE_muligheter6.Emnekode = "MGRL5100";
                    RLE_muligheter6.Studiepoeng = "15";
                    RLE_muligheter6.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL5100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter6);

                    //Muligheter masterFagId 5 MASTERSØK
                    var RLE_muligheter7 = new Muligheter();
                    RLE_muligheter7.Id = 27;
                    RLE_muligheter7.MasterFagId = 5;
                    RLE_muligheter7.Fagnavn = "Masteroppgave i RLE";
                    RLE_muligheter7.Semester = 10;
                    RLE_muligheter7.Emnekode = "";
                    RLE_muligheter7.Studiepoeng = "30";
                    context.Add(RLE_muligheter7);


                //Masterfag 6 kroppsøving
                var masterfag_gym = new MasterFag();
                masterfag_gym.Id = 6;
                masterfag_gym.KlasseId = 1;
                masterfag_gym.Fagnavn = "Kroppsøving";
                context.Add(masterfag_gym);

                    //Muligheter masterFagId 6
                    var gym_muligheter1 = new Muligheter();
                    gym_muligheter1.Id = 28;
                    gym_muligheter1.MasterFagId = 6;
                    gym_muligheter1.KlasseId = 1;
                    gym_muligheter1.Fagnavn = "Kroppsøving 1, emne 1";
                    gym_muligheter1.Semester = 4;
                    gym_muligheter1.Emnekode = "M1GKP2100";
                    gym_muligheter1.Studiepoeng = "30";
                    gym_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GKP2100/2021/H%C3%98ST";
                    context.Add(gym_muligheter1);

                    //Muligheter masterFagId 6
                    var gym_muligheter2 = new Muligheter();
                    gym_muligheter2.Id = 29;
                    gym_muligheter2.MasterFagId = 6;
                    gym_muligheter2.KlasseId = 1;
                    gym_muligheter2.Fagnavn = "Kroppsøving 2, emne 2";
                    gym_muligheter2.Semester = 5;
                    gym_muligheter2.Emnekode = "M1GKP3100";
                    gym_muligheter2.Studiepoeng = "30";
                    gym_muligheter2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GKP3100/2021/H%C3%98ST";
                    context.Add(gym_muligheter2);

                    //Muligheter masterFagId 6
                    var gym_muligheter3 = new Muligheter();
                    gym_muligheter3.Id = 30;
                    gym_muligheter3.MasterFagId = 6;
                    gym_muligheter3.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 1";
                    gym_muligheter3.Semester = 7;
                    gym_muligheter3.Emnekode = "MGKP4100";
                    gym_muligheter3.Studiepoeng = "15";
                    gym_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP4100/2021/H%C3%98ST";
                    context.Add(gym_muligheter3);

                    //Muligheter masterFagId 6
                    var gym_muligheter4 = new Muligheter();
                    gym_muligheter4.Id = 31;
                    gym_muligheter4.MasterFagId = 6;
                    gym_muligheter4.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 2";
                    gym_muligheter4.Semester = 8;
                    gym_muligheter4.Emnekode = "MGKP4200";
                    gym_muligheter4.Studiepoeng = "15";
                    gym_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP4200/2021/H%C3%98ST";
                    context.Add(gym_muligheter4);

                    //Muligheter masterFagId 6
                    var gym_muligheter5 = new Muligheter();
                    gym_muligheter5.Id = 32;
                    gym_muligheter5.MasterFagId = 6;
                    gym_muligheter5.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 3";
                    gym_muligheter5.Semester = 9;
                    gym_muligheter5.Emnekode = "MGKP5100";
                    gym_muligheter5.Studiepoeng = "15";
                    gym_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP5100/2021/H%C3%98ST";
                    context.Add(gym_muligheter5);

                    //Muligheter masterFagId 6 MASTERSØK
                    var gym_muligheter6 = new Muligheter();
                    gym_muligheter6.Id = 33;
                    gym_muligheter6.MasterFagId = 6;
                    gym_muligheter6.Fagnavn = "Masteroppgave i kroppsøving";
                    gym_muligheter6.Semester = 10;
                    gym_muligheter6.Emnekode = "";
                    gym_muligheter6.Studiepoeng = "30";
                    context.Add(gym_muligheter6);


                //Masterfag 7 KH
                var masterfag_KH = new MasterFag();
                masterfag_KH.Id = 7;
                masterfag_KH.KlasseId = 1;
                masterfag_KH.Fagnavn = "Kunst og håndverk";
                context.Add(masterfag_KH);

                    //Muligheter masterFagId 7
                    var KH_muligheter1 = new Muligheter();
                    KH_muligheter1.Id = 34;
                    KH_muligheter1.MasterFagId = 7;
                    KH_muligheter1.KlasseId = 1;
                    KH_muligheter1.Fagnavn = "Kunst og håndverk 1, emne 1";
                    KH_muligheter1.Semester = 4;
                    KH_muligheter1.Emnekode = "MGKH2100";
                    KH_muligheter1.Studiepoeng = "30";
                    KH_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKH2100/2021/H%C3%98ST";
                    context.Add(KH_muligheter1);

                    //Muligheter masterFagId 7
                    var KH_muligheter2 = new Muligheter();
                    KH_muligheter2.Id = 35;
                    KH_muligheter2.MasterFagId = 7;
                    KH_muligheter2.KlasseId = 1;
                    KH_muligheter2.Fagnavn = "Kunst og håndverk 2, emne 2";
                    KH_muligheter2.Semester = 5;
                    KH_muligheter2.Emnekode = "MGKH3100";
                    KH_muligheter2.Studiepoeng = "30";
                    KH_muligheter2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKH3100/2021/H%C3%98ST";
                    context.Add(KH_muligheter2);

                    //Muligheter masterFagId 7
                    var KH_muligheter3 = new Muligheter();
                    KH_muligheter3.Id = 36;
                    KH_muligheter3.MasterFagId = 7;
                    KH_muligheter3.Fagnavn = "Fagdidaktikk: kunst og håndverk";
                    KH_muligheter3.Semester = 7;
                    KH_muligheter3.Emnekode = "MFAGL4000";
                    KH_muligheter3.Studiepoeng = "15";
                    KH_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL4000/2021/H%C3%98ST";
                    context.Add(KH_muligheter3);

                    //Muligheter masterFagId 7
                    var KH_muligheter4 = new Muligheter();
                    KH_muligheter4.Id = 37;
                    KH_muligheter4.MasterFagId = 7;
                    KH_muligheter4.Fagnavn = "Praktisk estetisk prosjekt";
                    KH_muligheter4.Semester = 8;
                    KH_muligheter4.Emnekode = "MFAGL4200";
                    KH_muligheter4.Studiepoeng = "15";
                    KH_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL4200/2021/H%C3%98ST";
                    context.Add(KH_muligheter4);

                    //Muligheter masterFagId 7
                    var KH_muligheter5 = new Muligheter();
                    KH_muligheter5.Id = 38;
                    KH_muligheter5.MasterFagId = 7;
                    KH_muligheter5.Fagnavn = "Prosjektutvikling og undervisningspraksis";
                    KH_muligheter5.Semester = 9;
                    KH_muligheter5.Emnekode = "MFAGL5000";
                    KH_muligheter5.Studiepoeng = "15";
                    KH_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL5000/2021/H%C3%98ST";
                    context.Add(KH_muligheter5);

                    //Muligheter masterFagId 7 MASTERSØK
                    var KH_muligheter6 = new Muligheter();
                    KH_muligheter6.Id = 39;
                    KH_muligheter6.MasterFagId = 7;
                    KH_muligheter6.Fagnavn = "Masteroppgave i kroppsøving";
                    KH_muligheter6.Semester = 10;
                    KH_muligheter6.Emnekode = "";
                    KH_muligheter6.Studiepoeng = "30";
                    context.Add(KH_muligheter6);


                //Masterfag 8 Musikk
                var masterfag_musikk = new MasterFag();
                masterfag_musikk.Id = 8;
                masterfag_musikk.KlasseId = 1;
                masterfag_musikk.Fagnavn = "Musikk";
                context.Add(masterfag_musikk);

                    //Muligheter masterFagId 8
                    var musikk_muligheter1 = new Muligheter();
                    musikk_muligheter1.Id = 40;
                    musikk_muligheter1.MasterFagId = 8;
                    musikk_muligheter1.KlasseId = 1;
                    musikk_muligheter1.Fagnavn = "Musikk 1, emne 1 og 2";
                    musikk_muligheter1.Semester = 4;
                    musikk_muligheter1.Emnekode = "M1GMU2100, M1GMU2200";
                    musikk_muligheter1.Studiepoeng = "15 / 15";
                    musikk_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GMU2100/2021/H%C3%98ST";
                    musikk_muligheter1.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GMU2200/2021/H%C3%98ST";
                    context.Add(musikk_muligheter1);

                    //Muligheter masterFagId 8
                    var musikk_muligheter3 = new Muligheter();
                    musikk_muligheter3.Id = 41;
                    musikk_muligheter3.MasterFagId = 8;
                    musikk_muligheter3.KlasseId = 1;
                    musikk_muligheter3.Fagnavn = "Musikk 2, emne 3";
                    musikk_muligheter3.Semester = 5;
                    musikk_muligheter3.Emnekode = "M1GMU3100";
                    musikk_muligheter3.Studiepoeng = "30";
                    musikk_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GMU3100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter3);

                    //Muligheter masterFagId 8
                    var musikk_muligheter4 = new Muligheter();
                    musikk_muligheter4.Id = 42;
                    musikk_muligheter4.MasterFagId = 8;
                    musikk_muligheter4.Fagnavn = "Musikk og musikkdidaktikk 1";
                    musikk_muligheter4.Semester = 7;
                    musikk_muligheter4.Emnekode = "MGMU4100";
                    musikk_muligheter4.Studiepoeng = "15";
                    musikk_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU4100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter4);

                    //Muligheter masterFagId 8
                    var musikk_muligheter5 = new Muligheter();
                    musikk_muligheter5.Id = 43;
                    musikk_muligheter5.MasterFagId = 8;
                    musikk_muligheter5.Fagnavn = "Musikk og musikkdidaktikk 2";
                    musikk_muligheter5.Semester = 8;
                    musikk_muligheter5.Emnekode = "MGMU4200";
                    musikk_muligheter5.Studiepoeng = "15";
                    musikk_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU4200/2021/H%C3%98ST";
                    context.Add(musikk_muligheter5);

                    //Muligheter masterFagId 8
                    var musikk_muligheter6 = new Muligheter();
                    musikk_muligheter6.Id = 44;
                    musikk_muligheter6.MasterFagId = 8;
                    musikk_muligheter6.Fagnavn = "Musikk og musikkdidaktikk 3";
                    musikk_muligheter6.Semester = 9;
                    musikk_muligheter6.Emnekode = "MGMU5100";
                    musikk_muligheter6.Studiepoeng = "15";
                    musikk_muligheter6.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU5100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter6);

                    //Muligheter masterFagId 8 MASTERSØK
                    var musikk_muligheter7 = new Muligheter();
                    musikk_muligheter7.Id = 45;
                    musikk_muligheter7.MasterFagId = 8;
                    musikk_muligheter7.Fagnavn = "Masteroppgave i musikk";
                    musikk_muligheter7.Semester = 10;
                    musikk_muligheter7.Emnekode = "";
                    musikk_muligheter7.Studiepoeng = "30";
                    context.Add(musikk_muligheter7);


                //Masterfag 9 Naturfag
                var masterfag_naturfag = new MasterFag();
                masterfag_naturfag.Id = 9;
                masterfag_naturfag.KlasseId = 1;
                masterfag_naturfag.Fagnavn = "Naturfag";
                context.Add(masterfag_naturfag);

                    //Muligheter masterFagId 9
                    var naturfag_muligheter1 = new Muligheter();
                    naturfag_muligheter1.Id = 46;
                    naturfag_muligheter1.MasterFagId = 9;
                    naturfag_muligheter1.KlasseId = 1;
                    naturfag_muligheter1.Fagnavn = "Naturfag 1, emne 1 og 2";
                    naturfag_muligheter1.Semester = 4;
                    naturfag_muligheter1.Emnekode = "M1GNA2100, M1GNA2200";
                    naturfag_muligheter1.Studiepoeng = "15 / 15";
                    naturfag_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GNA2100/2021/H%C3%98ST";
                    naturfag_muligheter1.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GNA2200/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter1);

                    //Muligheter masterFagId 9
                    var naturfag_muligheter3 = new Muligheter();
                    naturfag_muligheter3.Id = 47;
                    naturfag_muligheter3.MasterFagId = 9;
                    naturfag_muligheter3.KlasseId = 1;
                    naturfag_muligheter3.Fagnavn = "Naturfag 2, emne 3";
                    naturfag_muligheter3.Semester = 5;
                    naturfag_muligheter3.Emnekode = "M1GNA3100";
                    naturfag_muligheter3.Studiepoeng = "30";
                    naturfag_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GNA3100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter3);

                    //Muligheter masterFagId 9
                    var naturfag_muligheter4 = new Muligheter();
                    naturfag_muligheter4.Id = 48;
                    naturfag_muligheter4.MasterFagId = 9;
                    naturfag_muligheter4.Fagnavn = "Naturfag og naturfagdidaktikk 1";
                    naturfag_muligheter4.Semester = 7;
                    naturfag_muligheter4.Emnekode = "MGNA4100";
                    naturfag_muligheter4.Studiepoeng = "15";
                    naturfag_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA4100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter4);

                    //Muligheter masterFagId 9
                    var naturfag_muligheter5 = new Muligheter();
                    naturfag_muligheter5.Id = 49;
                    naturfag_muligheter5.MasterFagId = 9;
                    naturfag_muligheter5.Fagnavn = "Naturfag og naturfagdidaktikk 2";
                    naturfag_muligheter5.Semester = 8;
                    naturfag_muligheter5.Emnekode = "MGNA4200";
                    naturfag_muligheter5.Studiepoeng = "15";
                    naturfag_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA4200/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter5);

                    //Muligheter masterFagId 9
                    var naturfag_muligheter6 = new Muligheter();
                    naturfag_muligheter6.Id = 50;
                    naturfag_muligheter6.MasterFagId = 9;
                    naturfag_muligheter6.Fagnavn = "Naturfag og naturfagdidaktikk 3";
                    naturfag_muligheter6.Semester = 9;
                    naturfag_muligheter6.Emnekode = "MGNA5100";
                    naturfag_muligheter6.Studiepoeng = "15";
                    naturfag_muligheter6.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA5100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter6);

                    //Muligheter masterFagId 9 MASTERSØK
                    var naturfag_muligheter7 = new Muligheter();
                    naturfag_muligheter7.Id = 51;
                    naturfag_muligheter7.MasterFagId = 9;
                    naturfag_muligheter7.Fagnavn = "Masteroppgave i naturfag";
                    naturfag_muligheter7.Semester = 10;
                    naturfag_muligheter7.Emnekode = "";
                    naturfag_muligheter7.Studiepoeng = "30";
                    context.Add(naturfag_muligheter7);


                //Masterfag 10 samfunnsfag
                var masterfag_samfunnsfag = new MasterFag();
                masterfag_samfunnsfag.Id = 10;
                masterfag_samfunnsfag.KlasseId = 1;
                masterfag_samfunnsfag.Fagnavn = "Samfunnsfag";
                context.Add(masterfag_samfunnsfag);

                    //Muligheter masterFagId 10
                    var samfunnsfag_muligheter1 = new Muligheter();
                    samfunnsfag_muligheter1.Id = 52;
                    samfunnsfag_muligheter1.MasterFagId = 10;
                    samfunnsfag_muligheter1.KlasseId = 1;
                    samfunnsfag_muligheter1.Fagnavn = "Samfunnsfag 1, emne 1 og 2";
                    samfunnsfag_muligheter1.Semester = 4;
                    samfunnsfag_muligheter1.Emnekode = "M1GSF2100, M1GSF2200";
                    samfunnsfag_muligheter1.Studiepoeng = "15 / 15";
                    samfunnsfag_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GSF2100/2021/H%C3%98ST";
                    samfunnsfag_muligheter1.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GSF2200/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter1);

                    //Muligheter masterFagId 10
                    var samfunnsfag_muligheter3 = new Muligheter();
                    samfunnsfag_muligheter3.Id = 53;
                    samfunnsfag_muligheter3.MasterFagId = 10;
                    samfunnsfag_muligheter3.KlasseId = 1;
                    samfunnsfag_muligheter3.Fagnavn = "Samfunnsfag 2, emne 3";
                    samfunnsfag_muligheter3.Semester = 5;
                    samfunnsfag_muligheter3.Emnekode = "M1GSF3100";
                    samfunnsfag_muligheter3.Studiepoeng = "30";
                    samfunnsfag_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M1GSF3100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter3);

                    //Muligheter masterFagId 10
                    var samfunnsfag_muligheter4 = new Muligheter();
                    samfunnsfag_muligheter4.Id = 54;
                    samfunnsfag_muligheter4.MasterFagId = 10;
                    samfunnsfag_muligheter4.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 1";
                    samfunnsfag_muligheter4.Semester = 7;
                    samfunnsfag_muligheter4.Emnekode = "MGSF4100";
                    samfunnsfag_muligheter4.Studiepoeng = "15";
                    samfunnsfag_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF4100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter4);

                    //Muligheter masterFagId 10
                    var samfunnsfag_muligheter5 = new Muligheter();
                    samfunnsfag_muligheter5.Id = 55;
                    samfunnsfag_muligheter5.MasterFagId = 10;
                    samfunnsfag_muligheter5.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 2";
                    samfunnsfag_muligheter5.Semester = 8;
                    samfunnsfag_muligheter5.Emnekode = "MGSF4200";
                    samfunnsfag_muligheter5.Studiepoeng = "15";
                    samfunnsfag_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF4200/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter5);

                    //Muligheter masterFagId 10
                    var samfunnsfag_muligheter6 = new Muligheter();
                    samfunnsfag_muligheter6.Id = 56;
                    samfunnsfag_muligheter6.MasterFagId = 10;
                    samfunnsfag_muligheter6.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 3";
                    samfunnsfag_muligheter6.Semester = 9;
                    samfunnsfag_muligheter6.Emnekode = "MGSF5100";
                    samfunnsfag_muligheter6.Studiepoeng = "15";
                    samfunnsfag_muligheter6.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF5100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter6);

                    //Muligheter masterFagId 10 MASTERSØK
                    var samfunnsfag_muligheter7 = new Muligheter();
                    samfunnsfag_muligheter7.Id = 57;
                    samfunnsfag_muligheter7.MasterFagId = 10;
                    samfunnsfag_muligheter7.Fagnavn = "Masteroppgave i samfunnsfag";
                    samfunnsfag_muligheter7.Semester = 10;
                    samfunnsfag_muligheter7.Emnekode = "";
                    samfunnsfag_muligheter7.Studiepoeng = "30";
                    context.Add(samfunnsfag_muligheter7);


                //Masterfag 11 Tegnspråk
                var masterfag_tegnspråk = new MasterFag();
                masterfag_tegnspråk.Id = 11;
                masterfag_tegnspråk.KlasseId = 1;
                masterfag_tegnspråk.Fagnavn = "Tegnspråk";
                context.Add(masterfag_tegnspråk);

                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter1 = new Muligheter();
                    tegnspråk_muligheter1.Id = 58;
                    tegnspråk_muligheter1.MasterFagId = 11;
                    tegnspråk_muligheter1.KlasseId = 1;
                    tegnspråk_muligheter1.Fagnavn = "Norsk tegnspråk 1";
                    tegnspråk_muligheter1.Semester = 5;
                    tegnspråk_muligheter1.Emnekode = "MGNT3100";
                    tegnspråk_muligheter1.Studiepoeng = "30";
                    tegnspråk_muligheter1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT3100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter1);

                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter2 = new Muligheter();
                    tegnspråk_muligheter2.Id = 59;
                    tegnspråk_muligheter2.MasterFagId = 11;
                    tegnspråk_muligheter2.KlasseId = 1;
                    tegnspråk_muligheter2.Fagnavn = "Norsk tegnspråk 2";
                    tegnspråk_muligheter2.Semester = 6;
                    tegnspråk_muligheter2.Emnekode = "MGNT3200";
                    tegnspråk_muligheter2.Studiepoeng = "30";
                    tegnspråk_muligheter2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT3200/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter2);

                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter3 = new Muligheter();
                    tegnspråk_muligheter3.Id = 60;
                    tegnspråk_muligheter3.MasterFagId = 11;
                    tegnspråk_muligheter3.Fagnavn = "Norsk tegnspråk og tegnspråkdidaktikk 1";
                    tegnspråk_muligheter3.Semester = 7;
                    tegnspråk_muligheter3.Emnekode = "MGNT4100";
                    tegnspråk_muligheter3.Studiepoeng = "15";
                    tegnspråk_muligheter3.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT4100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter3);

                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter4 = new Muligheter();
                    tegnspråk_muligheter4.Id = 61;
                    tegnspråk_muligheter4.MasterFagId = 11;
                    tegnspråk_muligheter4.Fagnavn = "Norsk tegnspråk og tegnspråkdidaktikk 2";
                    tegnspråk_muligheter4.Semester = 8;
                    tegnspråk_muligheter4.Emnekode = "MGNT4200";
                    tegnspråk_muligheter4.Studiepoeng = "15";
                    tegnspråk_muligheter4.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT4200/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter4);

                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter5 = new Muligheter();
                    tegnspråk_muligheter5.Id = 62;
                    tegnspråk_muligheter5.MasterFagId = 11;
                    tegnspråk_muligheter5.Fagnavn = "Norsk tegnspråk og tegnspråkdidaktikk 3";
                    tegnspråk_muligheter5.Semester = 9;
                    tegnspråk_muligheter5.Emnekode = "MGNT5100";
                    tegnspråk_muligheter5.Studiepoeng = "15";
                    tegnspråk_muligheter5.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT5100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter5);


                    //Muligheter masterFagId 11
                    var tegnspråk_muligheter6 = new Muligheter();
                    tegnspråk_muligheter6.Id = 63;
                    tegnspråk_muligheter6.MasterFagId = 11;
                    tegnspråk_muligheter6.Fagnavn = "Masteroppgave i tegnspråk";
                    tegnspråk_muligheter6.Semester = 10;
                    tegnspråk_muligheter6.Emnekode = "";
                    tegnspråk_muligheter6.Studiepoeng = "30";
                    context.Add(tegnspråk_muligheter6);


                //Masterfag 12 Profesjonell pedagogikk
                var masterfag_profped = new MasterFag();
                masterfag_profped.Id = 12;
                masterfag_profped.KlasseId = 1;
                masterfag_profped.Fagnavn = "Profesjonsrettet pedagogikk";
                context.Add(masterfag_profped);

                    //Muligheter masterFagId 12
                    var prof_ped1 = new Muligheter();
                    prof_ped1.Id = 64;
                    prof_ped1.MasterFagId = 12;
                    prof_ped1.KlasseId = 1;
                    prof_ped1.Fagnavn = "fordypning 1: Profesjonsrettet pedagogikk";
                    prof_ped1.Semester = 6;
                    prof_ped1.Emnekode = "MGPE3100";
                    prof_ped1.Studiepoeng = "30";
                    prof_ped1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3100/2021/H%C3%98ST";
                    context.Add(prof_ped1);

                    //Muligheter masterFagId 12
                    var prof_ped2 = new Muligheter();
                    prof_ped2.Id = 65;
                    prof_ped2.MasterFagId = 12;
                    prof_ped2.Fagnavn = "fordypning 2: Profesjonsrettet pedagogikk";
                    prof_ped2.Semester = 9;
                    prof_ped2.Emnekode = "MGPE5100";
                    prof_ped2.Studiepoeng = "30";
                    prof_ped2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5100/2021/H%C3%98ST";
                    context.Add(prof_ped2);

                    //Muligheter masterFagId 12 MASTERSØK
                    var prof_ped3 = new Muligheter();
                    prof_ped3.Id = 66;
                    prof_ped3.MasterFagId = 12;
                    prof_ped3.Fagnavn = "Masteroppgave i profesjonsrettet pedagogikk";
                    prof_ped3.Semester = 10;
                    prof_ped3.Emnekode = "";
                    prof_ped3.Studiepoeng = "30";
                    context.Add(prof_ped3);


                //Masterfag 13 digital pedagogikk
                var masterfag_digped = new MasterFag();
                masterfag_digped.Id = 13;
                masterfag_digped.KlasseId = 1;
                masterfag_digped.Fagnavn = "Digital støttet pedagogikk";
                context.Add(masterfag_digped);

                    //Muligheter masterFagId 13
                    var dig_ped1 = new Muligheter();
                    dig_ped1.Id = 67;
                    dig_ped1.MasterFagId = 13;
                    dig_ped1.KlasseId = 1;
                    dig_ped1.Fagnavn = "fordypning 1: Digitalt støttet pedagogikk";
                    dig_ped1.Semester = 6;
                    dig_ped1.Emnekode = "MGPE3200";
                    dig_ped1.Studiepoeng = "30";
                    dig_ped1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3200/2021/H%C3%98ST";
                    context.Add(dig_ped1);

                    //Muligheter masterFagId 13
                    var dig_ped2 = new Muligheter();
                    dig_ped2.Id = 68;
                    dig_ped2.MasterFagId = 13;
                    dig_ped2.Fagnavn = "fordypning 2: Digitalt støttet pedagogikk";
                    dig_ped2.Semester = 9;
                    dig_ped2.Emnekode = "MGPE5200";
                    dig_ped2.Studiepoeng = "30";
                    dig_ped2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5200/2021/H%C3%98ST";
                    context.Add(dig_ped2);

                    //Muligheter masterFagId 13 MASTERSØK
                    var dig_ped3 = new Muligheter();
                    dig_ped3.Id = 69;
                    dig_ped3.MasterFagId = 13;
                    dig_ped3.Fagnavn = "Masteroppgave i digitalt støttet pedagogikk";
                    dig_ped3.Semester = 10;
                    dig_ped3.Emnekode = "";
                    dig_ped3.Studiepoeng = "30";
                    context.Add(dig_ped3);


                //Masterfag 14 Profesjonell pedagogikk
                var masterfag_spesped = new MasterFag();
                masterfag_spesped.Id = 14;
                masterfag_spesped.KlasseId = 1;
                masterfag_spesped.Fagnavn = "Spesialpedagogikk";
                context.Add(masterfag_spesped);

                    //Muligheter masterFagId 14
                    var spes_ped1 = new Muligheter();
                    spes_ped1.Id = 70;
                    spes_ped1.MasterFagId = 14;
                    spes_ped1.KlasseId = 1;
                    spes_ped1.Fagnavn = "fordypning 1: Spesialpedagogikk";
                    spes_ped1.Semester = 6;
                    spes_ped1.Emnekode = "MGPE3300";
                    spes_ped1.Studiepoeng = "30";
                    spes_ped1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3300/2021/H%C3%98ST";
                    context.Add(spes_ped1);

                    //Muligheter masterFagId 14
                    var spes_ped2 = new Muligheter();
                    spes_ped2.Id = 71;
                    spes_ped2.MasterFagId = 14;
                    spes_ped2.Fagnavn = "fordypning 2: Spesialpedagogikk";
                    spes_ped2.Semester = 9;
                    spes_ped2.Emnekode = "MGPE5300";
                    spes_ped2.Studiepoeng = "30";
                    spes_ped1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5300/2021/H%C3%98ST";
                    context.Add(spes_ped2);

                    //Muligheter masterFagId 14 MASTERSØK
                    var spes_ped3 = new Muligheter();
                    spes_ped3.Id = 72;
                    spes_ped3.MasterFagId = 14;
                    spes_ped3.Fagnavn = "Masteroppgave i spesialpedagogikk";
                    spes_ped3.Semester = 10;
                    spes_ped3.Emnekode = "";
                    spes_ped3.Studiepoeng = "30";
                    context.Add(spes_ped3);


                //mat og helse id 29
                var mat_helse = new MasterFag();
                mat_helse.Id = 29;
                mat_helse.KlasseId = 3;
                context.Add(mat_helse);

                    //Muligheter masterFagId 29
                    var mathelse1 = new Muligheter();
                    mathelse1.Id = 73;
                    mathelse1.MasterFagId = 29;
                    mathelse1.KlasseId = 1;
                    mathelse1.Fagnavn = "Mat og helse 1, emne 1";
                    mathelse1.Semester = 4;
                    mathelse1.Emnekode = "MGMH2100";
                    mathelse1.Studiepoeng = "30";
                    mathelse1.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMH2100/2021/H%C3%98ST";
                    context.Add(mathelse1);

                
                /***************************************************************************************/


                //Klassetrinn 5-10
                var klasse2 = new Klasser();
                klasse2.Id = 2;
                klasse2.Klassetrinn = "5-10";
                context.Add(klasse2);


                //obligatorisk fag

                //obligatoriske mattefag
                var oblig_matte1_2 = new ObligFags();
                oblig_matte1_2.Id = 13;
                oblig_matte1_2.KlasseId = 2;
                oblig_matte1_2.Fagnavn = "Matematikk, emne 1 og 2";
                oblig_matte1_2.Semester = 1;
                oblig_matte1_2.Emnekode = "M5GMT1100, M5GMT1200";
                oblig_matte1_2.Studiepoeng = "15 / 7.5";
                oblig_matte1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1100/2021/H%C3%98ST";
                oblig_matte1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1200/2021/H%C3%98ST";
                context.Add(oblig_matte1_2);

                var oblig_matte3_2 = new ObligFags();
                oblig_matte3_2.Id = 14;
                oblig_matte3_2.KlasseId = 2;
                oblig_matte3_2.Fagnavn = "Matematikk, emne 2 og 3";
                oblig_matte3_2.Semester = 2;
                oblig_matte3_2.Emnekode = "M5GMT1200, M5GMT1300";
                oblig_matte3_2.Studiepoeng = "7.5 / 15";
                oblig_matte3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1200/2021/H%C3%98ST";
                oblig_matte3_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1300/2021/H%C3%98ST";
                context.Add(oblig_matte3_2);

                var oblig_matte5_2 = new ObligFags();
                oblig_matte5_2.Id = 15;
                oblig_matte5_2.KlasseId = 2;
                oblig_matte5_2.Fagnavn = "Matematikk, emne 4";
                oblig_matte5_2.Semester = 3;
                oblig_matte5_2.Emnekode = "M5GMT2100";
                oblig_matte5_2.Studiepoeng = "15";
                oblig_matte5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT2100/2021/H%C3%98ST";
                context.Add(oblig_matte5_2);


                //obligatoriske Engelskfag
                var oblig_engelsk1_2 = new ObligFags();
                oblig_engelsk1_2.Id = 16;
                oblig_engelsk1_2.Fagnavn = "Engelsk, emne 1 og 2";
                oblig_engelsk1_2.Semester = 1;
                oblig_engelsk1_2.Emnekode = "M5GEN1100, M5GEN1200";
                oblig_engelsk1_2.Studiepoeng = "15 / 15";
                oblig_engelsk1_2.KlasseId = 2;
                oblig_engelsk1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1100/2021/H%C3%98ST";
                oblig_engelsk1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1200/2021/H%C3%98ST";
                context.Add(oblig_engelsk1_2);

                var oblig_engelsk3_2 = new ObligFags();
                oblig_engelsk3_2.Id = 17;
                oblig_engelsk3_2.Fagnavn = "Engelsk, emne 2 og 3";
                oblig_engelsk3_2.Semester = 2;
                oblig_engelsk3_2.Emnekode = "M5GEN1200, M5GEN1300";
                oblig_engelsk3_2.Studiepoeng = "15 / 15";
                oblig_engelsk3_2.KlasseId = 2;
                oblig_engelsk3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1200/2021/H%C3%98ST";
                oblig_engelsk1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1300/2021/H%C3%98ST";
                context.Add(oblig_engelsk3_2);

                var oblig_engelsk5_2 = new ObligFags();
                oblig_engelsk5_2.Id = 18;
                oblig_engelsk5_2.Fagnavn = "Engelsk, emne 4";
                oblig_engelsk5_2.Semester = 3;
                oblig_engelsk5_2.Emnekode = "M5GEN2100";
                oblig_engelsk5_2.Studiepoeng = "15";
                oblig_engelsk5_2.KlasseId = 2;
                oblig_engelsk5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN2100/2021/H%C3%98ST";
                context.Add(oblig_engelsk5_2);


                //obligatoriske Norskfag
                var oblig_norsk1_2 = new ObligFags();
                oblig_norsk1_2.Id = 19;
                oblig_norsk1_2.KlasseId = 2;
                oblig_norsk1_2.Fagnavn = "Norsk, emne 1 og 2";
                oblig_norsk1_2.Semester = 1;
                oblig_norsk1_2.Emnekode = "M5GNO1100, M5GNO1200";
                oblig_norsk1_2.Studiepoeng = "15 / 7.5";
                oblig_norsk1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1100/2021/H%C3%98ST";
                oblig_norsk1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1200/2021/H%C3%98ST";
                context.Add(oblig_norsk1_2);

                var oblig_norsk3_2 = new ObligFags();
                oblig_norsk3_2.Id = 20;
                oblig_norsk3_2.KlasseId = 2;
                oblig_norsk3_2.Fagnavn = "Norsk, emne 2 og 3";
                oblig_norsk3_2.Semester = 2;
                oblig_norsk3_2.Emnekode = "M5GNO1200";
                oblig_norsk3_2.Studiepoeng = "7.5 / 15";
                oblig_norsk3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1200/2021/H%C3%98ST";
                oblig_norsk3_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1300/2021/H%C3%98ST";
                context.Add(oblig_norsk3_2); 

                var oblig_norsk5_2 = new ObligFags();
                oblig_norsk5_2.Id = 21;
                oblig_norsk5_2.KlasseId = 2;
                oblig_norsk5_2.Fagnavn = "Norsk, emne 4";
                oblig_norsk5_2.Semester = 3;
                oblig_norsk5_2.Emnekode = "M5GNO2100";
                oblig_norsk5_2.Studiepoeng = "15";
                oblig_norsk5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO2100/2021/H%C3%98ST";
                context.Add(oblig_norsk5_2);


                // obligatoriske PEL og VM
                //PEL1 - sem 1
                var oblig_pel_2 = new ObligFags();
                oblig_pel_2.Id = 22;
                oblig_pel_2.KlasseId = 2;
                oblig_pel_2.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 1";
                oblig_pel_2.Semester = 1;
                oblig_pel_2.Emnekode = "M5GPE1100";
                oblig_pel_2.Studiepoeng = "7.5";
                oblig_pel_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GPE1100/2021/H%C3%98ST";
                context.Add(oblig_pel_2);

                //PEL1 - sem 2
                var oblig_pel2_2 = new ObligFags();
                oblig_pel2_2.Id = 23;
                oblig_pel2_2.KlasseId = 2;
                oblig_pel2_2.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 1";
                oblig_pel2_2.Semester = 2;
                oblig_pel2_2.Emnekode = "M1GPE1100";
                oblig_pel2_2.Studiepoeng = "7.5";
                oblig_pel2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GPE1100/2021/H%C3%98ST";
                context.Add(oblig_pel2_2);

                //PEL2
                var oblig_pel3_2 = new ObligFags();
                oblig_pel3_2.Id = 24;
                oblig_pel3_2.KlasseId = 2;
                oblig_pel3_2.Fagnavn = "Pedagogikk og elevkunnskap 1, emne 2";
                oblig_pel3_2.Semester = 3;
                oblig_pel3_2.Emnekode = "M5GPE2100";
                oblig_pel3_2.Studiepoeng = "15";
                oblig_pel3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GPE2100/2021/H%C3%98ST";
                context.Add(oblig_pel3_2);

                //V&M
                var oblig_VM_2 = new ObligFags();
                oblig_VM_2.Id = 25;
                oblig_VM_2.KlasseId = 2;
                oblig_VM_2.Fagnavn = "Vitenskapsteori og metodikk";
                oblig_VM_2.Semester = 7;
                oblig_VM_2.Emnekode = "MGVM4100";
                oblig_VM_2.Studiepoeng = "15";
                oblig_VM_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGVM4100/2021/H%C3%98ST";
                context.Add(oblig_VM_2);

                //PEL3
                var oblig_pel4_2 = new ObligFags();
                oblig_pel4_2.Id = 26;
                oblig_pel4_2.KlasseId = 2;
                oblig_pel4_2.Fagnavn = "Pedagogikk og elevkunnskap 2, emne 1";
                oblig_pel4_2.Semester = 8;
                oblig_pel4_2.Emnekode = "M5GPE4100";
                oblig_pel4_2.Studiepoeng = "15";
                oblig_pel4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GPE4100/2021/H%C3%98ST";
                context.Add(oblig_pel4_2);

                //PEL4
                var oblig_pel5_2 = new ObligFags();
                oblig_pel5_2.Id = 27;
                oblig_pel5_2.KlasseId = 2;
                oblig_pel5_2.Fagnavn = "Pedagogikk og elevkunnskap 2, emne 2";
                oblig_pel5_2.Semester = 9;
                oblig_pel5_2.Emnekode = "M5GPE5100";
                oblig_pel5_2.Studiepoeng = "15";
                oblig_pel5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GPE5100/2021/H%C3%98ST";
                context.Add(oblig_pel5_2);


                //Masterfag
                //Masterfag 15 Norsk
                var masterfag_norsk_2 = new MasterFag();
                masterfag_norsk_2.Id = 15;
                masterfag_norsk_2.KlasseId = 2;
                masterfag_norsk_2.Fagnavn = "Norsk";
                context.Add(masterfag_norsk_2);

                    //muligheter masterFagId 15
                    var norsk_muligheter1_2 = new Muligheter();
                    norsk_muligheter1_2.Id = 74;
                    norsk_muligheter1_2.MasterFagId = 15;
                    norsk_muligheter1_2.Fagnavn = "Norsk og norskdidaktikk 1";
                    norsk_muligheter1_2.Semester = 7;
                    norsk_muligheter1_2.Emnekode = "MGNO4100";
                    norsk_muligheter1_2.Studiepoeng = "15";
                norsk_muligheter1_2.URL = "";
                context.Add(norsk_muligheter1_2);

                    //muligheter masterFagId 15
                    var norsk_muligheter2_2 = new Muligheter();
                    norsk_muligheter2_2.Id = 75;
                    norsk_muligheter2_2.MasterFagId = 15;
                    norsk_muligheter2_2.Fagnavn = "Norsk og norskdidaktikk 2";
                    norsk_muligheter2_2.Semester = 8;
                    norsk_muligheter2_2.Emnekode = "MGNO4200";
                    norsk_muligheter2_2.Studiepoeng = "15";
                norsk_muligheter2_2.URL = "";
                context.Add(norsk_muligheter2_2);

                    //muligheter masterFagId 15
                    var norsk_muligheter3_2 = new Muligheter();
                    norsk_muligheter3_2.Id = 76;
                    norsk_muligheter3_2.MasterFagId = 15;
                    norsk_muligheter3_2.Fagnavn = "Norsk og norskdidaktikk 3";
                    norsk_muligheter3_2.Semester = 9;
                    norsk_muligheter3_2.Emnekode = "MGNO5100";
                    norsk_muligheter3_2.Studiepoeng = "15";
                norsk_muligheter3_2.URL = "";
                context.Add(norsk_muligheter3_2);

                    //Muligheter masterFagId 15
                    var norsk61 = new Muligheter();
                    norsk61.Id = 139;
                    norsk61.MasterFagId = 15;
                    norsk61.KlasseId = 2;
                    norsk61.Fagnavn = "Årstudium norsk, del 1";
                    norsk61.Semester = 5;
                    norsk61.Emnekode = "M5GNO1100, M5GNO1200, M5GNO3100";
                    norsk61.Studiepoeng = "30";
                    norsk61.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1100/2021/H%C3%98ST";
                    norsk61.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1200/2021/H%C3%98ST";
                    norsk61.URL3 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO3100/2021/H%C3%98ST";
                    context.Add(norsk61);

                    //Muligheter masterFagId 15
                    var norsk62 = new Muligheter();
                    norsk62.Id = 140;
                    norsk62.MasterFagId = 15;
                    norsk62.KlasseId = 2;
                    norsk62.Fagnavn = "Årstudium norsk, del 2";
                    norsk62.Semester = 6;
                    norsk62.Emnekode = "M5GNO1200, M5GNO1300, M5GNO3100";
                    norsk62.Studiepoeng = "30";
                    norsk62.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1200/2021/H%C3%98ST";
                    norsk62.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO1300/2021/H%C3%98ST";
                    norsk62.URL3 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNO3100/2021/H%C3%98ST";
                    context.Add(norsk62);

                    //muligheter masterFagId 15 MASTERSØK
                    var norsk_muligheter4_2 = new Muligheter();
                    norsk_muligheter4_2.Id = 77;
                    norsk_muligheter4_2.MasterFagId = 15;
                    norsk_muligheter4_2.Fagnavn = "Masteroppgave i norsk";
                    norsk_muligheter4_2.Semester = 10;
                    norsk_muligheter4_2.Emnekode = "";
                    norsk_muligheter4_2.Studiepoeng = "30";
                    context.Add(norsk_muligheter4_2);


                //Masterfag 16 Matte
                var masterfag_matte_2 = new MasterFag();
                masterfag_matte_2.Id = 16;
                masterfag_matte_2.KlasseId = 2;
                masterfag_matte_2.Fagnavn = "Matematikk";
                context.Add(masterfag_matte_2);

                    //Muligheter masterFagId 16
                    var matte_muligheter1_2 = new Muligheter();
                    matte_muligheter1_2.Id = 78;
                    matte_muligheter1_2.MasterFagId = 16;
                    matte_muligheter1_2.Fagnavn = "Matematikk og matematikkdidaktikk 1";
                    matte_muligheter1_2.Semester = 7;
                    matte_muligheter1_2.Emnekode = "MGMT4100";
                    matte_muligheter1_2.Studiepoeng = "15";
                    matte_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT4100/2021/H%C3%98ST";
                    context.Add(matte_muligheter1_2);

                    //Muligheter masterFagId 16
                    var matte_muligheter2_2 = new Muligheter();
                    matte_muligheter2_2.Id = 79;
                    matte_muligheter2_2.MasterFagId = 16;
                    matte_muligheter2_2.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                    matte_muligheter2_2.Semester = 8;
                    matte_muligheter2_2.Emnekode = "MGMT4200";
                    matte_muligheter2_2.Studiepoeng = "15";
                    matte_muligheter2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT4200/2021/H%C3%98ST";
                    context.Add(matte_muligheter2_2);

                    //Muligheter masterFagId 16
                    var matte_muligheter3_2 = new Muligheter();
                    matte_muligheter3_2.Id = 80;
                    matte_muligheter3_2.MasterFagId = 16;
                    matte_muligheter3_2.Fagnavn = "Matematikk og matematikkdidaktikk 3";
                    matte_muligheter3_2.Semester = 9;
                    matte_muligheter3_2.Emnekode = "MGMT5100";
                    matte_muligheter3_2.Studiepoeng = "15";
                    matte_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMT5100/2021/H%C3%98ST";
                    context.Add(matte_muligheter3_2);

                    //Muligheter masterFagId 16
                    var matte61 = new Muligheter();
                    matte61.Id = 143;
                    matte61.MasterFagId = 16;
                    matte61.KlasseId = 2;
                    matte61.Fagnavn = "Årstudium matte, del 1";
                    matte61.Semester = 5;
                    matte61.Emnekode = "M5GMT1100, M5GMT1200, M5GMT3100";
                    matte61.Studiepoeng = "30";
                    matte61.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1100/2021/H%C3%98ST";
                    matte61.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1200/2021/H%C3%98ST";
                    matte61.URL3 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT3100/2021/H%C3%98ST";
                    context.Add(matte61);

                    //Muligheter masterFagId 16
                    var matte62 = new Muligheter();
                    matte62.Id = 144;
                    matte62.MasterFagId = 16;
                    matte62.KlasseId = 2;
                    matte62.Fagnavn = "Årstudium matte, del 2";
                    matte62.Semester = 6;
                    matte62.Emnekode = "M5GMT1200, M5GMT1300";
                    matte62.Studiepoeng = "30";
                    matte62.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1200/2021/H%C3%98ST";
                    matte62.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMT1300/2021/H%C3%98ST";
                    context.Add(matte62);

                    //Muligheter masterFagId 16 MASTERSØK
                    var matte_muligheter4_2 = new Muligheter();
                    matte_muligheter4_2.Id = 81;
                    matte_muligheter4_2.MasterFagId = 16;
                    matte_muligheter4_2.Fagnavn = "Masteroppgave i matematikk";
                    matte_muligheter4_2.Semester = 10;
                    matte_muligheter4_2.Emnekode = "";
                    matte_muligheter4_2.Studiepoeng = "30";
                    context.Add(matte_muligheter4_2);


                //Masterfag 17 Engelsk
                var masterfag_engelsk_2 = new MasterFag();
                masterfag_engelsk_2.Id = 17;
                masterfag_engelsk_2.KlasseId = 2;
                masterfag_engelsk_2.Fagnavn = "Engelsk";
                context.Add(masterfag_engelsk_2);

                    //Muligheter masterFagId 17
                    var engelsk_muligheter1_2 = new Muligheter();
                    engelsk_muligheter1_2.Id = 82;
                    engelsk_muligheter1_2.MasterFagId = 17;
                    engelsk_muligheter1_2.Fagnavn = "Engelsk og engelskdidaktikk 1";
                    engelsk_muligheter1_2.Semester = 7;
                    engelsk_muligheter1_2.Emnekode = "MGEN4100";
                    engelsk_muligheter1_2.Studiepoeng = "15";
                    engelsk_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN4100/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter1_2);

                    //Muligheter masterFagId 17
                    var engelsk_muligheter2_2 = new Muligheter();
                    engelsk_muligheter2_2.Id = 83;
                    engelsk_muligheter2_2.MasterFagId = 17;
                    engelsk_muligheter2_2.Fagnavn = "Engelsk og engelskdidaktikk 2";
                    engelsk_muligheter2_2.Semester = 8;
                    engelsk_muligheter2_2.Emnekode = "MGEN4200";
                    engelsk_muligheter2_2.Studiepoeng = "15";
                    engelsk_muligheter2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN4200/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter2_2);

                    //Muligheter masterFagId 17
                    var engelsk_muligheter3_2 = new Muligheter();
                    engelsk_muligheter3_2.Id = 84;
                    engelsk_muligheter3_2.MasterFagId = 17;
                    engelsk_muligheter3_2.Fagnavn = "Engelsk og engelskdidaktikk 3";
                    engelsk_muligheter3_2.Semester = 9;
                    engelsk_muligheter3_2.Emnekode = "MGEN5100";
                    engelsk_muligheter3_2.Studiepoeng = "15";
                    engelsk_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGEN5100/2021/H%C3%98ST";
                    context.Add(engelsk_muligheter3_2);

                    //Muligheter masterFagId 17
                    var engelsk61 = new Muligheter();
                    engelsk61.Id = 141;
                    engelsk61.MasterFagId = 17;
                    engelsk61.KlasseId = 2;
                    engelsk61.Fagnavn = "Årstudium engelsk, del 1";
                    engelsk61.Semester = 5;
                    engelsk61.Emnekode = "M5GEN1100, M5GEN1200";
                    engelsk61.Studiepoeng = "30";
                    engelsk61.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1100/2021/H%C3%98ST";
                    engelsk61.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1200/2021/H%C3%98ST";
                    context.Add(engelsk61);

                    //Muligheter masterFagId 17
                    var engelsk62 = new Muligheter();
                    engelsk62.Id = 142;
                    engelsk62.MasterFagId = 17;
                    engelsk62.KlasseId = 2;
                    engelsk62.Fagnavn = "Årstudium engelsk, del 2";
                    engelsk62.Semester = 6;
                    engelsk62.Emnekode = "M5GEN1200, M5GEN1300, M5GEN3100";
                    engelsk62.Studiepoeng = "30";
                    engelsk62.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1200/2021/H%C3%98ST";
                    engelsk62.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN1300/2021/H%C3%98ST";
                    engelsk62.URL3 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GEN3100/2021/H%C3%98ST";
                    context.Add(engelsk62);

                    //Muligheter masterFagId 17 MASTERSØK
                    var engelsk_muligheter4_2 = new Muligheter();
                    engelsk_muligheter4_2.Id = 85;
                    engelsk_muligheter4_2.MasterFagId = 17;
                    engelsk_muligheter4_2.Fagnavn = "Masteroppgave i engelsk";
                    engelsk_muligheter4_2.Semester = 10;
                    engelsk_muligheter4_2.Emnekode = "";
                    engelsk_muligheter4_2.Studiepoeng = "30";
                    context.Add(engelsk_muligheter4_2);


                //Masterfag 18 RLE
                var masterfag_RLE_2 = new MasterFag();
                masterfag_RLE_2.Id = 18;
                masterfag_RLE_2.KlasseId = 2;
                masterfag_RLE_2.Fagnavn = "RLE";
                context.Add(masterfag_RLE_2);

                    //Muligheter masterFagId 18
                    var RLE_muligheter1_2 = new Muligheter();
                    RLE_muligheter1_2.Id = 86;
                    RLE_muligheter1_2.MasterFagId = 18;
                    RLE_muligheter1_2.KlasseId = 2;
                    RLE_muligheter1_2.Fagnavn = "RLE 1, emne 1 og 2";
                    RLE_muligheter1_2.Semester = 4;
                    RLE_muligheter1_2.Emnekode = "M5GRL2100, M5GRL2200";
                    RLE_muligheter1_2.Studiepoeng = "15 / 15";
                    RLE_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GRL2100/2021/H%C3%98ST";
                    RLE_muligheter1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GRL2200/2021/H%C3%98ST";
                    context.Add(RLE_muligheter1_2);

                    //Muligheter masterFagId 18
                    var RLE_muligheter3_2 = new Muligheter();
                    RLE_muligheter3_2.Id = 87;
                    RLE_muligheter3_2.MasterFagId = 18;
                    RLE_muligheter3_2.KlasseId = 2;
                    RLE_muligheter3_2.Fagnavn = "RLE 2, emne 3";
                    RLE_muligheter3_2.Semester = 5;
                    RLE_muligheter3_2.Emnekode = "M5GRL3100";
                    RLE_muligheter3_2.Studiepoeng = "30";
                    RLE_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GRL3100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter3_2);

                    //Muligheter masterFagId 18
                    var RLE_muligheter4_2 = new Muligheter();
                    RLE_muligheter4_2.Id = 88;
                    RLE_muligheter4_2.MasterFagId = 18;
                    RLE_muligheter4_2.Fagnavn = "RLE og RLE-didaktikk 1";
                    RLE_muligheter4_2.Semester = 7;
                    RLE_muligheter4_2.Emnekode = "MGRL4100";
                    RLE_muligheter4_2.Studiepoeng = "15";
                    RLE_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL4100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter4_2);

                    //Muligheter masterFagId 18
                    var RLE_muligheter5_2 = new Muligheter();
                    RLE_muligheter5_2.Id = 89;
                    RLE_muligheter5_2.MasterFagId = 18;
                    RLE_muligheter5_2.Fagnavn = "RLE og RLE-didaktikk 2";
                    RLE_muligheter5_2.Semester = 8;
                    RLE_muligheter5_2.Emnekode = "MGRL4200";
                    RLE_muligheter5_2.Studiepoeng = "15";
                    RLE_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL4200/2021/H%C3%98ST";
                    context.Add(RLE_muligheter5_2);

                    //Muligheter masterFagId 18
                    var RLE_muligheter6_2 = new Muligheter();
                    RLE_muligheter6_2.Id = 90;
                    RLE_muligheter6_2.MasterFagId = 18;
                    RLE_muligheter6_2.Fagnavn = "RLE og RLE-didaktikk 3";
                    RLE_muligheter6_2.Semester = 9;
                    RLE_muligheter6_2.Emnekode = "MGRL5100";
                    RLE_muligheter6_2.Studiepoeng = "15";
                    RLE_muligheter6_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGRL5100/2021/H%C3%98ST";
                    context.Add(RLE_muligheter6_2);

                    //Muligheter masterFagId 18 MASTERSØK
                    var RLE_muligheter7_2 = new Muligheter();
                    RLE_muligheter7_2.Id = 91;
                    RLE_muligheter7_2.MasterFagId = 18;
                    RLE_muligheter7_2.Fagnavn = "Masteroppgave i RLE";
                    RLE_muligheter7_2.Semester = 10;
                    RLE_muligheter7_2.Emnekode = "";
                    RLE_muligheter7_2.Studiepoeng = "30";
                    context.Add(RLE_muligheter7_2);


                //Masterfag 19 kroppsøving
                var masterfag_gym_2 = new MasterFag();
                masterfag_gym_2.Id = 19;
                masterfag_gym_2.KlasseId = 2;
                masterfag_gym_2.Fagnavn = "Kroppsøving";
                context.Add(masterfag_gym_2);

                    //Muligheter masterFagId 19
                    var gym_muligheter1_2 = new Muligheter();
                    gym_muligheter1_2.Id = 92;
                    gym_muligheter1_2.MasterFagId = 19;
                    gym_muligheter1_2.KlasseId = 2;
                    gym_muligheter1_2.Fagnavn = "Kroppsøving 1, emne 1";
                    gym_muligheter1_2.Semester = 4;
                    gym_muligheter1_2.Emnekode = "M5GKP2100";
                    gym_muligheter1_2.Studiepoeng = "30";
                    gym_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GKP2100/2021/H%C3%98ST";
                    context.Add(gym_muligheter1_2);

                    //Muligheter masterFagId 19
                    var gym_muligheter2_2 = new Muligheter();
                    gym_muligheter2_2.Id = 93;
                    gym_muligheter2_2.MasterFagId = 19;
                    gym_muligheter2_2.KlasseId = 2;
                    gym_muligheter2_2.Fagnavn = "Kroppsøving 2, emne 2";
                    gym_muligheter2_2.Semester = 5;
                    gym_muligheter2_2.Emnekode = "M1GKP3100";
                    gym_muligheter2_2.Studiepoeng = "30";
                    gym_muligheter2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GKP3100/2021/H%C3%98ST";
                    context.Add(gym_muligheter2_2);

                    //Muligheter masterFagId 19
                    var gym_muligheter3_2 = new Muligheter();
                    gym_muligheter3_2.Id = 94;
                    gym_muligheter3_2.MasterFagId = 19;
                    gym_muligheter3_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 1";
                    gym_muligheter3_2.Semester = 7;
                    gym_muligheter3_2.Emnekode = "MGKP4100";
                    gym_muligheter3_2.Studiepoeng = "15";
                    gym_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP4100/2021/H%C3%98ST";
                    context.Add(gym_muligheter3_2);

                    //Muligheter masterFagId 19
                    var gym_muligheter4_2 = new Muligheter();
                    gym_muligheter4_2.Id = 95;
                    gym_muligheter4_2.MasterFagId = 19;
                    gym_muligheter4_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 2";
                    gym_muligheter4_2.Semester = 8;
                    gym_muligheter4_2.Emnekode = "MGKP4200";
                    gym_muligheter4_2.Studiepoeng = "15";
                    gym_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP4200/2021/H%C3%98ST";
                    context.Add(gym_muligheter4_2);

                    //Muligheter masterFagId 19
                    var gym_muligheter5_2 = new Muligheter();
                    gym_muligheter5_2.Id = 96;
                    gym_muligheter5_2.MasterFagId = 19;
                    gym_muligheter5_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 3";
                    gym_muligheter5_2.Semester = 9;
                    gym_muligheter5_2.Emnekode = "MGKP5100";
                    gym_muligheter5_2.Studiepoeng = "15";
                    gym_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKP5100/2021/H%C3%98ST";
                    context.Add(gym_muligheter5_2);

                    //Muligheter masterFagId 19 MASTERSØK
                    var gym_muligheter6_2 = new Muligheter();
                    gym_muligheter6_2.Id = 97;
                    gym_muligheter6_2.MasterFagId = 19;
                    gym_muligheter6_2.Fagnavn = "Masteroppgave i kroppsøving";
                    gym_muligheter6_2.Semester = 10;
                    gym_muligheter6_2.Emnekode = "";
                    gym_muligheter6_2.Studiepoeng = "30";
                    context.Add(gym_muligheter6_2);


                //Masterfag 20 KH
                var masterfag_KH_2 = new MasterFag();
                masterfag_KH_2.Id = 20;
                masterfag_KH_2.KlasseId = 2;
                masterfag_KH_2.Fagnavn = "Kunst og håndverk";
                context.Add(masterfag_KH_2);

                    //Muligheter masterFagId 20
                    var KH_muligheter1_2 = new Muligheter();
                    KH_muligheter1_2.Id = 98;
                    KH_muligheter1_2.MasterFagId = 20;
                    KH_muligheter1_2.KlasseId = 2;
                    KH_muligheter1_2.Fagnavn = "Kunst og håndverk 1, emne 1";
                    KH_muligheter1_2.Semester = 4;
                    KH_muligheter1_2.Emnekode = "MGKH2100";
                    KH_muligheter1_2.Studiepoeng = "30";
                    KH_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKH2100/2021/H%C3%98ST";
                    context.Add(KH_muligheter1_2);

                    //Muligheter masterFagId 20
                    var KH_muligheter2_2 = new Muligheter();
                    KH_muligheter2_2.Id = 99;
                    KH_muligheter2_2.MasterFagId = 20;
                    KH_muligheter2_2.KlasseId = 2;
                    KH_muligheter2_2.Fagnavn = "Kunst og håndverk 2, emne 2";
                    KH_muligheter2_2.Semester = 5;
                    KH_muligheter2_2.Emnekode = "MGKH2100";
                    KH_muligheter2_2.Studiepoeng = "30";
                    KH_muligheter2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGKH3100/2021/H%C3%98ST";
                    context.Add(KH_muligheter2_2);

                    //Muligheter masterFagId 20
                    var KH_muligheter3_2 = new Muligheter();
                    KH_muligheter3_2.Id = 100;
                    KH_muligheter3_2.MasterFagId = 20;
                    KH_muligheter3_2.Fagnavn = "Fagdidaktikk: kunst og håndverk";
                    KH_muligheter3_2.Semester = 7;
                    KH_muligheter3_2.Emnekode = "MFAGL4000";
                    KH_muligheter3_2.Studiepoeng = "15";
                    KH_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL4000/2021/H%C3%98ST";
                    context.Add(KH_muligheter3_2);

                    //Muligheter masterFagId 20
                    var KH_muligheter4_2 = new Muligheter();
                    KH_muligheter4_2.Id = 101;
                    KH_muligheter4_2.MasterFagId = 20;
                    KH_muligheter4_2.Fagnavn = "Praktisk estetisk prosjekt";
                    KH_muligheter4_2.Semester = 8;
                    KH_muligheter4_2.Emnekode = "MFAGL4200";
                    KH_muligheter4_2.Studiepoeng = "15";
                    KH_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL4200/2021/H%C3%98ST";
                    context.Add(KH_muligheter4_2);

                    //Muligheter masterFagId 20
                    var KH_muligheter5_2 = new Muligheter();
                    KH_muligheter5_2.Id = 102;
                    KH_muligheter5_2.MasterFagId = 20;
                    KH_muligheter5_2.Fagnavn = "Prosjektutvikling og undervisningspraksis";
                    KH_muligheter5_2.Semester = 9;
                    KH_muligheter5_2.Emnekode = "MFAGL5000";
                    KH_muligheter5_2.Studiepoeng = "15";
                    KH_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MFAGL5000/2021/H%C3%98ST";
                    context.Add(KH_muligheter5_2);

                    //Muligheter masterFagId 20 MASTERSØK
                    var KH_muligheter6_2 = new Muligheter();
                    KH_muligheter6_2.Id = 103;
                    KH_muligheter6_2.MasterFagId = 20;
                    KH_muligheter6_2.Fagnavn = "Masteroppgave i prosjektutvikling og undervisningspraksis";
                    KH_muligheter6_2.Semester = 10;
                    KH_muligheter6_2.Emnekode = "";
                    KH_muligheter6_2.Studiepoeng = "30";
                    context.Add(KH_muligheter6_2);

                //Masterfag 21 Musikk
                var masterfag_musikk_2 = new MasterFag();
                masterfag_musikk_2.Id = 21;
                masterfag_musikk_2.KlasseId = 2;
                masterfag_musikk_2.Fagnavn = "Musikk";
                context.Add(masterfag_musikk_2);

                    //Muligheter masterFagId 21
                    var musikk_muligheter1_2 = new Muligheter();
                    musikk_muligheter1_2.Id = 104;
                    musikk_muligheter1_2.MasterFagId = 21;
                    musikk_muligheter1_2.KlasseId = 2;
                    musikk_muligheter1_2.Fagnavn = "Musikk 1, emne 1 og 2";
                    musikk_muligheter1_2.Semester = 4;
                    musikk_muligheter1_2.Emnekode = "M5GMU2100, M5GMU2200";
                    musikk_muligheter1_2.Studiepoeng = "15 / 15";
                    musikk_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMU2100/2021/H%C3%98ST";
                    musikk_muligheter1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMU2200/2021/H%C3%98ST";
                    context.Add(musikk_muligheter1_2);

                    //Muligheter masterFagId 21
                    var musikk_muligheter3_2 = new Muligheter();
                    musikk_muligheter3_2.Id = 105;
                    musikk_muligheter3_2.MasterFagId = 21;
                    musikk_muligheter3_2.KlasseId = 2;
                    musikk_muligheter3_2.Fagnavn = "Musikk 2, emne 3";
                    musikk_muligheter3_2.Semester = 5;
                    musikk_muligheter3_2.Emnekode = "M5GMU3100";
                    musikk_muligheter3_2.Studiepoeng = "30";
                    musikk_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GMU3100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter3_2);

                    //Muligheter masterFagId 21
                    var musikk_muligheter4_2 = new Muligheter();
                    musikk_muligheter4_2.Id = 106;
                    musikk_muligheter4_2.MasterFagId = 21;
                    musikk_muligheter4_2.Fagnavn = "Musikk og musikkdidaktikk 1";
                    musikk_muligheter4_2.Semester = 7;
                    musikk_muligheter4_2.Emnekode = "MGMU4100";
                    musikk_muligheter4_2.Studiepoeng = "15";
                    musikk_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU4100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter4_2);

                    //Muligheter masterFagId 22
                    var musikk_muligheter5_2 = new Muligheter();
                    musikk_muligheter5_2.Id = 107;
                    musikk_muligheter5_2.MasterFagId = 21;
                    musikk_muligheter5_2.Fagnavn = "Musikk og musikkdidaktikk 2";
                    musikk_muligheter5_2.Semester = 8;
                    musikk_muligheter5_2.Emnekode = "MGMU4200";
                    musikk_muligheter5_2.Studiepoeng = "15";
                    musikk_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU4200/2021/H%C3%98ST";
                    context.Add(musikk_muligheter5_2);

                    //Muligheter masterFagId 21
                    var musikk_muligheter6_2 = new Muligheter();
                    musikk_muligheter6_2.Id = 108;
                    musikk_muligheter6_2.MasterFagId = 21;
                    musikk_muligheter6_2.Fagnavn = "Musikk og musikkdidaktikk 3";
                    musikk_muligheter6_2.Semester = 9;
                    musikk_muligheter6_2.Emnekode = "MGMU5100";
                    musikk_muligheter6_2.Studiepoeng = "15";
                    musikk_muligheter6_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMU5100/2021/H%C3%98ST";
                    context.Add(musikk_muligheter6_2);

                    //Muligheter masterFagId 21 MASTERSØK
                    var musikk_muligheter7_2 = new Muligheter();
                    musikk_muligheter7_2.Id = 109;
                    musikk_muligheter7_2.MasterFagId = 21;
                    musikk_muligheter7_2.Fagnavn = "Masteroppgave i musikk";
                    musikk_muligheter7_2.Semester = 10;
                    musikk_muligheter7_2.Emnekode = "";
                    musikk_muligheter7_2.Studiepoeng = "30";
                    context.Add(musikk_muligheter7_2);


                //Masterfag 22 Naturfag
                var masterfag_naturfag_2 = new MasterFag();
                masterfag_naturfag_2.Id = 22;
                masterfag_naturfag_2.KlasseId = 2;
                masterfag_naturfag_2.Fagnavn = "Naturfag";
                context.Add(masterfag_naturfag_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter1_2 = new Muligheter();
                    naturfag_muligheter1_2.Id = 110;
                    naturfag_muligheter1_2.MasterFagId = 22;
                    naturfag_muligheter1_2.KlasseId = 2;
                    naturfag_muligheter1_2.Fagnavn = "Naturfag 1, emne 1 og 2";
                    naturfag_muligheter1_2.Semester = 4;
                    naturfag_muligheter1_2.Emnekode = "M5GNA2100, M5GNA2200";
                    naturfag_muligheter1_2.Studiepoeng = "15 / 15";
                    naturfag_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNA2100/2021/H%C3%98ST";
                    naturfag_muligheter1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNA2200/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter1_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter3_2 = new Muligheter();
                    naturfag_muligheter3_2.Id = 112;
                    naturfag_muligheter3_2.MasterFagId = 22;
                    naturfag_muligheter3_2.KlasseId = 2;
                    naturfag_muligheter3_2.Fagnavn = "Naturfag 2, emne 3";
                    naturfag_muligheter3_2.Semester = 5;
                    naturfag_muligheter3_2.Emnekode = "M5GNA3100";
                    naturfag_muligheter3_2.Studiepoeng = "30";
                    naturfag_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GNA3100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter3_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter4_2 = new Muligheter();
                    naturfag_muligheter4_2.Id = 113;
                    naturfag_muligheter4_2.MasterFagId = 22;
                    naturfag_muligheter4_2.Fagnavn = "Naturfag og naturfagdidaktikk 1";
                    naturfag_muligheter4_2.Semester = 7;
                    naturfag_muligheter4_2.Emnekode = "MGNA4100";
                    naturfag_muligheter4_2.Studiepoeng = "15";
                    naturfag_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA4100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter4_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter5_2 = new Muligheter();
                    naturfag_muligheter5_2.Id = 114;
                    naturfag_muligheter5_2.MasterFagId = 22;
                    naturfag_muligheter5_2.Fagnavn = "Naturfag og naturfagdidaktikk 2";
                    naturfag_muligheter5_2.Semester = 8;
                    naturfag_muligheter5_2.Emnekode = "MGNA4200";
                    naturfag_muligheter5_2.Studiepoeng = "15";
                    naturfag_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA4200/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter5_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter6_2 = new Muligheter();
                    naturfag_muligheter6_2.Id = 115;
                    naturfag_muligheter6_2.MasterFagId = 22;
                    naturfag_muligheter6_2.Fagnavn = "Naturfag og naturfagdidaktikk 3";
                    naturfag_muligheter6_2.Semester = 9;
                    naturfag_muligheter6_2.Emnekode = "MGNA5100";
                    naturfag_muligheter6_2.Studiepoeng = "15";
                    naturfag_muligheter6_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNA5100/2021/H%C3%98ST";
                    context.Add(naturfag_muligheter6_2);

                    //Muligheter masterFagId 22
                    var naturfag_muligheter7_2 = new Muligheter();
                    naturfag_muligheter7_2.Id = 116;
                    naturfag_muligheter7_2.MasterFagId = 22;
                    naturfag_muligheter7_2.Fagnavn = "Masteroppgave i naturfag";
                    naturfag_muligheter7_2.Semester = 10;
                    naturfag_muligheter7_2.Emnekode = "MGNA5100";
                    naturfag_muligheter7_2.Studiepoeng = "60";
                    context.Add(naturfag_muligheter7_2);


                //Masterfag 23 samfunnsfag
                var masterfag_samfunnsfag_2 = new MasterFag();
                masterfag_samfunnsfag_2.Id = 23;
                masterfag_samfunnsfag_2.KlasseId = 2;
                masterfag_samfunnsfag_2.Fagnavn = "Samfunnsfag";
                context.Add(masterfag_samfunnsfag_2);

                    //Muligheter masterFagId 23
                    var samfunnsfag_muligheter1_2 = new Muligheter();
                    samfunnsfag_muligheter1_2.Id = 117;
                    samfunnsfag_muligheter1_2.MasterFagId = 23;
                    samfunnsfag_muligheter1_2.KlasseId = 2;
                    samfunnsfag_muligheter1_2.Fagnavn = "Samfunnsfag 1, emne 1 og 2";
                    samfunnsfag_muligheter1_2.Semester = 4;
                    samfunnsfag_muligheter1_2.Emnekode = "M5GSF2100, M5GSF2200";
                    samfunnsfag_muligheter1_2.Studiepoeng = "15 / 15";
                    samfunnsfag_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GSF2100/2021/H%C3%98ST";
                    samfunnsfag_muligheter1_2.URL2 = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GSF2200/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter1_2);

                    //Muligheter masterFagId 23
                    var samfunnsfag_muligheter3_2 = new Muligheter();
                    samfunnsfag_muligheter3_2.Id = 118;
                    samfunnsfag_muligheter3_2.MasterFagId = 23;
                    samfunnsfag_muligheter3_2.KlasseId = 2;
                    samfunnsfag_muligheter3_2.Fagnavn = "Samfunnsfag 2, emne 3";
                    samfunnsfag_muligheter3_2.Semester = 5;
                    samfunnsfag_muligheter3_2.Emnekode = "M5GSF3100";
                    samfunnsfag_muligheter3_2.Studiepoeng = "30";
                    samfunnsfag_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/M5GSF3100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter3_2);

                    //Muligheter masterFagId 23
                    var samfunnsfag_muligheter4_2 = new Muligheter();
                    samfunnsfag_muligheter4_2.Id = 119;
                    samfunnsfag_muligheter4_2.MasterFagId = 23;
                    samfunnsfag_muligheter4_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 1";
                    samfunnsfag_muligheter4_2.Semester = 7;
                    samfunnsfag_muligheter4_2.Emnekode = "MGSF4100";
                    samfunnsfag_muligheter4_2.Studiepoeng = "15";
                    samfunnsfag_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF4100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter4_2);

                    //Muligheter masterFagId 23
                    var samfunnsfag_muligheter5_2 = new Muligheter();
                    samfunnsfag_muligheter5_2.Id = 120;
                    samfunnsfag_muligheter5_2.MasterFagId = 23;
                    samfunnsfag_muligheter5_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 2";
                    samfunnsfag_muligheter5_2.Semester = 8;
                    samfunnsfag_muligheter5_2.Emnekode = "MGSF4200";
                    samfunnsfag_muligheter5_2.Studiepoeng = "15";
                    samfunnsfag_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF4200/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter5_2);

                    //Muligheter masterFagId 23
                    var samfunnsfag_muligheter6_2 = new Muligheter();
                    samfunnsfag_muligheter6_2.Id = 121;
                    samfunnsfag_muligheter6_2.MasterFagId = 23;
                    samfunnsfag_muligheter6_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 3";
                    samfunnsfag_muligheter6_2.Semester = 9;
                    samfunnsfag_muligheter6_2.Emnekode = "MGSF5100";
                    samfunnsfag_muligheter6_2.Studiepoeng = "15";
                    samfunnsfag_muligheter6_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGSF5100/2021/H%C3%98ST";
                    context.Add(samfunnsfag_muligheter6_2);

                    //Muligheter masterFagId 23 MASTERSØK
                    var samfunnsfag_muligheter7_2 = new Muligheter();
                    samfunnsfag_muligheter7_2.Id = 122;
                    samfunnsfag_muligheter7_2.MasterFagId = 23;
                    samfunnsfag_muligheter7_2.Fagnavn = "Masteroppgave i samfunnsfag";
                    samfunnsfag_muligheter7_2.Semester = 10;
                    samfunnsfag_muligheter7_2.Emnekode = "";
                    samfunnsfag_muligheter7_2.Studiepoeng = "30";
                    context.Add(samfunnsfag_muligheter7_2);

                //Masterfag 24 Tegnspråk
                var masterfag_tegnspråk_2 = new MasterFag();
                masterfag_tegnspråk_2.Id = 24;
                masterfag_tegnspråk_2.KlasseId = 2;
                masterfag_tegnspråk_2.Fagnavn = "Tegnspråk";
                context.Add(masterfag_tegnspråk_2);

                    //Muligheter masterFagId 24
                    var tegnspråk_muligheter1_2 = new Muligheter();
                    tegnspråk_muligheter1_2.Id = 123;
                    tegnspråk_muligheter1_2.MasterFagId = 24;
                    tegnspråk_muligheter1_2.KlasseId = 2;
                    tegnspråk_muligheter1_2.Fagnavn = "Norsk tegnspråk 1";
                    tegnspråk_muligheter1_2.Semester = 5;
                    tegnspråk_muligheter1_2.Emnekode = "MGNT3100";
                    tegnspråk_muligheter1_2.Studiepoeng = "30";
                    tegnspråk_muligheter1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT3100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter1_2);

                    //Muligheter masterFagId 24
                    var tegnspråk_muligheter2_2 = new Muligheter();
                    tegnspråk_muligheter2_2.Id = 124;
                    tegnspråk_muligheter2_2.MasterFagId = 24;
                    tegnspråk_muligheter2_2.KlasseId = 2;
                    tegnspråk_muligheter2_2.Fagnavn = "Norsk tegnspråk 2";
                    tegnspråk_muligheter2_2.Semester = 6;
                    tegnspråk_muligheter2_2.Emnekode = "MGNT3200";
                    tegnspråk_muligheter2_2.Studiepoeng = "30";
                    tegnspråk_muligheter2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT3200/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter2_2);

                    //Muligheter masterFagId 24
                    var tegnspråk_muligheter3_2 = new Muligheter();
                    tegnspråk_muligheter3_2.Id = 125;
                    tegnspråk_muligheter3_2.MasterFagId = 24;
                    tegnspråk_muligheter3_2.Fagnavn = "Norsk tegnspråk og tegnspråksdidktikk 1";
                    tegnspråk_muligheter3_2.Semester = 7;
                    tegnspråk_muligheter3_2.Emnekode = "MGNT4100";
                    tegnspråk_muligheter3_2.Studiepoeng = "15";
                    tegnspråk_muligheter3_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT4100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter3_2);

                    //Muligheter masterFagId 24
                    var tegnspråk_muligheter4_2 = new Muligheter();
                    tegnspråk_muligheter4_2.Id = 126;
                    tegnspråk_muligheter4_2.MasterFagId = 24;
                    tegnspråk_muligheter4_2.Fagnavn = "Norsk tegnspråk og tegnspråksdidktikk 2";
                    tegnspråk_muligheter4_2.Semester = 8;
                    tegnspråk_muligheter4_2.Emnekode = "MGNT4200";
                    tegnspråk_muligheter4_2.Studiepoeng = "15";
                    tegnspråk_muligheter4_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT4200/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter4_2);

                    //Muligheter masterFagId 24
                    var tegnspråk_muligheter5_2 = new Muligheter();
                    tegnspråk_muligheter5_2.Id = 127;
                    tegnspråk_muligheter5_2.MasterFagId = 24;
                    tegnspråk_muligheter5_2.Fagnavn = "Norsk tegnspråk og tegnspråksdidktikk 3";
                    tegnspråk_muligheter5_2.Semester = 9;
                    tegnspråk_muligheter5_2.Emnekode = "MGNT5100";
                    tegnspråk_muligheter5_2.Studiepoeng = "15";
                    tegnspråk_muligheter5_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGNT5100/2021/H%C3%98ST";
                    context.Add(tegnspråk_muligheter5_2);

                    //Muligheter masterFagId 24 MASTERSØK
                    var tegnspråk_muligheter6_2 = new Muligheter();
                    tegnspråk_muligheter6_2.Id = 128;
                    tegnspråk_muligheter6_2.MasterFagId = 24;
                    tegnspråk_muligheter6_2.Fagnavn = "Masteroppgave i tegnspråk";
                    tegnspråk_muligheter6_2.Semester = 10;
                    tegnspråk_muligheter6_2.Emnekode = "";
                    tegnspråk_muligheter6_2.Studiepoeng = "30";
                    context.Add(tegnspråk_muligheter6_2);


                //Masterfag 25 Profesjonell pedagogikk
                var masterfag_profped_2 = new MasterFag();
                masterfag_profped_2.Id = 25;
                masterfag_profped_2.KlasseId = 2;
                masterfag_profped_2.Fagnavn = "Profesjonsrettet pedagogikk";
                context.Add(masterfag_profped_2);

                    //Muligheter masterFagId 25
                    var prof_ped1_2 = new Muligheter();
                    prof_ped1_2.Id = 129;
                    prof_ped1_2.MasterFagId = 25;
                    prof_ped1_2.KlasseId = 2;
                    prof_ped1_2.Fagnavn = "fordypning 1: Profesjonsrettet pedagogikk";
                    prof_ped1_2.Semester = 6;
                    prof_ped1_2.Emnekode = "MGPE3100";
                    prof_ped1_2.Studiepoeng = "30";
                    prof_ped1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3100/2021/H%C3%98ST";
                    context.Add(prof_ped1_2);

                    //Muligheter masterFagId 22
                    var prof_ped2_2 = new Muligheter();
                    prof_ped2_2.Id = 130;
                    prof_ped2_2.MasterFagId = 25;
                    prof_ped2_2.Fagnavn = "fordypning 2: Profesjonsrettet pedagogikk";
                    prof_ped2_2.Semester = 9;
                    prof_ped2_2.Emnekode = "MGPE5100";
                    prof_ped2_2.Studiepoeng = "30";
                    prof_ped2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5100/2021/H%C3%98ST";
                    context.Add(prof_ped2_2);

                    //Muligheter masterFagId 22 MASTERSØK
                    var prof_ped3_2 = new Muligheter();
                    prof_ped3_2.Id = 131;
                    prof_ped3_2.MasterFagId = 25;
                    prof_ped3_2.Fagnavn = "Masteroppgave i profesjonsrettet pedagogikk";
                    prof_ped3_2.Semester = 10;
                    prof_ped3_2.Emnekode = "";
                    prof_ped3_2.Studiepoeng = "30";
                    context.Add(prof_ped3_2);


                //Masterfag 26 digital pedagogikk
                var masterfag_digped_2 = new MasterFag();
                masterfag_digped_2.Id = 26;
                masterfag_digped_2.KlasseId = 2;
                masterfag_digped_2.Fagnavn = "Digitalt støttet pedagogikk";
                context.Add(masterfag_digped_2);

                    //Muligheter masterFagId 26
                    var dig_ped1_2 = new Muligheter();
                    dig_ped1_2.Id = 132;
                    dig_ped1_2.MasterFagId = 26;
                    dig_ped1_2.KlasseId = 2;
                    dig_ped1_2.Fagnavn = "fordypning 1: Digitalt støttet pedagogikk";
                    dig_ped1_2.Semester = 6;
                    dig_ped1_2.Emnekode = "MGPE3200";
                    dig_ped1_2.Studiepoeng = "30";
                    dig_ped1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3200/2021/H%C3%98ST";
                    context.Add(dig_ped1_2);

                    //Muligheter masterFagId 26
                    var dig_ped2_2 = new Muligheter();
                    dig_ped2_2.Id = 133;
                    dig_ped2_2.MasterFagId = 26;
                    dig_ped2_2.Fagnavn = "fordypning 2: Digitalt støttet pedagogikk";
                    dig_ped2_2.Semester = 9;
                    dig_ped2_2.Emnekode = "MGPE5200";
                    dig_ped2_2.Studiepoeng = "30";
                    dig_ped2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5200/2021/H%C3%98ST";
                    context.Add(dig_ped2_2);

                    //Muligheter masterFagId 26 MASTERSØK
                    var dig_ped3_2 = new Muligheter();
                    dig_ped3_2.Id = 134;
                    dig_ped3_2.MasterFagId = 26;
                    dig_ped3_2.Fagnavn = "Masteroppgave i digitalt støttet pedagogikk";
                    dig_ped3_2.Semester = 10;
                    dig_ped3_2.Emnekode = "";
                    dig_ped3_2.Studiepoeng = "30";
                    context.Add(dig_ped3_2);


                //Masterfag 27 Profesjonell pedagogikk
                var masterfag_spesped_2 = new MasterFag();
                masterfag_spesped_2.Id = 27;
                masterfag_spesped_2.KlasseId = 2;
                masterfag_spesped_2.Fagnavn = "Spesialpedagogikk";
                context.Add(masterfag_spesped_2);

                    //Muligheter masterFagId 27
                    var spes_ped1_2 = new Muligheter();
                    spes_ped1_2.Id = 135;
                    spes_ped1_2.MasterFagId = 27;
                    spes_ped1_2.KlasseId = 2;
                    spes_ped1_2.Fagnavn = "fordypning 1: Spesialpedagogikk";
                    spes_ped1_2.Semester = 6;
                    spes_ped1_2.Emnekode = "MGPE3300";
                    spes_ped1_2.Studiepoeng = "30";
                    spes_ped1_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE3300/2021/H%C3%98ST";
                    context.Add(spes_ped1_2);

                    //Muligheter masterFagId 27
                    var spes_ped2_2 = new Muligheter();
                    spes_ped2_2.Id = 136;
                    spes_ped2_2.MasterFagId = 27;
                    spes_ped2_2.Fagnavn = "fordypning 2: Spesialpedagogikk";
                    spes_ped2_2.Semester = 9;
                    spes_ped2_2.Emnekode = "MGPE5300";
                    spes_ped2_2.Studiepoeng = "30";
                    spes_ped2_2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGPE5300/2021/H%C3%98ST";
                    context.Add(spes_ped2_2);

                    //Muligheter masterFagId 27 MASTERSØK
                    var spes_ped3_2 = new Muligheter();
                    spes_ped3_2.Id = 137;
                    spes_ped3_2.MasterFagId = 27;
                    spes_ped3_2.Fagnavn = "Masteroppgave i spesialpedagogikk";
                    spes_ped3_2.Semester = 10;
                    spes_ped3_2.Emnekode = "";
                    spes_ped3_2.Studiepoeng = "30";
                    context.Add(spes_ped3_2);


                //mat og helse id 30 
                var mat_helse2 = new MasterFag();
                mat_helse2.Id = 30;
                mat_helse2.KlasseId = 4;
                context.Add(mat_helse2);

                    //Muligheter masterFagId 30
                    var mathelse2 = new Muligheter();
                    mathelse2.Id = 138;
                    mathelse2.MasterFagId = 30;
                    mathelse2.KlasseId = 2;
                    mathelse2.Fagnavn = "Mat og helse 1, emne 1";
                    mathelse2.Semester = 6;
                    mathelse2.Emnekode = "MGMH2100";
                    mathelse2.Studiepoeng = "30";
                    mathelse2.URL = "https://student.oslomet.no/studier/-/studieinfo/emne/MGMH2100/2021/H%C3%98ST";
                    context.Add(mathelse2);

                context.SaveChanges();
            }
        }
    }
}

