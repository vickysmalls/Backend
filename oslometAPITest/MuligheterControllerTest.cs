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
    public class MuligheterControllerTest
    {
        [Fact]
        public async Task GetMuligheter()
        {
            var mulighet1 = new Muligheter
            {
                Id = 1,
                KlasseId = 1,
                MasterFagId = 1,
                Fagnavn = "Norsk",
                Emnekode = "1010",
                Semester = 1,
                Studiepoeng = "15",
                URL = "www.eksempel.no",
                URL2 = "www.eksempel2.no",
                URL3 = "www.eksempel3.no",
            };

            var mulighet2 = new Muligheter
            {
                Id = 2,
                KlasseId = 2,
                MasterFagId = 2,
                Fagnavn = "Engelsk",
                Emnekode = "2020",
                Semester = 2,
                Studiepoeng = "15",
                URL = "www.eksempel4.no",
                URL2 = "www.eksempel5.no",
                URL3 = "www.eksempel6.no",
            };
       
            var muligheterList = new List<Muligheter>();
            muligheterList.Add(mulighet1);
            muligheterList.Add(mulighet2);
 
            var mock = new Mock<IMuligheterRepository>();
            mock.Setup(k => k.GetMuligheter()).ReturnsAsync(muligheterList);
            var muligheterController = new MuligheterController(mock.Object);
            List<Muligheter> resultat = await muligheterController.GetMuligheter();
            Assert.Equal<List<Muligheter>>(muligheterList, resultat);
        }

        [Fact]
        public async Task GetMuligheterIKKEOK()
        {
            var muligheterList = new List<Muligheter>();

            var mock = new Mock<IMuligheterRepository>();
            mock.Setup(k => k.GetMuligheter()).ReturnsAsync(() => null);
            var muligheterController = new MuligheterController(mock.Object);
            List<Muligheter> resultat = await muligheterController.GetMuligheter();
            Assert.Null(resultat);
        }

        [Fact]
        public async Task GetEnMulighetOK()
        {
            var returnMulighet = new Muligheter
            {
                Id = 1,
                KlasseId = 1,
                MasterFagId = 1,
                Fagnavn = "Norsk",
                Emnekode = "1010",
                Semester = 1,
                Studiepoeng = "15",
                URL = "www.eksempel.no",
                URL2 = "www.eksempel2.no",
                URL3 = "www.eksempel3.no",
            };
            var mock = new Mock<IMuligheterRepository>();
            mock.Setup(k => k.GetMuligheter(1)).ReturnsAsync(returnMulighet);
            var muligheterController = new MuligheterController(mock.Object);
            Muligheter resultat = await muligheterController.GetMuligheter(1);
            Assert.Equal<Muligheter>(returnMulighet, resultat);
        }

        [Fact]
        public async Task GetEnMulighetIKKEOK()
        {
            var mock = new Mock<IMuligheterRepository>();
            mock.Setup(k => k.GetMuligheter(1)).ReturnsAsync(() => null);
            var muligheterController = new MuligheterController(mock.Object);
            Muligheter resultat = await muligheterController.GetMuligheter(1);
            Assert.Null(resultat);
        }
    }
}
