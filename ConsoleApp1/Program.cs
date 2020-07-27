using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIS_N3_WCF;
using System.Runtime.Serialization;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Program
    {
         static StrelskaZveza.StrelskaZvezaClient client = new StrelskaZveza.StrelskaZvezaClient();

        
        // ----------------------------------------------------
        public static void BrisiKlub()
        {
            Console.WriteLine();
            List<Klub> klubi = new List<Klub>();
            klubi = client.ReturnKlubi().ToList();
            Console.WriteLine("Klubi:");
            klubi.ForEach(a => {
                Console.WriteLine("- ID:{0} {1}",a.KlubID, a.Naziv);
            });
            Console.WriteLine("vpisi id kluba, ki ga zelis izbrisati, vpisi -1 da izbrises vse klube");
            string id = Console.ReadLine();
            Console.WriteLine(client.DeleteKlub(id));
        }

        public static void BrisiStrelca()
        {
            Console.WriteLine();
            List<Strelec> strelci = new List<Strelec>();
            strelci = client.ReturnStrelci().ToList();
            Console.WriteLine("Strelci:");
            strelci.ForEach(a => {
                Console.WriteLine("- {0} {1}, ID: {2}",a.Ime, a.Priimek, a.StrelecID);
            });
            Console.WriteLine("vpisi id strelca, ki ga zelis izbrisati, vpisi -1 da izbrises vse strelce");
            string id = Console.ReadLine();
            Console.WriteLine(client.DeleteStrelec(id));
        }

        public static void DodajKlub()
        {
            Console.WriteLine();
            Klub k = new Klub();
            Console.WriteLine("Vpisi naziv kluba");
            k.Naziv = Console.ReadLine();
            Console.WriteLine("vpisi naslov kluba");
            k.Naslov = Console.ReadLine();

            bool allgood = false;
            while (!allgood)
            {
                Console.WriteLine("vpisi letnico ustanovitve");
                string vnos = Console.ReadLine();
                if (int.TryParse(vnos,out int letnica))
                {
                    k.LetoUstanovitve = letnica;
                    allgood = true;
                }
                else
                    Console.WriteLine("neveljavna letnica!");
            }

            Console.WriteLine("Klub vpisan upsesno: {0}",client.AddKlub(k));
        }

        public static void DodajStrelca()
        {
            Console.WriteLine();
            Strelec s = new Strelec();
            Console.WriteLine("vpisi ime strelca");
            s.Ime = Console.ReadLine();
            Console.WriteLine("vpisi priimek strelca");
            s.Priimek = Console.ReadLine();

            bool allgood = false;
            while (!allgood)
            {
                Console.WriteLine("vpisi letnico rojstva");
                string vnos = Console.ReadLine();
                if (int.TryParse(vnos, out int letnica))
                {
                    s.LetoRojstva = letnica;
                    allgood = true;
                }
                else
                    Console.WriteLine("neveljavna letnica!");
            }




            Console.WriteLine("Strelec vpisan uspesno: {0}",client.AddStrelec(s, out int idstrelca));
            s.StrelecID = idstrelca;

            List<Klub> klubi = new List<Klub>();
            klubi = client.ReturnKlubi().ToList();
            Console.WriteLine("Klubi:");
            klubi.ForEach(a => {
                Console.WriteLine("- ID:{0} {1}", a.KlubID, a.Naziv);
            });
            Console.WriteLine("vpisi id kluba strelca");
            string kid = Console.ReadLine();

            Console.WriteLine("vpis strelca v klub: {0}", client.DodajStrelcaVklub(s, kid));

            Console.WriteLine();
            
        }

        public static void StrelciVklubu()
        {
            Console.WriteLine();
            List<Klub> klubi = new List<Klub>();
            klubi = client.ReturnKlubi().ToList();
            Console.WriteLine("Klubi:");
            klubi.ForEach(a => {
                Console.WriteLine("- ID:{0} {1}", a.KlubID, a.Naziv);
            });
            Console.WriteLine("vpisi id kluba");
            string kid = Console.ReadLine();
            List<Strelec> strelci = new List<Strelec>();
            strelci = client.StrelciInKlub(kid).ToList();
            Console.WriteLine("Strelci:");
            strelci.ForEach(a =>
            {
                Console.WriteLine(" - {0} {1}", a.Ime, a.Priimek);
            });
        }

        public static void PosodobiStrelca()
        {
            Console.WriteLine();
            List<Strelec> strelci = new List<Strelec>();
            strelci = client.ReturnStrelci().ToList();
            Console.WriteLine("Strelci:");
            strelci.ForEach(a =>
            {
                Console.WriteLine(" - ID:{2} {0} {1}", a.Ime, a.Priimek,a.StrelecID);
            });
            Console.WriteLine("vnesi id strelca, k iga zelis posodobiti");
            Strelec s = new Strelec();
            try
            {
                int id = int.Parse(Console.ReadLine());
                s.StrelecID = id;
            }
            catch (Exception)
            {
                Console.WriteLine("error .. good job.. program je crasho");
            }
            
            Console.WriteLine("vnesi ime");
            s.Ime = Console.ReadLine();
            Console.WriteLine("vnesi priimek");
            s.Priimek = Console.ReadLine();
            Console.WriteLine("vnesi letnico rojstva");
            try
            {
                s.LetoRojstva = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("error .. ura je 00:55 ne da se mi delat idiotproof tole");
            }
            Console.WriteLine("posodobitev uspesna: {0}",client.UpdateStrelec(s));
        }

        public static void PosodobiKlub()
        {
            Console.WriteLine();
            List<Klub> klubi = new List<Klub>();
            klubi = client.ReturnKlubi().ToList();
            Console.WriteLine("Klubi:");
            klubi.ForEach(a => {
                Console.WriteLine("- ID:{0} {1}", a.KlubID, a.Naziv);
            });
            Console.WriteLine("vpisi id kluba");
            Klub k = new Klub();
            try
            {
                int id = int.Parse(Console.ReadLine());
                k.KlubID = id;
            }
            catch (Exception)
            {
                Console.WriteLine("error .. pls stop ..prezgodi je za tole");
            }
            Console.WriteLine("vnesi naziv");
            k.Naziv = Console.ReadLine();
            Console.WriteLine("vnesi naslov");
            k.Naslov = Console.ReadLine();
            try
            {
                Console.WriteLine("vnesi leto ustanovitve");
                k.LetoUstanovitve = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("error.. javlar");
            }
            Console.WriteLine("posodobitev uspesna: {0}",client.UpdateKlub(k));
        }


        static void Main(string[] args)
        {


            
            while (true)
            {
                Console.WriteLine("admin: amadeus asd\npleb: lars pleb");
                Console.WriteLine();
                Console.WriteLine("vnesi uporabnisko ime:");
                string ime = Console.ReadLine();
                Console.WriteLine("vensi geslo:");
                string geslo = Console.ReadLine();

                User user = new User
                {
                    Ime = ime,
                    Geslo = geslo
                };

                bool logged = client.CheckUser(user, out bool admin);

                if (logged && admin)
                {
                    Console.WriteLine("welcome admin boi");
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 - Dodaj klub \n2 - Brisi klub \n3 - Brisi strelca \n4 - dodaj strelca \n5 - Izpisi strelce iz nekega kluba \n6 - Posodobi strelca \n7 - posodobi klub\n8 - konec");
                        Console.WriteLine();
                        Console.WriteLine("izberi st");
                        string vnos = Console.ReadLine();
                        switch (vnos)
                        {
                            case "1": DodajKlub(); break;
                            case "2": BrisiKlub(); break;
                            case "3": BrisiStrelca(); break;
                            case "4": DodajStrelca(); break;
                            case "5": StrelciVklubu(); break;
                            case "6": PosodobiStrelca(); break;
                            case "7": PosodobiKlub(); break;
                            case "8": Environment.Exit(0); break;
                            default:
                                break;
                        }
                    }
                }
                else if (logged)
                {
                    Console.WriteLine("welcome pleb");
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 - Izpisi strelce iz nekega kluba \n2 - Posodobi strelca \n3 - posodobi klub \n4 - konec");
                        Console.WriteLine();
                        Console.WriteLine("izber st");
                        string vnos = Console.ReadLine();
                        switch (vnos)
                        {
                            case "1": StrelciVklubu(); break;
                            case "2": PosodobiStrelca(); break;
                            case "3": PosodobiKlub(); break;
                            case "4": Environment.Exit(0); break;
                            default:
                                break;
                        }
                    }
                }


                //DodajKlub();
                //BrisiKlub();
                //BrisiStrelca();
                //DodajStrelca();
                //StrelciVklubu();
            }


        }
    }



}
