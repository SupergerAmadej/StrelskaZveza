using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass,TestCategory("testiranje kluba")]
    public class KlubTest
    {
        static ServiceReferenceSZ.Klub klub;
        static ServiceReferenceSZ.StrelskaZvezaClient client;

        [ClassInitialize]
        public static void klubTest(TestContext testContext)
        {
            client = new ServiceReferenceSZ.StrelskaZvezaClient();
        }

        [TestInitialize]
        public void Init()
        {
            ServiceReferenceSZ.Klub klub1 = new ServiceReferenceSZ.Klub()
            {
                Naziv = "testKlub",
                Naslov = "testnaslov",
                LetoUstanovitve = 2004
            };

            klub = klub1;
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (klub != null)
            {
                client.DeleteKlub(klub.KlubID.ToString());
                klub = null;
            }
        }

        [TestMethod]
        public void dodajKlub()
        {
            int prej = client.ReturnKlubi().Count();
            client.AddKlub(klub, out int id);
            int potem = client.ReturnKlubi().Count();

            Assert.IsTrue(prej < potem);

            var asd = client.ReturnKlubi().SingleOrDefault(a => a.KlubID == id);

            Assert.IsNotNull(asd);

        }

        [TestMethod]
        public void OdstraniKlub()
        {
            client.AddKlub(klub, out int id);
            int prej = client.ReturnKlubi().Count();
            client.DeleteKlub(id.ToString());
            int potem = client.ReturnKlubi().Count();

            Assert.IsTrue(prej > potem);

            var asd = client.ReturnKlubi().SingleOrDefault(a => a.KlubID == id);

            Assert.IsNull(asd);

            klub = null;
        }
    }

    [TestClass,TestCategory("testiranje strelca")]
    public class StrelecTest
    {
        static ServiceReferenceSZ.StrelskaZvezaClient client; 
        static ServiceReferenceSZ.Strelec expectedStrelec; 

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            client = new ServiceReferenceSZ.StrelskaZvezaClient();
        }

        [TestInitialize]
        public void testSetup()
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
            client.DeleteStrelec(expectedStrelec.StrelecID.ToString());
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

        [TestMethod]
        public void OdstraniStrelca()
        {
            client.AddStrelec(expectedStrelec, out int id);
            expectedStrelec.StrelecID = id;

            client.DeleteStrelec(expectedStrelec.StrelecID.ToString());

            var strelec = client.ReturnStrelci().SingleOrDefault(a => a.StrelecID == id);

            Assert.IsNull(strelec);
        }
    }

    [TestClass,TestCategory("testiranje vmesne table")]
    public class Vmesna
    {
        static ServiceReferenceSZ.StrelskaZvezaClient client;
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
           client = new ServiceReferenceSZ.StrelskaZvezaClient();
        }

        static ServiceReferenceSZ.Strelec Strelec;
        static ServiceReferenceSZ.Klub Klub;
        static string svk;

        [TestInitialize]
        public void testinit()
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

            string klubNaziv = "pohorje test";
            string klubNaslov = "nek naslov";
            int klubLetoUstanovitve = 2004;

            ServiceReferenceSZ.Klub klub = new ServiceReferenceSZ.Klub()
            {
                Naziv = klubNaziv,
                Naslov = klubNaslov,
                LetoUstanovitve = klubLetoUstanovitve
            };


            client.AddStrelec(strelec, out int sid);
            strelec.StrelecID = sid;
            client.AddKlub(klub, out int kid);
            klub.KlubID = kid;

            Strelec = strelec;
            Klub = klub;
        }

        [TestCleanup]
        public void testCleanup()
        {
            //if (svk != null)
            //    client.DeleteSVK(svk);
            //if(klub != null)
            //    client.
        }

        [TestMethod]
        public void UstvariPovezavo()
        {

            int povezaveThen = client.ReturnStrelecVKlubus().Select(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == Strelec.StrelecID).Count();
            client.DodajStrelcaVklub(Strelec, Klub.KlubID.ToString(),out int id);
            int povezaveNow = client.ReturnStrelecVKlubus().Select(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == Strelec.StrelecID).Count();

            Assert.IsTrue(povezaveNow == povezaveThen + 1);

            var pov = client.ReturnStrelecVKlubus().SingleOrDefault(a => a.StrelecKlubID == id);

            Assert.IsNotNull(pov);

            svk = pov.StrelecKlubID.ToString();
        }

        [TestMethod]
        public void OdstraniPovezavo()
        {
            client.DodajStrelcaVklub(Strelec, Klub.KlubID.ToString(),out int id);
            int povezaveThen = client.ReturnStrelecVKlubus().Select(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == Strelec.StrelecID).Count();
            client.DeleteSVK(id.ToString());
            int povezaveNow = client.ReturnStrelecVKlubus().Select(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == Strelec.StrelecID).Count();

            Assert.IsTrue(povezaveNow == povezaveThen - 1);

            var pov = client.ReturnStrelecVKlubus().SingleOrDefault(a => a.StrelecKlubID == id);

            Assert.IsNull(pov);

            svk = null;
        }

        [TestMethod,TestCategory("poljuben test, ki testira ce se zbirsejo res use vmesne povezave ko zbirsemo eno od entitet")]
        public void brisanjeVsehVmesnihPovezavKoZbrisemoEnoOdEntitet()
        {
            client.DodajStrelcaVklub(Strelec, Klub.KlubID.ToString(), out int id1);
            client.DodajStrelcaVklub(Strelec, Klub.KlubID.ToString(), out int id2);
            client.DodajStrelcaVklub(Strelec, Klub.KlubID.ToString(), out int id3);

            int povezaveThen = client.ReturnStrelecVKlubus().Where(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == Strelec.StrelecID).Count();
            string id = Strelec.StrelecID.ToString();
            client.DeleteStrelec(id);
            int povezaveNow = client.ReturnStrelecVKlubus().Where(a => a.Klub.KlubID == Klub.KlubID && a.Strelec.StrelecID == int.Parse(id)).Count();

            Assert.IsTrue(povezaveThen > 0 && povezaveNow == 0);
        }

    }

    //[TestClass, TestCategory("nebo delal")]
    //public class NeDela
    //{
    //    [TestMethod, TestCategory("nebo delal ker nedela")]
    //    public void nedela()
    //    {
    //        Assert.IsTrue(false); // poljuben test :)
    //    }
    //}
}
