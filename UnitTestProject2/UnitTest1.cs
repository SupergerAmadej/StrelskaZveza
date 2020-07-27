using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestClass]
    public class DodajanjePrimerkov
    {
        static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        static ServiceReferenceSZ.Strelec expectedStrelec;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            string strelecIme = "Testboi";
            string strelecPriimek = "TestPrimek";
            int strelecLetoRojstva = 1999;

            ServiceReferenceSZ.Strelec strelec = new ServiceReferenceSZ.Strelec()
            {
                Ime = strelecIme,
                Priimek = strelecPriimek,
                LetoRojstva = strelecLetoRojstva
            };

            expectedStrelec = strelec;
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

        [TestMethod]
        public void DodajStrelec()
        {
            client.AddStrelec(expectedStrelec, out int id);
            expectedStrelec.StrelecID = id;

            var strelci = client.ReturnStrelci();

            var strelecASD = strelci.SingleOrDefault(a => a.StrelecID == expectedStrelec.StrelecID);

            Assert.AreEqual(expectedStrelec.Ime, strelecASD.Ime);
            Assert.AreEqual(expectedStrelec.Priimek, strelecASD.Priimek);
            Assert.AreEqual(expectedStrelec.LetoRojstva, strelecASD.LetoRojstva);
        }
    }
}
