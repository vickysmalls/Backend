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

    public class KlasserControllerTest
    {
        [Fact]
        public async Task GetKlasserOK()
        {

            var klasse1 = new Klasser
            {
                Id = 1,
                Klassetrinn = "1-7",
            };
            var klasse2 = new Klasser
            {
                Id = 2,
                Klassetrinn = "1-7",
            };
            var klasse3 = new Klasser
            {
                Id = 3,
                Klassetrinn = "5-7",
            };

            var klasseList = new List<Klasser>();
            klasseList.Add(klasse1);
            klasseList.Add(klasse2);
            klasseList.Add(klasse3);



            var mock = new Mock<IKlasserRepository>();
            mock.Setup(k => k.GetKlasser()).ReturnsAsync(klasseList);
            var klasserController = new KlasserController(mock.Object);
            List<Klasser> resultat = await klasserController.GetKlasser();
            Assert.Equal<List<Klasser>>(klasseList, resultat);
        }

        [Fact]
        public async Task GetKlasserIKKEOK()
        {
            var klasseList = new List<Klasser>();

            var mock = new Mock<IKlasserRepository>();
            mock.Setup(k => k.GetKlasser()).ReturnsAsync(() => null); 
            var klasserController = new KlasserController(mock.Object);
            List<Klasser> resultat = await klasserController.GetKlasser();
            Assert.Null(resultat);
        }

        [Fact]
        public async Task GetEnKlasseOK()
        {
            var returnKlasse = new Klasser
            {
                Id = 1,
                Klassetrinn = "1-7",
            };
            var mock = new Mock<IKlasserRepository>();
            mock.Setup(k => k.GetKlasser(1)).ReturnsAsync(returnKlasse);
            var klasserController = new KlasserController(mock.Object);
            Klasser resultat = await klasserController.GetKlasser(1);
            Assert.Equal<Klasser>(returnKlasse, resultat);
        }

        [Fact]
        public async Task GetEnKlasseIKKEOK()
        {
            var mock = new Mock<IKlasserRepository>();
            mock.Setup(k => k.GetKlasser(1)).ReturnsAsync(() => null);
            var klasserController = new KlasserController(mock.Object);
            Klasser resultat = await klasserController.GetKlasser(1);
            Assert.Null(resultat);
        }
    }
}
