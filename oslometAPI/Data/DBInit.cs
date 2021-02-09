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
                        oblig_matte1.Studiepoeng = 10;
                        oblig_matte1.KlasseId = 1;
                        context.Add(oblig_matte1);

                        var oblig_matte2 = new ObligFags();
                        oblig_matte2.Id = 2;
                        oblig_matte2.Fagnavn = "Matematikk 1, emne 2";
                        oblig_matte2.Semester = 2;
                        oblig_matte2.Emnekode = "M1GMT1200";
                        oblig_matte2.Studiepoeng = 10;
                        oblig_matte2.KlasseId = 1;
                        context.Add(oblig_matte2);

                        var oblig_matte3 = new ObligFags();
                        oblig_matte3.Id = 3;
                        oblig_matte3.Fagnavn = "Matematikk 1, emne 3";
                        oblig_matte3.Semester = 3;
                        oblig_matte3.Emnekode = "M1GMT2100";
                        oblig_matte3.Studiepoeng = 10;
                        oblig_matte3.KlasseId = 1;
                        context.Add(oblig_matte3);


                        //obligatorisk norskfag
                        var oblig_norsk1 = new ObligFags();
                        oblig_norsk1.Id = 4;
                        oblig_norsk1.Fagnavn = "Norsk 1, emne 1";
                        oblig_norsk1.Semester = 1;
                        oblig_norsk1.Emnekode = "M1GNO1100";
                        oblig_norsk1.Studiepoeng = 10;
                        oblig_norsk1.KlasseId = 1;
                        context.Add(oblig_norsk1);

                        var oblig_norsk2 = new ObligFags();
                        oblig_norsk2.Id = 5;
                        oblig_norsk2.Fagnavn = "Norsk 1, emne 2";
                        oblig_norsk2.Semester = 2;
                        oblig_norsk2.Emnekode = "M1GNO1200";
                        oblig_norsk2.Studiepoeng = 10;
                        oblig_norsk2.KlasseId = 1;
                        context.Add(oblig_norsk2);

                        var oblig_norsk3 = new ObligFags();
                        oblig_norsk3.Id = 6;
                        oblig_norsk3.Fagnavn = "Norsk 1, emne 3";
                        oblig_norsk3.Semester = 3;
                        oblig_norsk3.Emnekode = "M1GNO2100";
                        oblig_norsk3.Studiepoeng = 10;
                        oblig_norsk3.KlasseId = 1;
                        context.Add(oblig_norsk3);



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
                            norsk_muligheter1.Studiepoeng = 30;
                            norsk_muligheter1.MasterFagId = 1;
                            context.Add(norsk_muligheter1);

                            //muligheter masterFagId 1
                            var norsk_muligheter2 = new Muligheter();
                            norsk_muligheter2.Id = 2;
                            norsk_muligheter2.Fagnavn = "Norsk og norskdidaktikk 1";
                            norsk_muligheter2.Semester = 7;
                            norsk_muligheter2.Emnekode = "MGNO4100";
                            norsk_muligheter2.Studiepoeng = 15;
                            norsk_muligheter2.MasterFagId = 1;
                            context.Add(norsk_muligheter2);

                            //muligheter masterFagId 1
                            var norsk_muligheter3 = new Muligheter();
                            norsk_muligheter3.Id = 3;
                            norsk_muligheter3.Fagnavn = "Norsk og norskdidaktikk 2";
                            norsk_muligheter3.Semester = 8;
                            norsk_muligheter3.Emnekode = "MGNO4200";
                            norsk_muligheter3.Studiepoeng = 15;
                            norsk_muligheter3.MasterFagId = 1;
                            context.Add(norsk_muligheter3);

                            //muligheter masterFagId 1
                            var norsk_muligheter4 = new Muligheter();
                            norsk_muligheter4.Id = 4;
                            norsk_muligheter4.Fagnavn = "Norsk og norskdidaktikk 3";
                            norsk_muligheter4.Semester = 9;
                            norsk_muligheter4.Emnekode = "MGNO5100";
                            norsk_muligheter4.Studiepoeng = 15;
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
                            matte_muligheter1.Studiepoeng = 30;
                            matte_muligheter1.MasterFagId = 2;
                            context.Add(matte_muligheter1);

                            //Muligheter masterFagId 2
                            var matte_muligheter2 = new Muligheter();
                            matte_muligheter2.Id = 6;
                            matte_muligheter2.Fagnavn = "Matematikk og matematikkdidaktikk 1";
                            matte_muligheter2.Semester = 7;
                            matte_muligheter2.Emnekode = "MGMT4100";
                            matte_muligheter2.Studiepoeng = 15;
                            matte_muligheter2.MasterFagId = 2;
                            context.Add(matte_muligheter2);

                            //Muligheter masterFagId 2
                            var matte_muligheter3 = new Muligheter();
                            matte_muligheter3.Id = 7;
                            matte_muligheter3.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                            matte_muligheter3.Semester = 8;
                            matte_muligheter3.Emnekode = "MGMT4200";
                            matte_muligheter3.Studiepoeng = 15;
                            matte_muligheter3.MasterFagId = 2;
                            context.Add(matte_muligheter3);

                            //Muligheter masterFagId 2
                            var matte_muligheter4 = new Muligheter();
                            matte_muligheter4.Id = 8;
                            matte_muligheter4.Fagnavn = "Matematikk og matematikkdidaktikk 3";
                            matte_muligheter4.Semester = 9;
                            matte_muligheter4.Emnekode = "MGMT5100";
                            matte_muligheter4.Studiepoeng = 15;
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
                            engelsk_muligheter1.Studiepoeng = 15;
                            engelsk_muligheter1.MasterFagId = 3;
                            context.Add(engelsk_muligheter1);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter2 = new Muligheter();
                            engelsk_muligheter2.Id = 10;
                            engelsk_muligheter2.Fagnavn = "Engelsk 1, emne 2";
                            engelsk_muligheter2.Semester = 4;
                            engelsk_muligheter2.Emnekode = "M1GEN2200";
                            engelsk_muligheter2.Studiepoeng = 15;
                            engelsk_muligheter2.MasterFagId = 3;
                            context.Add(engelsk_muligheter2);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter3 = new Muligheter();
                            engelsk_muligheter3.Id = 11;
                            engelsk_muligheter3.Fagnavn = "Engelsk 2, emne 3";
                            engelsk_muligheter3.Semester = 5;
                            engelsk_muligheter3.Emnekode = "M1GEN3100";
                            engelsk_muligheter3.Studiepoeng = 30;
                            engelsk_muligheter3.MasterFagId = 3;
                            context.Add(engelsk_muligheter3);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter4 = new Muligheter();
                            engelsk_muligheter4.Id = 12;
                            engelsk_muligheter4.Fagnavn = "Engelsk og engelskdidaktikk 1";
                            engelsk_muligheter4.Semester = 7;
                            engelsk_muligheter4.Emnekode = "MGEN4100";
                            engelsk_muligheter4.Studiepoeng = 15;
                            engelsk_muligheter4.MasterFagId = 3;
                            context.Add(engelsk_muligheter4);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter5 = new Muligheter();
                            engelsk_muligheter5.Id = 13;
                            engelsk_muligheter5.Fagnavn = "Engelsk og engelskdidaktikk 2";
                            engelsk_muligheter5.Semester = 8;
                            engelsk_muligheter5.Emnekode = "MGEN4200";
                            engelsk_muligheter5.Studiepoeng = 15;
                            engelsk_muligheter5.MasterFagId = 3;
                            context.Add(engelsk_muligheter5);

                            //Muligheter masterFagId 3
                            var engelsk_muligheter6 = new Muligheter();
                            engelsk_muligheter6.Id = 14;
                            engelsk_muligheter6.Fagnavn = "Engelsk og engelskdidaktikk 3";
                            engelsk_muligheter6.Semester = 9;
                            engelsk_muligheter6.Emnekode = "MGEN5100";
                            engelsk_muligheter6.Studiepoeng = 15;
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
                            KRLE_muligheter1.Studiepoeng = 15;
                            KRLE_muligheter1.MasterFagId = 4;
                            context.Add(KRLE_muligheter1);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter2 = new Muligheter();
                            KRLE_muligheter2.Id = 16;
                            KRLE_muligheter2.Fagnavn = "RLE 1, emne 2";
                            KRLE_muligheter2.Semester = 4;
                            KRLE_muligheter2.Emnekode = "M1GRL2200";
                            KRLE_muligheter2.Studiepoeng = 15;
                            KRLE_muligheter2.MasterFagId = 4;
                            context.Add(KRLE_muligheter2);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter3 = new Muligheter();
                            KRLE_muligheter3.Id = 17;
                            KRLE_muligheter3.Fagnavn = "RLE 2, emne 3";
                            KRLE_muligheter3.Semester = 5;
                            KRLE_muligheter3.Emnekode = "M1GRL3100";
                            KRLE_muligheter3.Studiepoeng = 30;
                            KRLE_muligheter3.MasterFagId = 4;
                            context.Add(KRLE_muligheter3);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter4 = new Muligheter();
                            KRLE_muligheter4.Id = 18;
                            KRLE_muligheter4.Fagnavn = "RLE og RLE-didaktikk 1";
                            KRLE_muligheter4.Semester = 7;
                            KRLE_muligheter4.Emnekode = "MGRL4100";
                            KRLE_muligheter4.Studiepoeng = 15;
                            KRLE_muligheter4.MasterFagId = 4;
                            context.Add(KRLE_muligheter4);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter5 = new Muligheter();
                            KRLE_muligheter5.Id = 19;
                            KRLE_muligheter5.Fagnavn = "RLE og RLE-didaktikk 2";
                            KRLE_muligheter5.Semester = 8;
                            KRLE_muligheter5.Emnekode = "MGRL4200";
                            KRLE_muligheter5.Studiepoeng = 15;
                            KRLE_muligheter5.MasterFagId = 4;
                            context.Add(KRLE_muligheter5);

                            //Muligheter masterFagId 4
                            var KRLE_muligheter6 = new Muligheter();
                            KRLE_muligheter6.Id = 20;
                            KRLE_muligheter6.Fagnavn = "RLE og RLE-didaktikk 3";
                            KRLE_muligheter6.Semester = 9;
                            KRLE_muligheter6.Emnekode = "MGRL5100";
                            KRLE_muligheter6.Studiepoeng = 15;
                            KRLE_muligheter6.MasterFagId = 4;
                            context.Add(KRLE_muligheter6);



                        //Masterfag 5 kroppsøving
                        var masterfag_gym = new MasterFag();
                        masterfag_gym.Id = 5;
                        masterfag_gym.Fagnavn = "Kroppsøving";
                        masterfag_gym.KlasseId = 1;
                        context.Add(masterfag_gym);

                            //Muligheter masterFagId 5
                            var gym_muligheter1 = new Muligheter();
                            gym_muligheter1.Id = 21;
                            gym_muligheter1.Fagnavn = "Kroppsøving 1, emne 1";
                            gym_muligheter1.Semester = 4;
                            gym_muligheter1.Emnekode = "M1GKP2100";
                            gym_muligheter1.Studiepoeng = 30;
                            gym_muligheter1.MasterFagId = 5;
                            context.Add(gym_muligheter1);

                            //Muligheter masterFagId 5
                            var gym_muligheter2 = new Muligheter();
                            gym_muligheter2.Id = 22;
                            gym_muligheter2.Fagnavn = "Kroppsøving 2, emne 2";
                            gym_muligheter2.Semester = 5;
                            gym_muligheter2.Emnekode = "M1GKP3100";
                            gym_muligheter2.Studiepoeng = 30;
                            gym_muligheter2.MasterFagId = 5;
                            context.Add(gym_muligheter2);

                            //Muligheter masterFagId 5
                            var gym_muligheter3 = new Muligheter();
                            gym_muligheter3.Id = 23;
                            gym_muligheter3.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 1";
                            gym_muligheter3.Semester = 7;
                            gym_muligheter3.Emnekode = "MGKP4100";
                            gym_muligheter3.Studiepoeng = 15;
                            gym_muligheter3.MasterFagId = 5;
                            context.Add(gym_muligheter3);

                            //Muligheter masterFagId 5
                            var gym_muligheter4 = new Muligheter();
                            gym_muligheter4.Id = 24;
                            gym_muligheter4.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 2";
                            gym_muligheter4.Semester = 8;
                            gym_muligheter4.Emnekode = "MGKP4200";
                            gym_muligheter4.Studiepoeng = 15;
                            gym_muligheter4.MasterFagId = 5;
                            context.Add(gym_muligheter4);

                            //Muligheter masterFagId 5
                            var gym_muligheter5 = new Muligheter();
                            gym_muligheter5.Id = 25;
                            gym_muligheter5.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 3";
                            gym_muligheter5.Semester = 9;
                            gym_muligheter5.Emnekode = "MGKP5100";
                            gym_muligheter5.Studiepoeng = 15;
                            gym_muligheter5.MasterFagId = 5;
                            context.Add(gym_muligheter5);


                        //Masterfag 6 KH
                        var masterfag_KH = new MasterFag();
                        masterfag_KH.Id = 6;
                        masterfag_KH.Fagnavn = "Kunst og håndverk";
                        masterfag_KH.KlasseId = 1;
                        context.Add(masterfag_KH);

                            //Muligheter masterFagId 6
                            var KH_muligheter1 = new Muligheter();
                            KH_muligheter1.Id = 26;
                            KH_muligheter1.Fagnavn = "Kunst og håndverk 1, emne 1";
                            KH_muligheter1.Semester = 4;
                            KH_muligheter1.Emnekode = "MGKH2100";
                            KH_muligheter1.Studiepoeng = 30;
                            KH_muligheter1.MasterFagId = 6;
                            context.Add(KH_muligheter1);

                            //Muligheter masterFagId 6
                            var KH_muligheter2 = new Muligheter();
                            KH_muligheter2.Id = 27;
                            KH_muligheter2.Fagnavn = "Kunst og håndverk 2, emne 2";
                            KH_muligheter2.Semester = 5;
                            KH_muligheter2.Emnekode = "MGKH3100";
                            KH_muligheter2.Studiepoeng = 30;
                            KH_muligheter2.MasterFagId = 6;
                            context.Add(KH_muligheter2);

                            //Muligheter masterFagId 6
                            var KH_muligheter3 = new Muligheter();
                            KH_muligheter3.Id = 28;
                            KH_muligheter3.Fagnavn = "Fagdidaktikk: kunst og håndverk";
                            KH_muligheter3.Semester = 7;
                            KH_muligheter3.Emnekode = "MFAGL4000";
                            KH_muligheter3.Studiepoeng = 15;
                            KH_muligheter3.MasterFagId = 6;
                            context.Add(KH_muligheter3);

                            //Muligheter masterFagId 6
                            var KH_muligheter4 = new Muligheter();
                            KH_muligheter4.Id = 29;
                            KH_muligheter4.Fagnavn = "Praktisk estetisk prosjekt";
                            KH_muligheter4.Semester = 8;
                            KH_muligheter4.Emnekode = "MFAGL4200";
                            KH_muligheter4.Studiepoeng = 15;
                            KH_muligheter4.MasterFagId = 6;
                            context.Add(KH_muligheter4);

                            //Muligheter masterFagId 6
                            var KH_muligheter5 = new Muligheter();
                            KH_muligheter5.Id = 30;
                            KH_muligheter5.Fagnavn = "Prosjektutvikling og undervisningspraksis";
                            KH_muligheter5.Semester = 9;
                            KH_muligheter5.Emnekode = "MFAGL5000";
                            KH_muligheter5.Studiepoeng = 15;
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
                            musikk_muligheter1.Studiepoeng = 15;
                            musikk_muligheter1.MasterFagId = 7;
                            context.Add(musikk_muligheter1);

                            //Muligheter masterFagId 7
                            var musikk_muligheter2 = new Muligheter();
                            musikk_muligheter2.Id = 32;
                            musikk_muligheter2.Fagnavn = "Musikk 1, emne 2";
                            musikk_muligheter2.Semester = 4;
                            musikk_muligheter2.Emnekode = "M1GMU2200";
                            musikk_muligheter2.Studiepoeng = 15;
                            musikk_muligheter2.MasterFagId = 7;
                            context.Add(musikk_muligheter2);

                            //Muligheter masterFagId 7
                            var musikk_muligheter3 = new Muligheter();
                            musikk_muligheter3.Id = 33;
                            musikk_muligheter3.Fagnavn = "Musikk 2, emne 3";
                            musikk_muligheter3.Semester = 5;
                            musikk_muligheter3.Emnekode = "M1GMU3100";
                            musikk_muligheter3.Studiepoeng = 30;
                            musikk_muligheter3.MasterFagId = 7;
                            context.Add(musikk_muligheter3);

                            //Muligheter masterFagId 7
                            var musikk_muligheter4 = new Muligheter();
                            musikk_muligheter4.Id = 34;
                            musikk_muligheter4.Fagnavn = "Musikk og musikkdidaktikk 1";
                            musikk_muligheter4.Semester = 7;
                            musikk_muligheter4.Emnekode = "MGMU4100";
                            musikk_muligheter4.Studiepoeng = 15;
                            musikk_muligheter4.MasterFagId = 7;
                            context.Add(musikk_muligheter4);

                            //Muligheter masterFagId 7
                            var musikk_muligheter5 = new Muligheter();
                            musikk_muligheter5.Id = 35;
                            musikk_muligheter5.Fagnavn = "Musikk og musikkdidaktikk 2";
                            musikk_muligheter5.Semester = 8;
                            musikk_muligheter5.Emnekode = "MGMU4200";
                            musikk_muligheter5.Studiepoeng = 15;
                            musikk_muligheter5.MasterFagId = 7;
                            context.Add(musikk_muligheter5);

                            //Muligheter masterFagId 7
                            var musikk_muligheter6 = new Muligheter();
                            musikk_muligheter6.Id = 36;
                            musikk_muligheter6.Fagnavn = "Musikk og musikkdidaktikk 3";
                            musikk_muligheter6.Semester = 9;
                            musikk_muligheter6.Emnekode = "MGMU5100";
                            musikk_muligheter6.Studiepoeng = 15;
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
                            naturfag_muligheter1.Studiepoeng = 15;
                            naturfag_muligheter1.MasterFagId = 8;
                            context.Add(naturfag_muligheter1);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter2 = new Muligheter();
                            naturfag_muligheter2.Id = 38;
                            naturfag_muligheter2.Fagnavn = "Naturfag 1, emne 2";
                            naturfag_muligheter2.Semester = 4;
                            naturfag_muligheter2.Emnekode = "M1GNA2200";
                            naturfag_muligheter2.Studiepoeng = 15;
                            naturfag_muligheter2.MasterFagId = 8;
                            context.Add(naturfag_muligheter2);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter3 = new Muligheter();
                            naturfag_muligheter3.Id = 39;
                            naturfag_muligheter3.Fagnavn = "Naturfag 2, emne 3";
                            naturfag_muligheter3.Semester = 5;
                            naturfag_muligheter3.Emnekode = "M1GNA3100";
                            naturfag_muligheter3.Studiepoeng = 30;
                            naturfag_muligheter3.MasterFagId = 8;
                            context.Add(naturfag_muligheter3);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter4 = new Muligheter();
                            naturfag_muligheter4.Id = 40;
                            naturfag_muligheter4.Fagnavn = "Naturfag og naturfagdidaktikk 1";
                            naturfag_muligheter4.Semester = 7;
                            naturfag_muligheter4.Emnekode = "MGNA4100";
                            naturfag_muligheter4.Studiepoeng = 15;
                            naturfag_muligheter4.MasterFagId = 8;
                            context.Add(naturfag_muligheter4);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter5 = new Muligheter();
                            naturfag_muligheter5.Id = 41;
                            naturfag_muligheter5.Fagnavn = "Naturfag og naturfagdidaktikk 2";
                            naturfag_muligheter5.Semester = 8;
                            naturfag_muligheter5.Emnekode = "MGNA4200";
                            naturfag_muligheter5.Studiepoeng = 15;
                            naturfag_muligheter5.MasterFagId = 8;
                            context.Add(naturfag_muligheter5);

                            //Muligheter masterFagId 8
                            var naturfag_muligheter6 = new Muligheter();
                            naturfag_muligheter6.Id = 42;
                            naturfag_muligheter6.Fagnavn = "Naturfag og naturfagdidaktikk 3";
                            naturfag_muligheter6.Semester = 9;
                            naturfag_muligheter6.Emnekode = "MGNA5100";
                            naturfag_muligheter6.Studiepoeng = 15;
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
                            samfunnsfag_muligheter1.Studiepoeng = 15;
                            samfunnsfag_muligheter1.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter1);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter2 = new Muligheter();
                            samfunnsfag_muligheter2.Id = 44;
                            samfunnsfag_muligheter2.Fagnavn = "Samfunnsfag 1, emne 2";
                            samfunnsfag_muligheter2.Semester = 4;
                            samfunnsfag_muligheter2.Emnekode = "M1GSF2200";
                            samfunnsfag_muligheter2.Studiepoeng = 15;
                            samfunnsfag_muligheter2.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter2);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter3 = new Muligheter();
                            samfunnsfag_muligheter3.Id = 45;
                            samfunnsfag_muligheter3.Fagnavn = "Samfunnsfag 2, emne 3";
                            samfunnsfag_muligheter3.Semester = 5;
                            samfunnsfag_muligheter3.Emnekode = "M1GSF3100";
                            samfunnsfag_muligheter3.Studiepoeng = 30;
                            samfunnsfag_muligheter3.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter3);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter4 = new Muligheter();
                            samfunnsfag_muligheter4.Id = 46;
                            samfunnsfag_muligheter4.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 1";
                            samfunnsfag_muligheter4.Semester = 7;
                            samfunnsfag_muligheter4.Emnekode = "MGSF4100";
                            samfunnsfag_muligheter4.Studiepoeng = 15;
                            samfunnsfag_muligheter4.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter4);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter5 = new Muligheter();
                            samfunnsfag_muligheter5.Id = 47;
                            samfunnsfag_muligheter5.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 2";
                            samfunnsfag_muligheter5.Semester = 8;
                            samfunnsfag_muligheter5.Emnekode = "MGSF4200";
                            samfunnsfag_muligheter5.Studiepoeng = 15;
                            samfunnsfag_muligheter5.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter5);

                            //Muligheter masterFagId 9
                            var samfunnsfag_muligheter6 = new Muligheter();
                            samfunnsfag_muligheter6.Id = 48;
                            samfunnsfag_muligheter6.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 3";
                            samfunnsfag_muligheter6.Semester = 9;
                            samfunnsfag_muligheter6.Emnekode = "MGSF5100";
                            samfunnsfag_muligheter6.Studiepoeng = 15;
                            samfunnsfag_muligheter6.MasterFagId = 9;
                            context.Add(samfunnsfag_muligheter6);



                        //Masterfag 10 Tegnspråk
                        var masterfag_tegnspråk = new MasterFag();
                        masterfag_tegnspråk.Id = 10;
                        masterfag_tegnspråk.Fagnavn = "Tegnspråk";
                        masterfag_tegnspråk.KlasseId = 10;
                        context.Add(masterfag_tegnspråk);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter1 = new Muligheter();
                            tegnspråk_muligheter1.Id = 49;
                            tegnspråk_muligheter1.Fagnavn = "Norsk tegnspråk 1";
                            tegnspråk_muligheter1.Semester = 5;
                            tegnspråk_muligheter1.Emnekode = "MGNT3100";
                            tegnspråk_muligheter1.Studiepoeng = 30;
                            tegnspråk_muligheter1.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter1);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter2 = new Muligheter();
                            tegnspråk_muligheter2.Id = 50;
                            tegnspråk_muligheter2.Fagnavn = "Norsk tegnspråk 2";
                            tegnspråk_muligheter2.Semester = 6;
                            tegnspråk_muligheter2.Emnekode = "MGNT3200";
                            tegnspråk_muligheter2.Studiepoeng = 30;
                            tegnspråk_muligheter2.MasterFagId = 10;
                tegnspråk_muligheter2.KlasseId = 1;
                            context.Add(tegnspråk_muligheter2);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter3 = new Muligheter();
                            tegnspråk_muligheter3.Id = 51;
                            tegnspråk_muligheter3.Fagnavn = "";
                            tegnspråk_muligheter3.Semester = 7;
                            tegnspråk_muligheter3.Emnekode = "";
                            tegnspråk_muligheter3.Studiepoeng = 0;
                            tegnspråk_muligheter3.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter3);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter4 = new Muligheter();
                            tegnspråk_muligheter4.Id = 52;
                            tegnspråk_muligheter4.Fagnavn = "";
                            tegnspråk_muligheter4.Semester = 8;
                            tegnspråk_muligheter4.Emnekode = "";
                            tegnspråk_muligheter4.Studiepoeng = 0;
                            tegnspråk_muligheter4.MasterFagId = 10;
                            context.Add(tegnspråk_muligheter4);

                            //Muligheter masterFagId 10
                            var tegnspråk_muligheter5 = new Muligheter();
                            tegnspråk_muligheter5.Id = 53;
                            tegnspråk_muligheter5.Fagnavn = "";
                            tegnspråk_muligheter5.Semester = 9;
                            tegnspråk_muligheter5.Emnekode = "";
                            tegnspråk_muligheter5.Studiepoeng = 0;
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
                            prof_ped1.Studiepoeng = 30;
                            prof_ped1.MasterFagId = 11;
                            context.Add(prof_ped1);

                            //Muligheter masterFagId 11
                            var prof_ped2 = new Muligheter();
                            prof_ped2.Id = 55;
                            prof_ped2.Fagnavn = "Pedagogikk fordypning 2: Profesjonsrettet pedagogikk";
                            prof_ped2.Semester = 9;
                            prof_ped2.Emnekode = "MGPE5100";
                            prof_ped2.Studiepoeng = 30;
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
                            dig_ped1.Studiepoeng = 30;
                dig_ped1.KlasseId = 1;
                            dig_ped1.MasterFagId = 12;
                            context.Add(dig_ped1);

                            //Muligheter masterFagId 12
                            var dig_ped2 = new Muligheter();
                            dig_ped2.Id = 57;
                            dig_ped2.Fagnavn = "Pedagogikk fordypning 2: Digitalt støttet pedagogikk";
                            dig_ped2.Semester = 9;
                            dig_ped2.Emnekode = "MGPE5200";
                            dig_ped2.Studiepoeng = 30;
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
                            spes_ped1.Studiepoeng = 30;
                spes_ped1.KlasseId = 1;
                            spes_ped1.MasterFagId = 13;
                            context.Add(spes_ped1);

                            //Muligheter masterFagId 12
                            var spes_ped2 = new Muligheter();
                            spes_ped2.Id = 59;
                            spes_ped2.Fagnavn = "Pedagogikk fordypning 2: Spesialpedagogikk";
                            spes_ped2.Semester = 9;
                            spes_ped2.Emnekode = "MGPE5300";
                            spes_ped2.Studiepoeng = 30;
                            spes_ped2.MasterFagId = 13;
                            context.Add(spes_ped2);
                        










                /*******************************/


                //Klassetrinn 5-10
                var klasse2 = new Klasser();
                klasse2.Id = 2;
                klasse2.Klassetrinn = "5-10";
                context.Add(klasse2);


                //obligatorisk fag
                
                    //obligatoriske mattefag
                    var oblig_matte1_2 = new ObligFags();
                    oblig_matte1_2.Id = 60;
                    oblig_matte1_2.Fagnavn = "Matematikk, emne 1";
                    oblig_matte1_2.Semester = 1;
                    oblig_matte1_2.Emnekode = "M5GMT1100";
                    oblig_matte1_2.Studiepoeng = 15;
                    oblig_matte1_2.KlasseId = 2;
                    context.Add(oblig_matte1_2);

                    var oblig_matte2_2 = new ObligFags();
                    oblig_matte2_2.Id = 61;
                    oblig_matte2_2.Fagnavn = "Matematikk, emne 2";
                    oblig_matte2_2.Semester = 1;
                    oblig_matte2_2.Emnekode = "M5GMT1200";
                    oblig_matte2_2.Studiepoeng = 7.5;
                    oblig_matte2_2.KlasseId = 2;
                    context.Add(oblig_matte2_2);

                    var oblig_matte3_2 = new ObligFags();
                    oblig_matte3_2.Id = 62;
                    oblig_matte3_2.Fagnavn = "Matematikk, emne 2";
                    oblig_matte3_2.Semester = 2;
                    oblig_matte3_2.Emnekode = "M5GMT1200";
                    oblig_matte3_2.Studiepoeng = 7.5;
                    oblig_matte3_2.KlasseId = 2;
                    context.Add(oblig_matte3_2);

                    var oblig_matte4_2 = new ObligFags();
                    oblig_matte4_2.Id = 63;
                    oblig_matte4_2.Fagnavn = "Matematikk, emne 3";
                    oblig_matte4_2.Semester = 2;
                    oblig_matte4_2.Emnekode = "M5GMT1300";
                    oblig_matte4_2.Studiepoeng = 15;
                    oblig_matte4_2.KlasseId = 2;
                    context.Add(oblig_matte4_2);

                    var oblig_matte5_2 = new ObligFags();
                    oblig_matte5_2.Id = 64;
                    oblig_matte5_2.Fagnavn = "Matematikk, emne 4";
                    oblig_matte5_2.Semester = 3;
                    oblig_matte5_2.Emnekode = "M5GMT2100";
                    oblig_matte5_2.Studiepoeng = 15;
                    oblig_matte5_2.KlasseId = 2;
                    context.Add(oblig_matte5_2);



                    //obligatoriske Engelskfag
                    var oblig_engelsk1_2 = new ObligFags();
                    oblig_engelsk1_2.Id = 65;
                    oblig_engelsk1_2.Fagnavn = "Engelsk, emne 1";
                    oblig_engelsk1_2.Semester = 1;
                    oblig_engelsk1_2.Emnekode = "M5GEN1100";
                    oblig_engelsk1_2.Studiepoeng = 15;
                    oblig_engelsk1_2.KlasseId = 2;
                    context.Add(oblig_engelsk1_2);

                    var oblig_engelsk2_2 = new ObligFags();
                    oblig_engelsk2_2.Id = 66;
                    oblig_engelsk2_2.Fagnavn = "Engelsk, emne 2";
                    oblig_engelsk2_2.Semester = 1;
                    oblig_engelsk2_2.Emnekode = "M5GEN1200";
                    oblig_engelsk2_2.Studiepoeng = 7.5;
                    oblig_engelsk2_2.KlasseId = 2;
                    context.Add(oblig_engelsk2_2);

                    var oblig_engelsk3_2 = new ObligFags();
                    oblig_engelsk3_2.Id = 67;
                    oblig_engelsk3_2.Fagnavn = "Matematikk, emne 2";
                    oblig_engelsk3_2.Semester = 2;
                    oblig_engelsk3_2.Emnekode = "M5GEN1200";
                    oblig_engelsk3_2.Studiepoeng = 7.5;
                    oblig_engelsk3_2.KlasseId = 2;
                    context.Add(oblig_engelsk3_2);

                    var oblig_engelsk4_2 = new ObligFags();
                    oblig_engelsk4_2.Id = 68;
                    oblig_engelsk4_2.Fagnavn = "Engelsk, emne 3";
                    oblig_engelsk4_2.Semester = 2;
                    oblig_engelsk4_2.Emnekode = "M5GEN1300";
                    oblig_engelsk4_2.Studiepoeng = 15;
                    oblig_engelsk4_2.KlasseId = 2;
                    context.Add(oblig_engelsk4_2);

                    var oblig_engelsk5_2 = new ObligFags();
                    oblig_engelsk5_2.Id = 69;
                    oblig_engelsk5_2.Fagnavn = "Engelsk, emne 4";
                    oblig_engelsk5_2.Semester = 3;
                    oblig_engelsk5_2.Emnekode = "M5GEN2100";
                    oblig_engelsk5_2.Studiepoeng = 15;
                    oblig_engelsk5_2.KlasseId = 2;
                    context.Add(oblig_engelsk5_2);



                    //obligatoriske Norskfag
                    var oblig_norsk1_2 = new ObligFags();
                    oblig_norsk1_2.Id = 70;
                    oblig_norsk1_2.Fagnavn = "Norsk, emne 1";
                    oblig_norsk1_2.Semester = 1;
                    oblig_norsk1_2.Emnekode = "M5GNO1100";
                    oblig_norsk1_2.Studiepoeng = 15;
                    oblig_norsk1_2.KlasseId = 2;
                    context.Add(oblig_norsk1_2);

                    var oblig_norsk2_2 = new ObligFags();
                    oblig_norsk2_2.Id = 71;
                    oblig_norsk2_2.Fagnavn = "Norsk, emne 2";
                    oblig_norsk2_2.Semester = 1;
                    oblig_norsk2_2.Emnekode = "M5GNO1200";
                    oblig_norsk2_2.Studiepoeng = 7.5;
                    oblig_norsk2_2.KlasseId = 2;
                    context.Add(oblig_norsk2_2);

                    var oblig_norsk3_2 = new ObligFags();
                    oblig_norsk3_2.Id = 72;
                    oblig_norsk3_2.Fagnavn = "Norsk, emne 2";
                    oblig_norsk3_2.Semester = 2;
                    oblig_norsk3_2.Emnekode = "M5GNO1200";
                    oblig_norsk3_2.Studiepoeng = 7.5;
                    oblig_norsk3_2.KlasseId = 2;
                    context.Add(oblig_norsk3_2);

                    var oblig_norsk4_2 = new ObligFags();
                    oblig_norsk4_2.Id = 73;
                    oblig_norsk4_2.Fagnavn = "Norsk, emne 3";
                    oblig_norsk4_2.Semester = 2;
                    oblig_norsk4_2.Emnekode = "M5GNO1300";
                    oblig_norsk4_2.Studiepoeng = 15;
                    oblig_norsk4_2.KlasseId = 2;
                    context.Add(oblig_norsk4_2);

                    var oblig_norsk5_2 = new ObligFags();
                    oblig_norsk5_2.Id = 74;
                    oblig_norsk5_2.Fagnavn = "Norsk, emne 4";
                    oblig_norsk5_2.Semester = 3;
                    oblig_norsk5_2.Emnekode = "M5GNO2100";
                    oblig_norsk5_2.Studiepoeng = 15;
                    oblig_norsk5_2.KlasseId = 2;
                    context.Add(oblig_norsk5_2);

                //Masterfag

                    //Masterfag 1 Norsk
                    var masterfag_norsk_2 = new MasterFag();
                    masterfag_norsk_2.Id = 14;
                    masterfag_norsk_2.Fagnavn = "Norsk";
                    masterfag_norsk_2.KlasseId = 2;
                    context.Add(masterfag_norsk_2);

                        //muligheter masterFagId 14
                        var norsk_muligheter1_2 = new Muligheter();
                        norsk_muligheter1_2.Id = 75;
                        norsk_muligheter1_2.Fagnavn = "Norsk og norskdidaktikk 1";
                        norsk_muligheter1_2.Semester = 7;
                        norsk_muligheter1_2.Emnekode = "MGNO4100";
                        norsk_muligheter1_2.Studiepoeng = 15;
                        norsk_muligheter1_2.MasterFagId = 14;
                        context.Add(norsk_muligheter1_2);

                        //muligheter masterFagId 14
                        var norsk_muligheter2_2 = new Muligheter();
                        norsk_muligheter2_2.Id = 76;
                        norsk_muligheter2_2.Fagnavn = "Norsk og norskdidaktikk 2";
                        norsk_muligheter2_2.Semester = 8;
                        norsk_muligheter2_2.Emnekode = "MGNO4200";
                        norsk_muligheter2_2.Studiepoeng = 15;
                        norsk_muligheter2_2.MasterFagId = 14;
                        context.Add(norsk_muligheter2_2);

                        //muligheter masterFagId 14
                        var norsk_muligheter3_2 = new Muligheter();
                        norsk_muligheter3_2.Id = 77;
                        norsk_muligheter3_2.Fagnavn = "Norsk og norskdidaktikk 3";
                        norsk_muligheter3_2.Semester = 9;
                        norsk_muligheter3_2.Emnekode = "MGNO5100";
                        norsk_muligheter3_2.Studiepoeng = 15;
                        norsk_muligheter3_2.MasterFagId = 14;
                        context.Add(norsk_muligheter3_2);



                    //Masterfag 2 Matte
                    var masterfag_matte_2 = new MasterFag();
                    masterfag_matte_2.Id = 15;
                    masterfag_matte_2.Fagnavn = "Matte";
                    masterfag_matte_2.KlasseId = 2;
                    context.Add(masterfag_matte_2);

                        //Muligheter masterFagId 15
                        var matte_muligheter1_2 = new Muligheter();
                        matte_muligheter1_2.Id = 78;
                        matte_muligheter1_2.Fagnavn = "Matematikk og matematikkdidaktikk 1";
                        matte_muligheter1_2.Semester = 7;
                        matte_muligheter1_2.Emnekode = "MGMT4100";
                        matte_muligheter1_2.Studiepoeng = 15;
                        matte_muligheter1_2.MasterFagId = 15;
                        context.Add(matte_muligheter1_2);

                        //Muligheter masterFagId 15
                        var matte_muligheter2_2 = new Muligheter();
                        matte_muligheter2_2.Id = 79;
                        matte_muligheter2_2.Fagnavn = "Matematikk og matematikkdidaktikk 2";
                        matte_muligheter2_2.Semester = 8;
                        matte_muligheter2_2.Emnekode = "MGMT4200";
                        matte_muligheter2_2.Studiepoeng = 15;
                        matte_muligheter2_2.MasterFagId = 15;
                        context.Add(matte_muligheter2_2);

                        //Muligheter masterFagId 15
                        var matte_muligheter3_2 = new Muligheter();
                        matte_muligheter3_2.Id = 80;
                        matte_muligheter3_2.Fagnavn = "Matematikk og matematikkdidaktikk 3";
                        matte_muligheter3_2.Semester = 9;
                        matte_muligheter3_2.Emnekode = "MGMT5100";
                        matte_muligheter3_2.Studiepoeng = 15;
                        matte_muligheter3_2.MasterFagId = 15;
                        context.Add(matte_muligheter3_2);



                    //Masterfag Engelsk
                    var masterfag_engelsk_2 = new MasterFag();
                    masterfag_engelsk_2.Id = 16;
                    masterfag_engelsk_2.Fagnavn = "Engelsk";
                    masterfag_engelsk_2.KlasseId = 2;
                    context.Add(masterfag_engelsk_2);

                        //Muligheter masterFagId 16
                        var engelsk_muligheter1_2 = new Muligheter();
                        engelsk_muligheter1_2.Id = 81;
                        engelsk_muligheter1_2.Fagnavn = "Engelsk og engelskdidaktikk 1";
                        engelsk_muligheter1_2.Semester = 7;
                        engelsk_muligheter1_2.Emnekode = "MGEN4100";
                        engelsk_muligheter1_2.Studiepoeng = 15;
                        engelsk_muligheter1_2.MasterFagId = 16;
                        context.Add(engelsk_muligheter1_2);

                        //Muligheter masterFagId 16
                        var engelsk_muligheter2_2 = new Muligheter();
                        engelsk_muligheter2_2.Id = 82;
                        engelsk_muligheter2_2.Fagnavn = "Engelsk og engelskdidaktikk 2";
                        engelsk_muligheter2_2.Semester = 8;
                        engelsk_muligheter2_2.Emnekode = "MGEN4200";
                        engelsk_muligheter2_2.Studiepoeng = 15;
                        engelsk_muligheter2_2.MasterFagId = 16;
                        context.Add(engelsk_muligheter2_2);

                        //Muligheter masterFagId 16
                        var engelsk_muligheter3_2 = new Muligheter();
                        engelsk_muligheter3_2.Id = 83;
                        engelsk_muligheter3_2.Fagnavn = "Engelsk og engelskdidaktikk 3";
                        engelsk_muligheter3_2.Semester = 9;
                        engelsk_muligheter3_2.Emnekode = "MGEN5100";
                        engelsk_muligheter3_2.Studiepoeng = 15;
                        engelsk_muligheter3_2.MasterFagId = 16;
                        context.Add(engelsk_muligheter3_2);



                    //Masterfag KRLE
                    var masterfag_KRLE_2 = new MasterFag();
                    masterfag_KRLE_2.Id = 17;
                    masterfag_KRLE_2.Fagnavn = "KRLE";
                    masterfag_KRLE_2.KlasseId = 2;
                    context.Add(masterfag_KRLE_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter1_2 = new Muligheter();
                        KRLE_muligheter1_2.Id = 84;
                        KRLE_muligheter1_2.Fagnavn = "RLE 1, emne 1";
                        KRLE_muligheter1_2.Semester = 4;
                        KRLE_muligheter1_2.Emnekode = "M5GRL2100";
                        KRLE_muligheter1_2.Studiepoeng = 15;
                        KRLE_muligheter1_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter1_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter2_2 = new Muligheter();
                        KRLE_muligheter2_2.Id = 85;
                        KRLE_muligheter2_2.Fagnavn = "RLE 1, emne 2";
                        KRLE_muligheter2_2.Semester = 4;
                        KRLE_muligheter2_2.Emnekode = "M5GRL2200";
                        KRLE_muligheter2_2.Studiepoeng = 15;
                        KRLE_muligheter2_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter2_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter3_2 = new Muligheter();
                        KRLE_muligheter3_2.Id = 86;
                        KRLE_muligheter3_2.Fagnavn = "RLE 2, emne 3";
                        KRLE_muligheter3_2.Semester = 5;
                        KRLE_muligheter3_2.Emnekode = "M5GRL3100";
                        KRLE_muligheter3_2.Studiepoeng = 30;
                        KRLE_muligheter3_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter3_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter4_2 = new Muligheter();
                        KRLE_muligheter4_2.Id = 87;
                        KRLE_muligheter4_2.Fagnavn = "RLE og RLE-didaktikk 1";
                        KRLE_muligheter4_2.Semester = 7;
                        KRLE_muligheter4_2.Emnekode = "MGRL4100";
                        KRLE_muligheter4_2.Studiepoeng = 15;
                        KRLE_muligheter4_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter4_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter5_2 = new Muligheter();
                        KRLE_muligheter5_2.Id = 88;
                        KRLE_muligheter5_2.Fagnavn = "RLE og RLE-didaktikk 2";
                        KRLE_muligheter5_2.Semester = 8;
                        KRLE_muligheter5_2.Emnekode = "MGRL4200";
                        KRLE_muligheter5_2.Studiepoeng = 15;
                        KRLE_muligheter5_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter5_2);

                        //Muligheter masterFagId 17
                        var KRLE_muligheter6_2 = new Muligheter();
                        KRLE_muligheter6_2.Id = 89;
                        KRLE_muligheter6_2.Fagnavn = "RLE og RLE-didaktikk 3";
                        KRLE_muligheter6_2.Semester = 9;
                        KRLE_muligheter6_2.Emnekode = "MGRL5100";
                        KRLE_muligheter6_2.Studiepoeng = 15;
                        KRLE_muligheter6_2.MasterFagId = 17;
                        context.Add(KRLE_muligheter6_2);



                    //Masterfag kroppsøving
                    var masterfag_gym_2 = new MasterFag();
                    masterfag_gym_2.Id = 18;
                    masterfag_gym_2.Fagnavn = "Kroppsøving";
                    masterfag_gym_2.KlasseId = 2;
                    context.Add(masterfag_gym_2);

                        //Muligheter masterFagId 18
                        var gym_muligheter1_2 = new Muligheter();
                        gym_muligheter1_2.Id = 90;
                        gym_muligheter1_2.Fagnavn = "Kroppsøving 1, emne 1";
                        gym_muligheter1_2.Semester = 4;
                        gym_muligheter1_2.Emnekode = "M5GKP2100";
                        gym_muligheter1_2.Studiepoeng = 30;
                        gym_muligheter1_2.MasterFagId = 18;
                        context.Add(gym_muligheter1_2);

                        //Muligheter masterFagId 18
                        var gym_muligheter2_2 = new Muligheter();
                        gym_muligheter2_2.Id = 91;
                        gym_muligheter2_2.Fagnavn = "Kroppsøving 2, emne 2";
                        gym_muligheter2_2.Semester = 5;
                        gym_muligheter2_2.Emnekode = "M1GKP3100";
                        gym_muligheter2_2.Studiepoeng = 30;
                        gym_muligheter2_2.MasterFagId = 18;
                        context.Add(gym_muligheter2_2);

                        //Muligheter masterFagId 18
                        var gym_muligheter3_2 = new Muligheter();
                        gym_muligheter3_2.Id = 92;
                        gym_muligheter3_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 1";
                        gym_muligheter3_2.Semester = 7;
                        gym_muligheter3_2.Emnekode = "MGKP4100";
                        gym_muligheter3_2.Studiepoeng = 15;
                        gym_muligheter3_2.MasterFagId = 18;
                        context.Add(gym_muligheter3_2);

                        //Muligheter masterFagId 18
                        var gym_muligheter4_2 = new Muligheter();
                        gym_muligheter4_2.Id = 93;
                        gym_muligheter4_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 2";
                        gym_muligheter4_2.Semester = 8;
                        gym_muligheter4_2.Emnekode = "MGKP4200";
                        gym_muligheter4_2.Studiepoeng = 15;
                        gym_muligheter4_2.MasterFagId = 18;
                        context.Add(gym_muligheter4_2);

                        //Muligheter masterFagId 18
                        var gym_muligheter5_2 = new Muligheter();
                        gym_muligheter5_2.Id = 94;
                        gym_muligheter5_2.Fagnavn = "Kroppsøving og kroppsøvingsdidaktikk 3";
                        gym_muligheter5_2.Semester = 9;
                        gym_muligheter5_2.Emnekode = "MGKP5100";
                        gym_muligheter5_2.Studiepoeng = 15;
                        gym_muligheter5_2.MasterFagId = 18;
                        context.Add(gym_muligheter5_2);



                    //Masterfag KH
                    var masterfag_KH_2 = new MasterFag();
                    masterfag_KH_2.Id = 19;
                    masterfag_KH_2.Fagnavn = "Kunst og håndverk";
                    masterfag_KH_2.KlasseId = 2;
                    context.Add(masterfag_KH_2);

                        //Muligheter masterFagId 19
                        var KH_muligheter1_2 = new Muligheter();
                        KH_muligheter1_2.Id = 95;
                        KH_muligheter1_2.Fagnavn = "Kunst og håndverk 1, emne 1";
                        KH_muligheter1_2.Semester = 4;
                        KH_muligheter1_2.Emnekode = "MGKH2100";
                        KH_muligheter1_2.Studiepoeng = 30;
                        KH_muligheter1_2.MasterFagId = 19;
                        context.Add(KH_muligheter1_2);

                        //Muligheter masterFagId 19
                        var KH_muligheter2_2 = new Muligheter();
                        KH_muligheter2_2.Id = 96;
                        KH_muligheter2_2.Fagnavn = "Kunst og håndverk 2, emne 2";
                        KH_muligheter2_2.Semester = 5;
                        KH_muligheter2_2.Emnekode = "MGKH2100";
                        KH_muligheter2_2.Studiepoeng = 30;
                        KH_muligheter2_2.MasterFagId = 19;
                        context.Add(KH_muligheter2_2);

                        //Muligheter masterFagId 19
                        var KH_muligheter3_2 = new Muligheter();
                        KH_muligheter3_2.Id = 97;
                        KH_muligheter3_2.Fagnavn = "Fagdidaktikk: kunst og håndverk";
                        KH_muligheter3_2.Semester = 7;
                        KH_muligheter3_2.Emnekode = "MFAGL4000";
                        KH_muligheter3_2.Studiepoeng = 15;
                        KH_muligheter3_2.MasterFagId = 19;
                        context.Add(KH_muligheter3_2);

                        //Muligheter masterFagId 19
                        var KH_muligheter4_2 = new Muligheter();
                        KH_muligheter4_2.Id = 98;
                        KH_muligheter4_2.Fagnavn = "Praktisk estetisk prosjekt";
                        KH_muligheter4_2.Semester = 8;
                        KH_muligheter4_2.Emnekode = "MFAGL4200";
                        KH_muligheter4_2.Studiepoeng = 15;
                        KH_muligheter4_2.MasterFagId = 19;
                        context.Add(KH_muligheter4_2);

                        //Muligheter masterFagId 19
                        var KH_muligheter5_2 = new Muligheter();
                        KH_muligheter5_2.Id = 99;
                        KH_muligheter5_2.Fagnavn = "Prosjektutvikling og undervisningspraksis";
                        KH_muligheter5_2.Semester = 9;
                        KH_muligheter5_2.Emnekode = "MFAGL5000";
                        KH_muligheter5_2.Studiepoeng = 15;
                        KH_muligheter5_2.MasterFagId = 19;
                        context.Add(KH_muligheter5_2);


                    //Masterfag Musikk
                    var masterfag_musikk_2 = new MasterFag();
                    masterfag_musikk_2.Id = 20;
                    masterfag_musikk_2.Fagnavn = "Musikk";
                    masterfag_musikk_2.KlasseId = 2;
                    context.Add(masterfag_musikk_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter1_2 = new Muligheter();
                        musikk_muligheter1_2.Id = 100;
                        musikk_muligheter1_2.Fagnavn = "Musikk 1, emne 1";
                        musikk_muligheter1_2.Semester = 4;
                        musikk_muligheter1_2.Emnekode = "M5GMU2100";
                        musikk_muligheter1_2.Studiepoeng = 15;
                        musikk_muligheter1_2.MasterFagId = 20;
                        context.Add(musikk_muligheter1_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter2_2 = new Muligheter();
                        musikk_muligheter2_2.Id = 101;
                        musikk_muligheter2_2.Fagnavn = "Musikk 1, emne 2";
                        musikk_muligheter2_2.Semester = 4;
                        musikk_muligheter2_2.Emnekode = "M5GMU2200";
                        musikk_muligheter2_2.Studiepoeng = 15;
                        musikk_muligheter2_2.MasterFagId = 20;
                        context.Add(musikk_muligheter2_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter3_2 = new Muligheter();
                        musikk_muligheter3_2.Id = 102;
                        musikk_muligheter3_2.Fagnavn = "Musikk 2, emne 3";
                        musikk_muligheter3_2.Semester = 5;
                        musikk_muligheter3_2.Emnekode = "M5GMU3100";
                        musikk_muligheter3_2.Studiepoeng = 30;
                        musikk_muligheter3_2.MasterFagId = 20;
                        context.Add(musikk_muligheter3_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter4_2 = new Muligheter();
                        musikk_muligheter4_2.Id = 103;
                        musikk_muligheter4_2.Fagnavn = "Musikk og musikkdidaktikk 1";
                        musikk_muligheter4_2.Semester = 7;
                        musikk_muligheter4_2.Emnekode = "MGMU4100";
                        musikk_muligheter4_2.Studiepoeng = 15;
                        musikk_muligheter4_2.MasterFagId = 20;
                        context.Add(musikk_muligheter4_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter5_2 = new Muligheter();
                        musikk_muligheter5_2.Id = 104;
                        musikk_muligheter5_2.Fagnavn = "Musikk og musikkdidaktikk 2";
                        musikk_muligheter5_2.Semester = 8;
                        musikk_muligheter5_2.Emnekode = "MGMU4200";
                        musikk_muligheter5_2.Studiepoeng = 15;
                        musikk_muligheter5_2.MasterFagId = 20;
                        context.Add(musikk_muligheter5_2);

                        //Muligheter masterFagId 20
                        var musikk_muligheter6_2 = new Muligheter();
                        musikk_muligheter6_2.Id = 105;
                        musikk_muligheter6_2.Fagnavn = "Musikk og musikkdidaktikk 3";
                        musikk_muligheter6_2.Semester = 9;
                        musikk_muligheter6_2.Emnekode = "MGMU5100";
                        musikk_muligheter6_2.Studiepoeng = 15;
                        musikk_muligheter6_2.MasterFagId = 20;
                        context.Add(musikk_muligheter6_2);



                    //Masterfag Naturfag
                    var masterfag_naturfag_2 = new MasterFag();
                    masterfag_naturfag_2.Id = 21;
                    masterfag_naturfag_2.Fagnavn = "Naturfag";
                    masterfag_naturfag_2.KlasseId = 2;
                    context.Add(masterfag_naturfag_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter1_2 = new Muligheter();
                        naturfag_muligheter1_2.Id = 106;
                        naturfag_muligheter1_2.Fagnavn = "Naturfag 1, emne 1";
                        naturfag_muligheter1_2.Semester = 4;
                        naturfag_muligheter1_2.Emnekode = "M5GNA2100";
                        naturfag_muligheter1_2.Studiepoeng = 15;
                        naturfag_muligheter1_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter1_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter2_2 = new Muligheter();
                        naturfag_muligheter2_2.Id = 107;
                        naturfag_muligheter2_2.Fagnavn = "Naturfag 1, emne 2";
                        naturfag_muligheter2_2.Semester = 4;
                        naturfag_muligheter2_2.Emnekode = "M5GNA2200";
                        naturfag_muligheter2_2.Studiepoeng = 15;
                        naturfag_muligheter2_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter2_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter3_2 = new Muligheter();
                        naturfag_muligheter3_2.Id = 108;
                        naturfag_muligheter3_2.Fagnavn = "Naturfag 2, emne 3";
                        naturfag_muligheter3_2.Semester = 5;
                        naturfag_muligheter3_2.Emnekode = "M5GNA3100";
                        naturfag_muligheter3_2.Studiepoeng = 30;
                        naturfag_muligheter3_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter3_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter4_2 = new Muligheter();
                        naturfag_muligheter4_2.Id = 109;
                        naturfag_muligheter4_2.Fagnavn = "Naturfag og naturfagdidaktikk 1";
                        naturfag_muligheter4_2.Semester = 7;
                        naturfag_muligheter4_2.Emnekode = "MGNA4100";
                        naturfag_muligheter4_2.Studiepoeng = 15;
                        naturfag_muligheter4_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter4_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter5_2 = new Muligheter();
                        naturfag_muligheter5_2.Id = 110;
                        naturfag_muligheter5_2.Fagnavn = "Naturfag og naturfagdidaktikk 2";
                        naturfag_muligheter5_2.Semester = 8;
                        naturfag_muligheter5_2.Emnekode = "MGNA4200";
                        naturfag_muligheter5_2.Studiepoeng = 15;
                        naturfag_muligheter5_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter5_2);

                        //Muligheter masterFagId 21
                        var naturfag_muligheter6_2 = new Muligheter();
                        naturfag_muligheter6_2.Id = 111;
                        naturfag_muligheter6_2.Fagnavn = "Naturfag og naturfagdidaktikk 3";
                        naturfag_muligheter6_2.Semester = 9;
                        naturfag_muligheter6_2.Emnekode = "MGNA5100";
                        naturfag_muligheter6_2.Studiepoeng = 15;
                        naturfag_muligheter6_2.MasterFagId = 21;
                        context.Add(naturfag_muligheter6_2);


                    //Masterfag samfunnsfag
                    var masterfag_samfunnsfag_2 = new MasterFag();
                    masterfag_samfunnsfag_2.Id = 22;
                    masterfag_samfunnsfag_2.Fagnavn = "Samfunnsfag";
                    masterfag_samfunnsfag_2.KlasseId = 2;
                    context.Add(masterfag_samfunnsfag_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter1_2 = new Muligheter();
                        samfunnsfag_muligheter1_2.Id = 112;
                        samfunnsfag_muligheter1_2.Fagnavn = "Samfunnsfag 1, emne 1";
                        samfunnsfag_muligheter1_2.Semester = 4;
                        samfunnsfag_muligheter1_2.Emnekode = "M5GSF2100";
                        samfunnsfag_muligheter1_2.Studiepoeng = 15;
                        samfunnsfag_muligheter1_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter1_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter2_2 = new Muligheter();
                        samfunnsfag_muligheter2_2.Id = 113;
                        samfunnsfag_muligheter2_2.Fagnavn = "Samfunnsfag 1, emne 2";
                        samfunnsfag_muligheter2_2.Semester = 4;
                        samfunnsfag_muligheter2_2.Emnekode = "M5GSF2200";
                        samfunnsfag_muligheter2_2.Studiepoeng = 15;
                        samfunnsfag_muligheter2_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter2_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter3_2 = new Muligheter();
                        samfunnsfag_muligheter3_2.Id = 114;
                        samfunnsfag_muligheter3_2.Fagnavn = "Samfunnsfag 2, emne 3";
                        samfunnsfag_muligheter3_2.Semester = 5;
                        samfunnsfag_muligheter3_2.Emnekode = "M5GSF3100";
                        samfunnsfag_muligheter3_2.Studiepoeng = 30;
                        samfunnsfag_muligheter3_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter3_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter4_2 = new Muligheter();
                        samfunnsfag_muligheter4_2.Id = 115;
                        samfunnsfag_muligheter4_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 1";
                        samfunnsfag_muligheter4_2.Semester = 7;
                        samfunnsfag_muligheter4_2.Emnekode = "MGSF4100";
                        samfunnsfag_muligheter4_2.Studiepoeng = 15;
                        samfunnsfag_muligheter4_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter4_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter5_2 = new Muligheter();
                        samfunnsfag_muligheter5_2.Id = 116;
                        samfunnsfag_muligheter5_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 2";
                        samfunnsfag_muligheter5_2.Semester = 8;
                        samfunnsfag_muligheter5_2.Emnekode = "MGSF4200";
                        samfunnsfag_muligheter5_2.Studiepoeng = 15;
                        samfunnsfag_muligheter5_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter5_2);

                        //Muligheter masterFagId 22
                        var samfunnsfag_muligheter6_2 = new Muligheter();
                        samfunnsfag_muligheter6_2.Id = 117;
                        samfunnsfag_muligheter6_2.Fagnavn = "Samfunnsfag og samfunnsfagdidaktikk 3";
                        samfunnsfag_muligheter6_2.Semester = 9;
                        samfunnsfag_muligheter6_2.Emnekode = "MGSF5100";
                        samfunnsfag_muligheter6_2.Studiepoeng = 15;
                        samfunnsfag_muligheter6_2.MasterFagId = 22;
                        context.Add(samfunnsfag_muligheter6_2);



                    //Masterfag Tegnspråk
                    var masterfag_tegnspråk_2 = new MasterFag();
                    masterfag_tegnspråk_2.Id = 23;
                    masterfag_tegnspråk_2.Fagnavn = "Tegnspråk";
                    masterfag_tegnspråk_2.KlasseId = 2;
                    context.Add(masterfag_tegnspråk_2);

                        //Muligheter masterFagId 23
                        var tegnspråk_muligheter1_2 = new Muligheter();
                        tegnspråk_muligheter1_2.Id = 118;
                        tegnspråk_muligheter1_2.Fagnavn = "Norsk tegnspråk 1";
                        tegnspråk_muligheter1_2.Semester = 5;
                        tegnspråk_muligheter1_2.Emnekode = "MGNT3100";
                        tegnspråk_muligheter1_2.Studiepoeng = 0;
                        tegnspråk_muligheter1_2.MasterFagId = 23;
                        context.Add(tegnspråk_muligheter1);

                        //Muligheter masterFagId 23
                        var tegnspråk_muligheter2_2 = new Muligheter();
                        tegnspråk_muligheter2_2.Id = 119;
                        tegnspråk_muligheter2_2.Fagnavn = "Norsk tegnspråk 2";
                        tegnspråk_muligheter2_2.Semester = 6;
                        tegnspråk_muligheter2_2.Emnekode = "MGNT3200";
                        tegnspråk_muligheter2_2.Studiepoeng = 0;
                        tegnspråk_muligheter2_2.MasterFagId = 23;
                        context.Add(tegnspråk_muligheter2_2);

                        //Muligheter masterFagId 23
                        var tegnspråk_muligheter3_2 = new Muligheter();
                        tegnspråk_muligheter3_2.Id = 120;
                        tegnspråk_muligheter3_2.Fagnavn = "";
                        tegnspråk_muligheter3_2.Semester = 7;
                        tegnspråk_muligheter3_2.Emnekode = "";
                        tegnspråk_muligheter3_2.Studiepoeng = 0;
                        tegnspråk_muligheter3_2.MasterFagId = 23;
                        context.Add(tegnspråk_muligheter3_2);

                        //Muligheter masterFagId 23
                        var tegnspråk_muligheter4_2 = new Muligheter();
                        tegnspråk_muligheter4_2.Id = 121;
                        tegnspråk_muligheter4_2.Fagnavn = "";
                        tegnspråk_muligheter4_2.Semester = 8;
                        tegnspråk_muligheter4_2.Emnekode = "";
                        tegnspråk_muligheter4_2.Studiepoeng = 0;
                        tegnspråk_muligheter4_2.MasterFagId = 23;
                        context.Add(tegnspråk_muligheter4_2);

                        //Muligheter masterFagId 23
                        var tegnspråk_muligheter5_2 = new Muligheter();
                        tegnspråk_muligheter5_2.Id = 122;
                        tegnspråk_muligheter5_2.Fagnavn = "";
                        tegnspråk_muligheter5_2.Semester = 9;
                        tegnspråk_muligheter5_2.Emnekode = "";
                        tegnspråk_muligheter5_2.Studiepoeng = 0;
                        tegnspråk_muligheter5_2.MasterFagId = 23;
                        context.Add(tegnspråk_muligheter5_2);


                    //Masterfag Profesjonell pedagogikk
                    var masterfag_profped_2 = new MasterFag();
                    masterfag_profped_2.Id = 24;
                    masterfag_profped_2.Fagnavn = "Profesjonsrettet pedagogikk";
                    masterfag_profped_2.KlasseId = 2;
                    context.Add(masterfag_profped_2);

                        //Muligheter masterFagId 24
                        var prof_ped1_2 = new Muligheter();
                        prof_ped1_2.Id = 123;
                        prof_ped1_2.Fagnavn = "Pedagogikk fordypning 1: Profesjonsrettet pedagogikk";
                        prof_ped1_2.Semester = 6;
                        prof_ped1_2.Emnekode = "MGPE3100";
                        prof_ped1_2.Studiepoeng = 30;
                        prof_ped1_2.MasterFagId = 24;
                        context.Add(prof_ped1_2);

                        //Muligheter masterFagId 24
                        var prof_ped2_2 = new Muligheter();
                        prof_ped2_2.Id = 124;
                        prof_ped2_2.Fagnavn = "Pedagogikk fordypning 2: Profesjonsrettet pedagogikk";
                        prof_ped2_2.Semester = 9;
                        prof_ped2_2.Emnekode = "MGPE5100";
                        prof_ped2_2.Studiepoeng = 30;
                        prof_ped2_2.MasterFagId = 24;
                        context.Add(prof_ped2_2);



                    //Masterfag digital pedagogikk
                    var masterfag_digped_2 = new MasterFag();
                    masterfag_digped_2.Id = 25;
                    masterfag_digped_2.Fagnavn = "Profesjonsrettet pedagogikk";
                    masterfag_digped_2.KlasseId = 2;
                    context.Add(masterfag_digped_2);

                        //Muligheter masterFagId 25
                        var dig_ped1_2 = new Muligheter();
                        dig_ped1_2.Id = 125;
                        dig_ped1_2.Fagnavn = "Pedagogikk fordypning 1: Digitalt støttet pedagogikk";
                        dig_ped1_2.Semester = 6;
                        dig_ped1_2.Emnekode = "MGPE3200";
                        dig_ped1_2.Studiepoeng = 30;
                        dig_ped1_2.MasterFagId = 25;
                        context.Add(dig_ped1_2);

                        //Muligheter masterFagId 25
                        var dig_ped2_2 = new Muligheter();
                        dig_ped2_2.Id = 126;
                        dig_ped2_2.Fagnavn = "Pedagogikk fordypning 2: Digitalt støttet pedagogikk";
                        dig_ped2_2.Semester = 9;
                        dig_ped2_2.Emnekode = "MGPE5200";
                        dig_ped2_2.Studiepoeng = 30;
                        dig_ped2_2.MasterFagId = 25;
                        context.Add(dig_ped2_2);



                    //Masterfag Profesjonell pedagogikk
                    var masterfag_spesped_2 = new MasterFag();
                    masterfag_spesped_2.Id = 26;
                    masterfag_spesped_2.Fagnavn = "Profesjonsrettet pedagogikk";
                    masterfag_spesped_2.KlasseId = 2;
                    context.Add(masterfag_spesped_2);

                        //Muligheter masterFagId 26
                        var spes_ped1_2 = new Muligheter();
                        spes_ped1_2.Id = 127;
                        spes_ped1_2.Fagnavn = "Pedagogikk fordypning 1: Spesialpedagogikk";
                        spes_ped1_2.Semester = 6;
                        spes_ped1_2.Emnekode = "MGPE3300";
                        spes_ped1_2.Studiepoeng = 30;
                        spes_ped1_2.MasterFagId = 26;
                        context.Add(spes_ped1_2);

                        //Muligheter masterFagId 26
                        var spes_ped2_2 = new Muligheter();
                        spes_ped2_2.Id = 128;
                        spes_ped2_2.Fagnavn = "Pedagogikk fordypning 2: Spesialpedagogikk";
                        spes_ped2_2.Semester = 9;
                        spes_ped2_2.Emnekode = "MGPE5300";
                        spes_ped2_2.Studiepoeng = 30;
                        spes_ped2_2.MasterFagId = 26;
                        context.Add(spes_ped2_2);



                //tabell for brukeropplæring 1-7

                //Masterfag brukeropplæring
                var brukeropplæring = new MasterFag();
                brukeropplæring.Id = 27;
                brukeropplæring.Fagnavn = "Brukeropplæring";
                brukeropplæring.KlasseId = 1;
                context.Add(brukeropplæring);

                    //Muligheter masterFagId 27
                    var brukeropplæring1 = new Muligheter();
                    brukeropplæring1.Id = 129;
                    brukeropplæring1.Fagnavn = "Begynneropplæring 1";
                    brukeropplæring1.Semester = 7;
                    brukeropplæring1.Emnekode = "M1GBO4100";
                    brukeropplæring1.Studiepoeng = 15;
                    brukeropplæring1.MasterFagId = 27;
                    context.Add(brukeropplæring1);

                    //Muligheter masterFagId 27
                    var brukeropplæring2 = new Muligheter();
                    brukeropplæring2.Id = 130;
                    brukeropplæring2.Fagnavn = "Begynneropplæring 2";
                    brukeropplæring2.Semester = 8;
                    brukeropplæring2.Emnekode = "M1GBO4200";
                    brukeropplæring2.Studiepoeng = 15;
                    brukeropplæring2.MasterFagId = 27;
                    context.Add(brukeropplæring2);

                    //Muligheter masterFagId 27
                    var brukeropplæring3 = new Muligheter();
                    brukeropplæring3.Id = 131;
                    brukeropplæring3.Fagnavn = "Begynneropplæring 3";
                    brukeropplæring3.Semester = 9;
                    brukeropplæring3.Emnekode = "M1GBO5100";
                    brukeropplæring3.Studiepoeng = 15;
                    brukeropplæring3.MasterFagId = 27;
                    context.Add(brukeropplæring3);






                ////TABELL FOR 1-7
                ////fylle tabell 4. sem

                //// Engelsk 1
                //var engelsk_fyllefag = new FylleFags();
                //engelsk_fyllefag.Id = 1;
                //engelsk_fyllefag.Fagnavn = "Engelsk";
                //engelsk_fyllefag.KlasseId = 1;
                //context.Add(engelsk_fyllefag);

                //    var engelsk_fyllefag1 = new Muligheter();
                //    engelsk_fyllefag1.Id = 1;
                //    engelsk_fyllefag1.Fagnavn = "Engelsk 1, emne 1";
                //    engelsk_fyllefag1.Semester = 4;
                //    engelsk_fyllefag1.Emnekode = "M1GEN2100";
                //    engelsk_fyllefag1.Studiepoeng = 15;
                //    engelsk_fyllefag1.FylleFagId = 1;
                //    context.Add(engelsk_fyllefag1);

                //    var engelsk_fyllefag2 = new Muligheter();
                //    engelsk_fyllefag2.Id = 2;
                //    engelsk_fyllefag2.Fagnavn = "Engelsk 1, emne 2";
                //    engelsk_fyllefag2.Semester = 4;
                //    engelsk_fyllefag2.Emnekode = "M1GEN2200";
                //    engelsk_fyllefag2.Studiepoeng = 15;
                //    engelsk_fyllefag2.FylleFagId = 1;
                //    context.Add(engelsk_fyllefag2);

                //// KRLE 2
                //var KRLE_fyllefag = new FylleFags();
                //KRLE_fyllefag.Id = 2;
                //KRLE_fyllefag.Fagnavn = "KRLE";
                //KRLE_fyllefag.KlasseId = 1;
                //context.Add(KRLE_fyllefag);

                //    var KRLE_fyllefag1 = new Muligheter();
                //    KRLE_fyllefag1.Id = 3;
                //    KRLE_fyllefag1.Fagnavn = "RLE 1, emne 1";
                //    KRLE_fyllefag1.Semester = 4;
                //    KRLE_fyllefag1.Emnekode = "M1GRL2100";
                //    KRLE_fyllefag1.Studiepoeng = 15;
                //    KRLE_fyllefag1.FylleFagId = 2;
                //    context.Add(KRLE_fyllefag1);

                //    var KRLE_fyllefag2 = new Muligheter();
                //    KRLE_fyllefag2.Id = 4;
                //    KRLE_fyllefag2.Fagnavn = "RLE 1, emne 2";
                //    KRLE_fyllefag2.Semester = 4;
                //    KRLE_fyllefag2.Emnekode = "M1GRL2200";
                //    KRLE_fyllefag2.Studiepoeng = 15;
                //    KRLE_fyllefag2.FylleFagId = 2;
                //    context.Add(KRLE_fyllefag2);

                //// Kroppsøving 3
                //var gym_fyllefag = new FylleFags();
                //gym_fyllefag.Id = 3;
                //gym_fyllefag.Fagnavn = "Kroppsøving";
                //gym_fyllefag.KlasseId = 1;
                //context.Add(gym_fyllefag);

                //    var gym_fyllefag1 = new Muligheter();
                //    gym_fyllefag1.Id = 5;
                //    gym_fyllefag1.Fagnavn = "Kroppsøving 1, emne 1";
                //    gym_fyllefag1.Semester = 4;
                //    gym_fyllefag1.Emnekode = "M1GKP2100";
                //    gym_fyllefag1.Studiepoeng = 30;
                //    gym_fyllefag1.FylleFagId = 3;
                //    context.Add(gym_fyllefag1);

                //// Kunst & Håndtverk 4
                //var KH_fyllefag = new FylleFags();
                //KH_fyllefag.Id = 4;
                //KH_fyllefag.Fagnavn = "Kunst og håndverk";
                //KH_fyllefag.KlasseId = 1;
                //context.Add(KH_fyllefag);

                //    var KH_fyllefag1 = new Muligheter();
                //    KH_fyllefag1.Id = 6;
                //    KH_fyllefag1.Fagnavn = "Kunst og håndverk 1, emne 1";
                //    KH_fyllefag1.Semester = 4;
                //    KH_fyllefag1.Emnekode = "MGKH2100";
                //    KH_fyllefag1.Studiepoeng = 30;
                //    KH_fyllefag1.FylleFagId = 4;
                //    context.Add(KH_fyllefag1);

                //// Musikk 5
                //var musikk_fyllefag = new FylleFags();
                //musikk_fyllefag.Id = 5;
                //musikk_fyllefag.Fagnavn = "Musikk";
                //musikk_fyllefag.KlasseId = 1;
                //context.Add(musikk_fyllefag);

                //    var musikk_fyllefag1 = new Muligheter();
                //    musikk_fyllefag1.Id = 7;
                //    musikk_fyllefag1.Fagnavn = "Musikk 1, emne 1";
                //    musikk_fyllefag1.Semester = 4;
                //    musikk_fyllefag1.Emnekode = "M1GMU2100";
                //    musikk_fyllefag1.Studiepoeng = 15;
                //    musikk_fyllefag1.FylleFagId = 5;
                //    context.Add(musikk_fyllefag1);

                //    var musikk_fyllefag2 = new Muligheter();
                //    musikk_fyllefag2.Id = 8;
                //    musikk_fyllefag2.Fagnavn = "Musikk 1, emne 2";
                //    musikk_fyllefag2.Semester = 4;
                //    musikk_fyllefag2.Emnekode = "M1GMU2200";
                //    musikk_fyllefag2.Studiepoeng = 15;
                //    musikk_fyllefag2.FylleFagId = 5;
                //    context.Add(musikk_fyllefag2);

                //// Naturfag 6
                //var naturfag_fyllefag = new FylleFags();
                //naturfag_fyllefag.Id = 6;
                //naturfag_fyllefag.Fagnavn = "Naturfag";
                //naturfag_fyllefag.KlasseId = 1;
                //context.Add(naturfag_fyllefag);

                //    var naturfag_fyllefag1 = new Muligheter();
                //    naturfag_fyllefag1.Id = 9;
                //    naturfag_fyllefag1.Fagnavn = "Naturfag 1, emne 1";
                //    naturfag_fyllefag1.Semester = 4;
                //    naturfag_fyllefag1.Emnekode = "M1GNA2100";
                //    naturfag_fyllefag1.Studiepoeng = 15;
                //    naturfag_fyllefag1.FylleFagId = 6;
                //    context.Add(naturfag_fyllefag1);

                //    var naturfag_fyllefag2 = new Muligheter();
                //    naturfag_fyllefag2.Id = 10;
                //    naturfag_fyllefag2.Fagnavn = "Naturfag 1, emne 2";
                //    naturfag_fyllefag2.Semester = 4;
                //    naturfag_fyllefag2.Emnekode = "M1GNA2200";
                //    naturfag_fyllefag2.Studiepoeng = 15;
                //    naturfag_fyllefag2.FylleFagId = 6;
                //    context.Add(naturfag_fyllefag2);

                //// Samfunnsfag 7
                //var samfunnsfag_fyllefag = new FylleFags();
                //samfunnsfag_fyllefag.Id = 7;
                //samfunnsfag_fyllefag.Fagnavn = "Samfunnsfag";
                //samfunnsfag_fyllefag.KlasseId = 1;
                //context.Add(samfunnsfag_fyllefag);

                //    var samfunnsfag_fyllefag1 = new Muligheter();
                //    samfunnsfag_fyllefag1.Id = 11;
                //    samfunnsfag_fyllefag1.Fagnavn = "Samfunnsfag 1, emne 1";
                //    samfunnsfag_fyllefag1.Semester = 4;
                //    samfunnsfag_fyllefag1.Emnekode = "M1GSF2100";
                //    samfunnsfag_fyllefag1.Studiepoeng = 15;
                //    samfunnsfag_fyllefag1.FylleFagId = 7;
                //    context.Add(samfunnsfag_fyllefag1);

                //    var samfunnsfag_fyllefag2 = new Muligheter();
                //    samfunnsfag_fyllefag2.Id = 12;
                //    samfunnsfag_fyllefag2.Fagnavn = "Samfunnsfag 1, emne 2";
                //    samfunnsfag_fyllefag2.Semester = 4;
                //    samfunnsfag_fyllefag2.Emnekode = "M1GSF2200";
                //    samfunnsfag_fyllefag2.Studiepoeng = 15;
                //    samfunnsfag_fyllefag2.FylleFagId = 7;
                //    context.Add(samfunnsfag_fyllefag2);





                ////fylle tabell 5. sem



                ////fylle tabell 6. sem






                context.SaveChanges();
            }
        }
    }
}

