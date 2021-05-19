using System;
using Xunit;
using System.Threading.Tasks;
using System.Collections.Generic;
using oslometAPI.Models;
using Moq;
using oslometAPI.Data;
using oslometAPI.Controllers;
using System.Linq;

namespace oslometAPITest
{

    public class MasterFagControllerTest
    {
        [Fact]
        public async Task GetMasterFagOK()
        {

            var masterFag1 = new MasterFag
            {
                Id = 1,
                Fagnavn = "Norsk",
                KlasseId = 4,
            };
            var masterFag2 = new MasterFag
            {
                Id = 2,
                Fagnavn = "Engelsk",
                KlasseId = 2,
            };
            var masterFag3 = new MasterFag
            {
                Id = 3,
                Fagnavn = "Spesialpedagogikk",
                KlasseId = 5,
            };

            var masterFagList = new List<MasterFag>();
            masterFagList.Add(masterFag1);
            masterFagList.Add(masterFag2);
            masterFagList.Add(masterFag3);

            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFag()).ReturnsAsync(masterFagList);
            var masterFagController = new MasterFagController(mock.Object);
            List<MasterFag> resultat = await masterFagController.GetMasterFag();
            Assert.Equal<List<MasterFag>>(masterFagList, resultat);
        }

        [Fact]
        public async Task GetMasterFagIKKEOK()
        {
            var masterFagList = new List<MasterFag>();

            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFag()).ReturnsAsync(() => null);
            var masterFagController = new MasterFagController(mock.Object);
            List<MasterFag> resultat = await masterFagController.GetMasterFag();
            Assert.Null(resultat);
        }

        [Fact]
        public async Task GetEtMasterFagOK()
        {
            var returnMasterFag = new MasterFag
            {
                Id = 1,
                Fagnavn = "Norsk",
                KlasseId = 4,
            };
            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFag(1)).ReturnsAsync(returnMasterFag);
            var masterFagController = new MasterFagController(mock.Object);
            MasterFag resultat = await masterFagController.GetMasterFag(1);
            Assert.Equal<MasterFag>(returnMasterFag, resultat);
        }

        [Fact]
        public async Task GetEtMasterFagIKKEOK()
        {
            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFag(1)).ReturnsAsync(() => null);
            var masterFagController = new MasterFagController(mock.Object);
            MasterFag resultat = await masterFagController.GetMasterFag(1);
            Assert.Null(resultat);
        }

        [Fact]
        public async Task GetMasterFagByKategoriOK()
        {
            var returnMasterFag = new MasterFag
            {
                Id = 1,
       
            };

            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFagByKategori(1)).ReturnsAsync(returnMasterFag);
            var masterFagController = new MasterFagController(mock.Object);
            MasterFag resultat = await masterFagController.GetMasterFagByKategori(1);
            Assert.Equal<MasterFag>(returnMasterFag, resultat);
        }

        [Fact]
        public async Task GetMasterFagByKategoriIKKEOK()
        {
            var mock = new Mock<IMasterFagRepository>();
            mock.Setup(k => k.GetMasterFagByKategori(1)).ReturnsAsync(() => null);
            var masterFagController = new MasterFagController(mock.Object);
            MasterFag resultat = await masterFagController.GetMasterFagByKategori(1);
            Assert.Null(resultat);
        }
    }
}
