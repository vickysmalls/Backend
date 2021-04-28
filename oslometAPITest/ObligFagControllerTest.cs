using System;
using Xunit;
using System.Threading.Tasks;
using System.Collections.Generic;
using oslometAPI.Models;
using Moq;
using oslometAPI.Data;
using oslometAPI.Controllers;

namespace oslometAPITest
{
    public class ObligFagControllerTest
    {
        [Fact]
        public async Task GetObligFagOK()
        {

            var obligFag1 = new ObligFags
            {
                Id = 1,
                Fagnavn = "Norsk",
                Emnekode = "1111",
                Semester = 1,
                Studiepoeng = "15",
                URL = "www.oslo.no",
                URL2 = "www.oslo2.no",
                KlasseId = 2,

        
            };
            var obligFag2 = new ObligFags
            {
                Id = 2,
                Fagnavn = "Engelsk",
                Emnekode = "2222",
                Semester = 2,
                Studiepoeng = "30",
                URL = "www.oslo3.no",
                URL2 = "www.oslo4.no",
                KlasseId = 3,
            };
            var obligFag3 = new ObligFags
            {
                Id = 3,
                Fagnavn = "Spesialpedagogikk",
                Emnekode = "3333",
                Semester = 3,
                Studiepoeng = "15",
                URL = "www.oslo4.no",
                URL2 = "www.oslo5.no",
                KlasseId = 5,
            };

            var obligFagsList = new List<ObligFags>();
            obligFagsList.Add(obligFag1);
            obligFagsList.Add(obligFag2);
            obligFagsList.Add(obligFag3);



            var mock = new Mock<IObligFagsRepository>();
            mock.Setup(k => k.GetObligFag()).ReturnsAsync(obligFagsList);
            var obligFagsController = new ObligFagController(mock.Object);
            List<ObligFags> resultat = await obligFagsController.GetObligFag();
            Assert.Equal<List<ObligFags>>(obligFagsList, resultat);
        }

        [Fact]
        public async Task GetObligFagIKKEOK()
        {
            var obligFagsList = new List<ObligFags>();

            var mock = new Mock<IObligFagsRepository>();
            mock.Setup(k => k.GetObligFag()).ReturnsAsync(() => null);
            var obligFagController = new ObligFagController(mock.Object);
            List<ObligFags> resultat = await obligFagController.GetObligFag();
            Assert.Null(resultat);
        }

        [Fact]
        public async Task GetEtObligFagOK()
        {
            var returnObligFag = new ObligFags
            {
                Id = 1,
                Fagnavn = "Norsk",
                Emnekode = "1111",
                Semester = 1,
                Studiepoeng = "15",
                URL = "www.oslo.no",
                URL2 = "www.oslo2.no",
                KlasseId = 2,
            };
            var mock = new Mock<IObligFagsRepository>();
            mock.Setup(k => k.GetObligFag(1)).ReturnsAsync(returnObligFag);
            var obligFagsController = new ObligFagController(mock.Object);
            ObligFags resultat = await obligFagsController.GetObligFag(1);
            Assert.Equal<ObligFags>(returnObligFag, resultat);
        }

        [Fact]
        public async Task GetEtObligFagIKKEOK()
        {
            var mock = new Mock<IObligFagsRepository>();
            mock.Setup(k => k.GetObligFag(1)).ReturnsAsync(() => null);
            var obligFagsController = new ObligFagController(mock.Object);
            ObligFags resultat = await obligFagsController.GetObligFag(1);
            Assert.Null(resultat);
        }
    }
}
