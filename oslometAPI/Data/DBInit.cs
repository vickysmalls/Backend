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
                        oblig_matte1.Fagnavn = "Matematikk 1, emne 1";
                        oblig_matte1.Semester = 1;
                        oblig_matte1.Emnekode = "M1GMT1100";
                        oblig_matte1.KlasseId = 1;
                        context.Add(oblig_matte1);

                        var oblig_matte2 = new ObligFags();
                        oblig_matte2.Id = 2;
                        oblig_matte2.Fagnavn = "Matematikk 1, emne 2";
                        oblig_matte2.Semester = 2;
                        oblig_matte2.Emnekode = "M1GMT1200";
                        oblig_matte2.KlasseId = 1;
                        context.Add(oblig_matte2);

                        var oblig_matte3 = new ObligFags();
                        oblig_matte3.Id = 3;
                        oblig_matte3.Fagnavn = "Matematikk 1, emne 3";
                        oblig_matte3.Semester = 3;
                        oblig_matte3.Emnekode = "M1GMT2100";
                        oblig_matte3.KlasseId = 1;
                        context.Add(oblig_matte3);


                        //obligatorisk norskfag
                        var oblig_norsk1 = new ObligFags();
                        oblig_norsk1.Id = 4;
                        oblig_norsk1.Fagnavn = "Norsk 1, emne 1";
                        oblig_norsk1.Semester = 1;
                        oblig_norsk1.Emnekode = "M1GNO1100";
                        oblig_norsk1.KlasseId = 1;
                        context.Add(oblig_norsk1);

                        var oblig_norsk2 = new ObligFags();
                        oblig_norsk2.Id = 5;
                        oblig_norsk2.Fagnavn = "Norsk 1, emne 2";
                        oblig_norsk2.Semester = 2;
                        oblig_norsk2.Emnekode = "M1GNO1200";
                        oblig_norsk2.KlasseId = 1;
                        context.Add(oblig_norsk2);

                        var oblig_norsk3 = new ObligFags();
                        oblig_norsk3.Id = 6;
                        oblig_norsk3.Fagnavn = "Norsk 1, emne 3";
                        oblig_norsk3.Semester = 3;
                        oblig_norsk1.Emnekode = "M1GNO2100";
                        oblig_norsk3.KlasseId = 1;
                        context.Add(oblig_norsk3);


                   

                    //fylle tabell 4. sem
                    //fylle tabell 5. sem
                    //fylle tabell 6. sem



                        //Masterfag 1 Norsk
                        var masterfag_norsk = new MasterFag();
                        masterfag_norsk.Id = 1;
                        masterfag_norsk.Fagnavn = "Norsk";
                        masterfag_norsk.KlasseId = 1;
                        context.Add(masterfag_norsk);

                            //muligheter masterFagId 1
                            var norsk_muligheter1 = new Muligheter();
                            norsk_muligheter1.Id = 1;
                            norsk_muligheter1.Fagnavn = "Norsk 2, emne 4";
                            norsk_muligheter1.Semester = 5;
                            norsk_muligheter1.Emnekode = "M1GNO3100";
                            norsk_muligheter1.MasterFagId = 1;
                            context.Add(norsk_muligheter1);

                            //muligheter masterFagId 1
                            var norsk_muligheter2 = new Muligheter();
                            norsk_muligheter2.Id = 2;
                            norsk_muligheter2.Fagnavn = "Norsk og norskdidaktikk 1";
                            norsk_muligheter2.Semester = 7;
                            norsk_muligheter2.Emnekode = "MGNO4100";
                            norsk_muligheter2.MasterFagId = 1;
                            context.Add(norsk_muligheter2);

                            //muligheter masterFagId 1
                            var norsk_muligheter3 = new Muligheter();
                            norsk_muligheter3.Id = 3;
                            norsk_muligheter3.Fagnavn = "Norsk og norskdidaktikk 2";
                            norsk_muligheter3.Semester = 8;
                            norsk_muligheter3.Emnekode = "MGNO4200";
                            norsk_muligheter3.MasterFagId = 1;
                            context.Add(norsk_muligheter3);

                            //muligheter masterFagId 1
                            var norsk_muligheter4 = new Muligheter();
                            norsk_muligheter4.Id = 4;
                            norsk_muligheter4.Fagnavn = "Norsk og norskdidaktikk 3";
                            norsk_muligheter4.Semester = 9;
                            norsk_muligheter4.Emnekode = "MGNO5100";
                            norsk_muligheter4.MasterFagId = 1;
                            context.Add(norsk_muligheter4);



                        //Masterfag 2 Matte
                        var masterfag_matte = new MasterFag();
                        masterfag_matte.Id = 2;
                        masterfag_matte.Fagnavn = "Matte";
                        masterfag_matte.KlasseId = 1;
                        context.Add(masterfag_matte);

                            //Muligheter masterFagId 2
                            var matte_muligheter1 = new Muligheter();
                            matte_muligheter1.Id = 5;
                            matte_muligheter1.Fagnavn = "Matematikk 2, emne 4";
                            matte_muligheter1.Semester = 5;
                            matte_muligheter1.Emnekode = "M1GMT3100";
                            matte_muligheter1.MasterFagId = 2;
                            context.Add(matte_muligheter1);

                            //Muligheter masterFagId 2
                            var matte_muligheter2 = new Muligheter();
                            matte_muligheter2.Id = 6;
                            matte_muligheter2.Fagnavn = "Matematikk og matematikkdidaktikk 1";
                            matte_muligheter2.Semester = 7;
                            matte_muligheter2.Emnekode = "MGMT4100";
                            matte_muligheter2.MasterFagId = 2;
                            context.Add(matte_muligheter2);

                            //Muligheter masterFagId 2
                            var matte_muligheter3 = new Muligheter();
                            matte_muligheter3.Id = 7;
                            matte_muligheter3.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                            matte_muligheter3.Semester = 8;
                            matte_muligheter3.Emnekode = "MGMT4200";
                            matte_muligheter3.MasterFagId = 2;
                            context.Add(matte_muligheter3);

                            //Muligheter masterFagId 2
                            var matte_muligheter4 = new Muligheter();
                            matte_muligheter4.Id = 8;
                            matte_muligheter4.Fagnavn = "Matematikk og matematikkdidaktikk 3";
                            matte_muligheter4.Semester = 9;
                            matte_muligheter4.Emnekode = "MGMT5100";
                            matte_muligheter4.MasterFagId = 2;
                            context.Add(matte_muligheter4);



                        //Masterfag 3 Engelsk
                        var masterfag_engelsk = new MasterFag();
                        masterfag_engelsk.Id = 3;
                        masterfag_engelsk.Fagnavn = "Engelsk";
                        masterfag_engelsk.KlasseId = 1;
                        context.Add(masterfag_engelsk);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter1 = new Muligheter();
                            engelsk_muligheter1.Id = 9;
                            engelsk_muligheter1.Fagnavn = "Engelsk 1, emne 1";
                            engelsk_muligheter1.Semester = 4;
                            engelsk_muligheter1.Emnekode = "M1GEN2100";
                            engelsk_muligheter1.MasterFagId = 3;
                            context.Add(engelsk_muligheter1);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter2 = new Muligheter();
                            engelsk_muligheter2.Id = 10;
                            engelsk_muligheter2.Fagnavn = "Engelsk 1, emne 2";
                            engelsk_muligheter2.Semester = 4;
                            engelsk_muligheter2.Emnekode = "M1GEN2200";
                            engelsk_muligheter2.MasterFagId = 3;
                            context.Add(engelsk_muligheter2);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter3 = new Muligheter();
                            engelsk_muligheter3.Id = 11;
                            engelsk_muligheter3.Fagnavn = "Engelsk 2, emne 3";
                            engelsk_muligheter3.Semester = 5;
                            engelsk_muligheter3.Emnekode = "M1GEN3100";
                            engelsk_muligheter3.MasterFagId = 3;
                            context.Add(engelsk_muligheter3);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter4 = new Muligheter();
                            engelsk_muligheter4.Id = 12;
                            engelsk_muligheter4.Fagnavn = "Engelsk og engelskdidaktikk 1";
                            engelsk_muligheter4.Semester = 7;
                            engelsk_muligheter4.Emnekode = "MGEN4100";
                            engelsk_muligheter4.MasterFagId = 3;
                            context.Add(engelsk_muligheter4);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter5 = new Muligheter();
                            engelsk_muligheter5.Id = 13;
                            engelsk_muligheter5.Fagnavn = "Engelsk og engelskdidaktikk 2";
                            engelsk_muligheter5.Semester = 8;
                            engelsk_muligheter5.Emnekode = "MGEN4200";
                            engelsk_muligheter5.MasterFagId = 3;
                            context.Add(engelsk_muligheter5);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter6 = new Muligheter();
                            engelsk_muligheter6.Id = 14;
                            engelsk_muligheter6.Fagnavn = "Engelsk og engelskdidaktikk 3";
                            engelsk_muligheter6.Semester = 9;
                            engelsk_muligheter6.Emnekode = "MGEN5100";
                            engelsk_muligheter6.MasterFagId = 3;
                            context.Add(engelsk_muligheter6);



                        //Masterfag 4 KRLE
                        var masterfag_KRLE = new MasterFag();
                        masterfag_KRLE.Id = 4;
                        masterfag_KRLE.Fagnavn = "KRLE";
                        masterfag_KRLE.KlasseId = 1;
                        context.Add(masterfag_KRLE);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter1 = new Muligheter();
                            KRLE_muligheter1.Id = 15;
                            KRLE_muligheter1.Fagnavn = "RLE 1, emne 1";
                            KRLE_muligheter1.Semester = 4;
                            KRLE_muligheter1.Emnekode = "M1GRL2100";
                            KRLE_muligheter1.MasterFagId = 4;
                            context.Add(KRLE_muligheter1);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter2 = new Muligheter();
                            KRLE_muligheter2.Id = 16;
                            KRLE_muligheter2.Fagnavn = "RLE 1, emne 2";
                            KRLE_muligheter2.Semester = 4;
                            KRLE_muligheter2.Emnekode = "M1GRL2200";
                            KRLE_muligheter2.MasterFagId = 4;
                            context.Add(KRLE_muligheter2);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter3 = new Muligheter();
                            KRLE_muligheter3.Id = 17;
                            KRLE_muligheter3.Fagnavn = "RLE 2, emne 3";
                            KRLE_muligheter3.Semester = 5;
                            KRLE_muligheter3.Emnekode = "M1GRL3100";
                            KRLE_muligheter3.MasterFagId = 4;
                            context.Add(KRLE_muligheter3);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter4 = new Muligheter();
                            KRLE_muligheter4.Id = 18;
                            KRLE_muligheter4.Fagnavn = "RLE og RLE-didaktikk 1";
                            KRLE_muligheter4.Semester = 7;
                            KRLE_muligheter4.Emnekode = "MGRL4100";
                            KRLE_muligheter4.MasterFagId = 4;
                            context.Add(KRLE_muligheter4);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter5 = new Muligheter();
                            KRLE_muligheter5.Id = 19;
                            KRLE_muligheter5.Fagnavn = "RLE og RLE-didaktikk 2";
                            KRLE_muligheter5.Semester = 8;
                            KRLE_muligheter5.Emnekode = "MGRL4200";
                            KRLE_muligheter5.MasterFagId = 4;
                            context.Add(KRLE_muligheter5);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter6 = new Muligheter();
                            KRLE_muligheter6.Id = 20;
                            KRLE_muligheter6.Fagnavn = "RLE og RLE-didaktikk 3";
                            KRLE_muligheter6.Semester = 9;
                            KRLE_muligheter6.Emnekode = "MGRL5100";
                            KRLE_muligheter6.MasterFagId = 4;
                            context.Add(KRLE_muligheter6);



                        //Masterfag 5 kroppsøving
                        var masterfag_gym = new MasterFag();
                        masterfag_gym.Id = 5;
                        masterfag_gym.Fagnavn = "Gym";
                        masterfag_gym.KlasseId = 1;
                        context.Add(masterfag_gym);

                            //Muligheter masterFagId 5
                            var gym_muligheter1 = new Muligheter();
                            gym_muligheter1.Id = 21;
                            gym_muligheter1.Fagnavn = "Kroppsøving 1, emne 1";
                            gym_muligheter1.Semester = 4;
                            gym_muligheter1.Emnekode = "M1GKP2100";
                            gym_muligheter1.MasterFagId = 5;
                            context.Add(gym_muligheter1);

                            //Muligheter masterFagId 5
                            var gym_muligheter2 = new Muligheter();
                            gym_muligheter2.Id = 22;
                            gym_muligheter2.Fagnavn = "Kroppsøving 2, emne 2";
                            gym_muligheter2.Semester = 5;
                            gym_muligheter2.Emnekode = "M1GKP3100";
                            gym_muligheter2.MasterFagId = 5;
                            context.Add(gym_muligheter2);

                            //Muligheter masterFagId 5
                            var gym_muligheter3 = new Muligheter();
                            gym_muligheter3.Id = 23;
                            gym_muligheter3.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 1";
                            gym_muligheter3.Semester = 7;
                            gym_muligheter3.Emnekode = "MGKP4100";
                            gym_muligheter3.MasterFagId = 5;
                            context.Add(gym_muligheter3);

                            //Muligheter masterFagId 5
                            var gym_muligheter4 = new Muligheter();
                            gym_muligheter4.Id = 24;
                            gym_muligheter4.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 2";
                            gym_muligheter4.Semester = 8;
                            gym_muligheter4.Emnekode = "MGKP4200";
                            gym_muligheter4.MasterFagId = 5;
                            context.Add(gym_muligheter4);

                            //Muligheter masterFagId 5
                            var gym_muligheter5 = new Muligheter();
                            gym_muligheter5.Id = 25;
                            gym_muligheter5.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 3";
                            gym_muligheter5.Semester = 9;
                            gym_muligheter5.Emnekode = "MGKP5100";
                            gym_muligheter5.MasterFagId = 5;
                            context.Add(gym_muligheter5);


                        //Masterfag 6 KH
                        var masterfag_KH = new MasterFag();
                        masterfag_KH.Id = 6;
                        masterfag_KH.Fagnavn = "KH";
                        masterfag_KH.KlasseId = 1;
                        context.Add(masterfag_KH);

                            //Muligheter masterFagId 6
                            var KH_muligheter1 = new Muligheter();
                            KH_muligheter1.Id = 26;
                            KH_muligheter1.Fagnavn = "Kunst og håndverk 1, emne 1";
                            KH_muligheter1.Semester = 4;
                            KH_muligheter1.Emnekode = "MGKH2100";
                            KH_muligheter1.MasterFagId = 6;
                            context.Add(KH_muligheter1);

                            //Muligheter masterFagId 6
                            var KH_muligheter2 = new Muligheter();
                            KH_muligheter2.Id = 27;
                            KH_muligheter2.Fagnavn = "Kunst og håndverk 2, emne 2";
                            KH_muligheter2.Semester = 5;
                            KH_muligheter2.Emnekode = "MGKH3100";
                            KH_muligheter2.MasterFagId = 6;
                            context.Add(KH_muligheter2);

                            //Muligheter masterFagId 6
                            var KH_muligheter3 = new Muligheter();
                            KH_muligheter3.Id = 28;
                            KH_muligheter3.Fagnavn = "Fagdidaktikk: kunst og håndverk";
                            KH_muligheter3.Semester = 7;
                            KH_muligheter3.Emnekode = "MFAGL4000";
                            KH_muligheter3.MasterFagId = 6;
                            context.Add(KH_muligheter3);

                            //Muligheter masterFagId 6
                            var KH_muligheter4 = new Muligheter();
                            KH_muligheter4.Id = 29;
                            KH_muligheter4.Fagnavn = "Praktisk estetisk prosjekt";
                            KH_muligheter4.Semester = 8;
                            KH_muligheter4.Emnekode = "MFAGL4200";
                            KH_muligheter4.MasterFagId = 6;
                            context.Add(KH_muligheter4);

                            //Muligheter masterFagId 6
                            var KH_muligheter5 = new Muligheter();
                            KH_muligheter5.Id = 30;
                            KH_muligheter5.Fagnavn = "Prosjektutvikling og undervisningspraksis";
                            KH_muligheter5.Semester = 9;
                            KH_muligheter5.Emnekode = "MFAGL5000";
                            KH_muligheter5.MasterFagId = 6;
                            context.Add(KH_muligheter5);


                        //Masterfag 7 Musikk
                        var masterfag_musikk = new MasterFag();
                        masterfag_musikk.Id = 7;
                        masterfag_musikk.Fagnavn = "Musikk";
                        masterfag_musikk.KlasseId = 1;
                        context.Add(masterfag_musikk);

                            //Muligheter masterFagId 7
                            var musikk_muligheter1 = new Muligheter();
                            musikk_muligheter1.Id = 31;
                            musikk_muligheter1.Fagnavn = "Musikk 1, emne 1";
                            musikk_muligheter1.Semester = 4;
                            musikk_muligheter1.Emnekode = "M1GMU2100";
                            musikk_muligheter1.MasterFagId = 7;
                            context.Add(musikk_muligheter1);

                            //Muligheter masterFagId 7
                            var musikk_muligheter2 = new Muligheter();
                            musikk_muligheter2.Id = 32;
                            musikk_muligheter2.Fagnavn = "Musikk 1, emne 2";
                            musikk_muligheter2.Semester = 4;
                            musikk_muligheter2.Emnekode = "M1GMU2200";
                            musikk_muligheter2.MasterFagId = 7;
                            context.Add(musikk_muligheter2);

                            //Muligheter masterFagId 7
                            var musikk_muligheter3 = new Muligheter();
                            musikk_muligheter3.Id = 33;
                            musikk_muligheter3.Fagnavn = "Musikk 2, emne 3";
                            musikk_muligheter3.Semester = 5;
                            musikk_muligheter3.Emnekode = "M1GMU3100";
                            musikk_muligheter3.MasterFagId = 7;
                            context.Add(musikk_muligheter3);

                            //Muligheter masterFagId 7
                            var musikk_muligheter4 = new Muligheter();
                            musikk_muligheter4.Id = 34;
                            musikk_muligheter4.Fagnavn = "Musikk og musikkdidaktikk 1";
                            musikk_muligheter4.Semester = 7;
                            musikk_muligheter4.Emnekode = "MGMU4100";
                            musikk_muligheter4.MasterFagId = 7;
                            context.Add(musikk_muligheter4);

                            //Muligheter masterFagId 7
                            var musikk_muligheter5 = new Muligheter();
                            musikk_muligheter5.Id = 35;
                            musikk_muligheter5.Fagnavn = "Musikk og musikkdidaktikk 2";
                            musikk_muligheter5.Semester = 8;
                            musikk_muligheter5.Emnekode = "MGMU4200";
                            musikk_muligheter5.MasterFagId = 7;
                            context.Add(musikk_muligheter5);

                            //Muligheter masterFagId 7
                            var musikk_muligheter6 = new Muligheter();
                            musikk_muligheter6.Id = 36;
                            musikk_muligheter6.Fagnavn = "Musikk og musikkdidaktikk 3";
                            musikk_muligheter6.Semester = 9;
                            musikk_muligheter6.Emnekode = "MGMU5100";
                            musikk_muligheter6.MasterFagId = 7;
                            context.Add(musikk_muligheter6);



                        //Masterfag 8 Naturfag
                        var masterfag_naturfag = new MasterFag();
                        masterfag_naturfag.Id = 8;
                        masterfag_naturfag.Fagnavn = "Naturfag";
                        masterfag_naturfag.KlasseId = 1;
                        context.Add(masterfag_naturfag);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter1 = new Muligheter();
                            naturfag_muligheter1.Id = 37;
                            naturfag_muligheter1.Fagnavn = "Naturfag 1, emne 1";
                            naturfag_muligheter1.Semester = 4;
                            naturfag_muligheter1.Emnekode = "M1GNA2100";
                            naturfag_muligheter1.MasterFagId = 4;
                            context.Add(naturfag_muligheter1);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter2 = new Muligheter();
                            naturfag_muligheter2.Id = 38;
                            naturfag_muligheter2.Fagnavn = "Naturfag 1, emne 2";
                            naturfag_muligheter2.Semester = 4;
                            naturfag_muligheter1.Emnekode = "M1GNA2200";
                            naturfag_muligheter2.MasterFagId = 8;
                            context.Add(naturfag_muligheter2);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter3 = new Muligheter();
                            naturfag_muligheter3.Id = 39;
                            naturfag_muligheter3.Fagnavn = "Naturfag 2, emne 3";
                            naturfag_muligheter3.Semester = 5;
                            naturfag_muligheter3.Emnekode = "MGNA4100";
                            naturfag_muligheter3.MasterFagId = 8;
                            context.Add(naturfag_muligheter3);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter4 = new Muligheter();
                            naturfag_muligheter4.Id = 40;
                            naturfag_muligheter4.Fagnavn = "Naturfag og naturfagdidaktikk 1";
                            naturfag_muligheter4.Semester = 7;
                            naturfag_muligheter4.Emnekode = "MGNA4200";
                            naturfag_muligheter4.MasterFagId = 8;
                            context.Add(naturfag_muligheter4);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter5 = new Muligheter();
                            naturfag_muligheter5.Id = 41;
                            naturfag_muligheter5.Fagnavn = "Naturfag og naturfagdidaktikk 2";
                            naturfag_muligheter5.Semester = 8;
                            naturfag_muligheter5.Emnekode = "MGNA5100";
                            naturfag_muligheter5.MasterFagId = 8;
                            context.Add(naturfag_muligheter5);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter6 = new Muligheter();
                            naturfag_muligheter6.Id = 42;
                            naturfag_muligheter6.Fagnavn = "Naturfag og naturfagdidaktikk 3";
                            naturfag_muligheter6.Semester = 9;
                            naturfag_muligheter6.Emnekode = "MGNA5100";
                            naturfag_muligheter6.MasterFagId = 8;
                            context.Add(naturfag_muligheter6);



                        //Masterfag 9 samfunnsfag
                        var masterfag_samfunnsfag = new MasterFag();
                        masterfag_samfunnsfag.Id = 9;
                        masterfag_samfunnsfag.Fagnavn = "Samfunnsfag";
                        masterfag_samfunnsfag.KlasseId = 1;
                        context.Add(masterfag_samfunnsfag);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter1 = new Muligheter();
                            samfunnsfag_muligheter1.Id = 43;
                            samfunnsfag_muligheter1.Fagnavn = "Samfunnsfag 1, emne 1";
                            samfunnsfag_muligheter1.Semester = 4;
                            samfunnsfag_muligheter1.Emnekode = "M1GSF2100";
                            samfunnsfag_muligheter1.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter1);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter2 = new Muligheter();
                            samfunnsfag_muligheter2.Id = 44;
                            samfunnsfag_muligheter2.Fagnavn = "Samfunnsfag 1, emne 2";
                            samfunnsfag_muligheter2.Semester = 4;
                            samfunnsfag_muligheter2.Emnekode = "M1GSF2200";
                            samfunnsfag_muligheter2.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter2);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter3 = new Muligheter();
                            samfunnsfag_muligheter3.Id = 45;
                            samfunnsfag_muligheter3.Fagnavn = "Samfunnsfag 2, emne 3";
                            samfunnsfag_muligheter3.Semester = 5;
                            samfunnsfag_muligheter3.Emnekode = "M1GSF3100";
                            samfunnsfag_muligheter3.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter3);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter4 = new Muligheter();
                            samfunnsfag_muligheter4.Id = 46;
                            samfunnsfag_muligheter4.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 1";
                            samfunnsfag_muligheter4.Semester = 7;
                            samfunnsfag_muligheter4.Emnekode = "MGSF4100";
                            samfunnsfag_muligheter4.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter4);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter5 = new Muligheter();
                            samfunnsfag_muligheter5.Id = 47;
                            samfunnsfag_muligheter5.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 2";
                            samfunnsfag_muligheter5.Semester = 8;
                            samfunnsfag_muligheter5.Emnekode = "MGSF4200";
                            samfunnsfag_muligheter5.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter5);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter6 = new Muligheter();
                            samfunnsfag_muligheter6.Id = 48;
                            samfunnsfag_muligheter6.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 3";
                            samfunnsfag_muligheter6.Semester = 9;
                            samfunnsfag_muligheter6.Emnekode = "MGSF5100";
                            samfunnsfag_muligheter6.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter6);



                        //Masterfag 10 Tegnspråk
                        var masterfag_tegnspråk = new MasterFag();
                        masterfag_tegnspråk.Id = 10;
                        masterfag_tegnspråk.Fagnavn = "Tegnspråk";
                        masterfag_tegnspråk.KlasseId = 1;
                        context.Add(masterfag_tegnspråk);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter1 = new Muligheter();
                            tegnspråk_muligheter1.Id = 49;
                            tegnspråk_muligheter1.Fagnavn = "Norsk tegnspråk 1";
                            tegnspråk_muligheter1.Semester = 5;
                            tegnspråk_muligheter1.Emnekode = "MGNT3100";
                            tegnspråk_muligheter1.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter1);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter2 = new Muligheter();
                            tegnspråk_muligheter2.Id = 50;
                            tegnspråk_muligheter2.Fagnavn = "Norsk tegnspråk 2";
                            tegnspråk_muligheter2.Semester = 6;
                            tegnspråk_muligheter1.Emnekode = "MGNT3200";
                            tegnspråk_muligheter2.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter2);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter3 = new Muligheter();
                            tegnspråk_muligheter3.Id = 51;
                            tegnspråk_muligheter3.Fagnavn = "";
                            tegnspråk_muligheter3.Semester = 7;
                            tegnspråk_muligheter3.Emnekode = "";
                            tegnspråk_muligheter3.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter3);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter4 = new Muligheter();
                            tegnspråk_muligheter4.Id = 52;
                            tegnspråk_muligheter4.Fagnavn = "";
                            tegnspråk_muligheter4.Semester = 8;
                            tegnspråk_muligheter4.Emnekode = "";
                            tegnspråk_muligheter4.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter4);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter5 = new Muligheter();
                            tegnspråk_muligheter5.Id = 53;
                            tegnspråk_muligheter5.Fagnavn = "";
                            tegnspråk_muligheter5.Semester = 9;
                            tegnspråk_muligheter5.Emnekode = "";
                            tegnspråk_muligheter5.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter5);



                        //Masterfag 11 Profesjonell pedagogikk
                        var masterfag_profped = new MasterFag();
                        masterfag_profped.Id = 11;
                        masterfag_profped.Fagnavn = "Profesjonsrettet pedagogikk";
                        masterfag_profped.KlasseId = 1;
                        context.Add(masterfag_profped);

                            //Muligheter masterFagId 11
                            var prof_ped1 = new Muligheter();
                            prof_ped1.Id = 54;
                            prof_ped1.Fagnavn = "Pedagogikk fordypning 1: Profesjonsrettet pedagogikk";
                            prof_ped1.Semester = 6;
                            prof_ped1.Emnekode = "MGPE3100";
                            prof_ped1.MasterFagId = 11;
                            context.Add(prof_ped1);

                            //Muligheter masterFagId 11
                            var prof_ped2 = new Muligheter();
                            prof_ped2.Id = 55;
                            prof_ped2.Fagnavn = "Pedagogikk fordypning 2: Profesjonsrettet pedagogikk";
                            prof_ped2.Semester = 9;
                            prof_ped2.Emnekode = "MGPE5100";
                            prof_ped2.MasterFagId = 11;
                            context.Add(prof_ped2);



                        //Masterfag 12 digital pedagogikk
                        var masterfag_digped = new MasterFag();
                        masterfag_digped.Id = 12;
                        masterfag_digped.Fagnavn = "Profesjonsrettet pedagogikk";
                        masterfag_digped.KlasseId = 1;
                        context.Add(masterfag_digped);

                            //Muligheter masterFagId 12
                            var dig_ped1 = new Muligheter();
                            dig_ped1.Id = 56;
                            dig_ped1.Fagnavn = "Pedagogikk fordypning 1: Digitalt støttet pedagogikk";
                            dig_ped1.Semester = 6;
                            dig_ped1.Emnekode = "MGPE3200";
                            dig_ped1.MasterFagId = 12;
                            context.Add(dig_ped1);

                            //Muligheter masterFagId 12
                            var dig_ped2 = new Muligheter();
                            dig_ped2.Id = 57;
                            dig_ped2.Fagnavn = "Pedagogikk fordypning 2: Digitalt støttet pedagogikk";
                            dig_ped2.Semester = 9;
                            dig_ped2.Emnekode = "MGPE5200";
                            dig_ped2.MasterFagId = 12;
                            context.Add(dig_ped2);



                        //Masterfag 13 Profesjonell pedagogikk
                        var masterfag_spesped = new MasterFag();
                        masterfag_spesped.Id = 13;
                        masterfag_spesped.Fagnavn = "Profesjonsrettet pedagogikk";
                        masterfag_spesped.KlasseId = 1;
                        context.Add(masterfag_spesped);

                            //Muligheter masterFagId 12
                            var spes_ped1 = new Muligheter();
                            spes_ped1.Id = 58;
                            spes_ped1.Fagnavn = "Pedagogikk fordypning 1: Spesialpedagogikk";
                            spes_ped1.Semester = 6;
                            spes_ped1.Emnekode = "MGPE3300";
                            spes_ped1.MasterFagId = 13;
                            context.Add(spes_ped1);

                            //Muligheter masterFagId 12
                            var spes_ped2 = new Muligheter();
                            spes_ped2.Id = 59;
                            spes_ped2.Fagnavn = "Pedagogikk fordypning 2: Spesialpedagogikk";
                            spes_ped2.Semester = 9;
                            spes_ped2.Emnekode = "MGPE5300";
                            spes_ped2.MasterFagId = 13;
                            context.Add(spes_ped2);











                /*******************************/


                ////Klassetrinn 5-10
                //var klasse2 = new Klasser();
                //klasse2.Id = 2;
                //klasse2.Klassetrinn = "5-10";
                //context.Add(klasse2);


                //var oblig4 = new ObligFags();
                //oblig4.Id = 7;
                //oblig4.Fagnavn = "Matte2";
                //oblig4.KlasseId = 2;
                //context.Add(oblig4);

                //var oblig5 = new ObligFags();
                //oblig5.Id = 8;
                //oblig5.Fagnavn = "Engelsk2";
                //oblig5.KlasseId = 2;
                //context.Add(oblig5);

                //var oblig6 = new ObligFags();
                //oblig6.Id = 9;
                //oblig6.Fagnavn = "Norsk2";
                //oblig6.KlasseId = 2;
                //context.Add(oblig6);


                ////Masterfag 4


                ////muligheter masterFagId 4
                //var muligheter10 = new Muligheter();
                //muligheter10.Id = 10;
                //muligheter10.Fagnavn = "Matematikk 2, emne 4";
                //muligheter10.Semester = 5;
                //muligheter10.MasterFagId = 4;
                //context.Add(muligheter10);

                ////muligheter masterFagId 4
                //var muligheter11 = new Muligheter();
                //muligheter11.Id = 11;
                //muligheter11.Fagnavn = "Matte og matematikkdidaktikk 1";
                //muligheter11.Semester = 7;
                //muligheter11.MasterFagId = 4;
                //context.Add(muligheter11);

                ////muligheter masterFagId 4
                //var muligheter12 = new Muligheter();
                //muligheter12.Id = 12;
                //muligheter12.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                //muligheter12.Semester = 8;
                //muligheter12.MasterFagId = 4;
                //context.Add(muligheter12);

                //var masterfag5 = new MasterFag();
                //masterfag5.Id = 5;
                //masterfag5.Fagnavn = "Naturfag";
                //masterfag5.KlasseId = 2;
                //context.Add(masterfag5);

                //var masterfag6 = new MasterFag();
                //masterfag6.Id = 6;
                //masterfag6.Fagnavn = "Gym";
                //masterfag6.KlasseId = 2;
                //context.Add(masterfag6);








                ///*
                //                 // Klasser/klassetrinn
                //var klasse1 = new Klasser();
                //klasse1.Id = 1;
                //klasse1.Klassetrinn = "1-7";
                //context.Add(klasse1);

                //var klasse2 = new Klasser();
                //klasse2.Id = 2;
                //klasse2.Klassetrinn = "5-10";
                //context.Add(klasse2);


                ////Oblig fags
                //var oblig1 = new ObligFags();
                //oblig1.Id = 1;
                //oblig1.Fagnavn = "Matte";
                //oblig1.KlasseId = 1;
                //context.Add(oblig1);

                //var oblig2 = new ObligFags();
                //oblig2.Id = 2;
                //oblig2.Fagnavn = "Engelsk";
                //oblig2.KlasseId = 1;
                //context.Add(oblig2);

                //var oblig3 = new ObligFags();
                //oblig3.Id = 3;
                //oblig3.Fagnavn = "Norsk";
                //oblig3.KlasseId = 1;
                //context.Add(oblig3);

                //var oblig4 = new ObligFags();
                //oblig4.Id = 4;
                //oblig4.Fagnavn = "Matte";
                //oblig4.KlasseId = 2;
                //context.Add(oblig4);

                //var oblig5 = new ObligFags();
                //oblig5.Id = 5;
                //oblig5.Fagnavn = "Engelsk";
                //oblig5.KlasseId = 2;
                //context.Add(oblig5);

                //var oblig6 = new ObligFags();
                //oblig6.Id = 6;
                //oblig6.Fagnavn = "Norsk";
                //oblig6.KlasseId = 2;
                //context.Add(oblig6);


                ////Masterfag

                //var masterfag1 = new MasterFag();
                //masterfag1.Id = 1;
                //masterfag1.Fagnavn = "Matte";
                //masterfag1.KlasseId = 1;
                //context.Add(masterfag1);

                //var masterfag2 = new MasterFag();
                //masterfag2.Id = 2;
                //masterfag2.Fagnavn = "Engelsk";
                //masterfag2.KlasseId = 1;
                //context.Add(masterfag2);

                //var masterfag3 = new MasterFag();
                //masterfag3.Id = 3;
                //masterfag3.Fagnavn = "Pedagogikk";
                //masterfag3.KlasseId = 1;
                //context.Add(masterfag3);

                //var masterfag4 = new MasterFag();
                //masterfag4.Id = 4;
                //masterfag4.Fagnavn = "Matte";
                //masterfag4.KlasseId = 2;
                //context.Add(masterfag4);

                //var masterfag5 = new MasterFag();
                //masterfag5.Id = 5;
                //masterfag5.Fagnavn = "Naturfag";
                //masterfag5.KlasseId = 2;
                //context.Add(masterfag5);

                //var masterfag6 = new MasterFag();
                //masterfag6.Id = 6;
                //masterfag6.Fagnavn = "Gym";
                //masterfag6.KlasseId = 2;
                //context.Add(masterfag6);

                ////muligheter 1-7 trinn
                //var muligheter1 = new Muligheter();
                //muligheter1.Id = 1;
                //muligheter1.Fagnavn = "Krle";
                //muligheter1.MasterFagId = 1;
                //context.Add(muligheter1);

                //var muligheter2 = new Muligheter();
                //muligheter2.Id = 2;
                //muligheter2.Fagnavn = "Gym";
                //muligheter2.MasterFagId = 1;
                //context.Add(muligheter2);

                //var muligheter3 = new Muligheter();
                //muligheter3.Id = 3;
                //muligheter3.Fagnavn = "Naturfag";
                //muligheter3.MasterFagId = 1;
                //context.Add(muligheter3);

                ////Muligheter 5-10 trinn
                //var muligheter4 = new Muligheter();
                //muligheter4.Id = 4;
                //muligheter4.Fagnavn = "Krle";
                //muligheter4.MasterFagId = 2;
                //context.Add(muligheter4);

                //var muligheter5 = new Muligheter();
                //muligheter5.Id = 5;
                //muligheter5.Fagnavn = "Krle";
                //muligheter5.MasterFagId = 2;
                //context.Add(muligheter5);

                //var muligheter6 = new Muligheter();
                //muligheter6.Id = 6;
                //muligheter6.Fagnavn = "Naturfag";
                //muligheter6.MasterFagId = 2;
                //context.Add(muligheter6);
                // */


                context.SaveChanges();
            }
        }
    }
}

