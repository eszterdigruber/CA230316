using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<Vizibicikli> Vizi_List = new List<Vizibicikli>();
        static void Main(string[] args)
        {
            Feladat4Beolvasas(); Console.WriteLine("\n----------------------------\n");
            Feladat5(); Console.WriteLine("\n----------------------------\n");
            Feladat6(); Console.WriteLine("\n----------------------------\n");
            Feladat7(); Console.WriteLine("\n----------------------------\n");
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.feladat: Bekérés");
            Console.Write("Kérem adjon meg egy időpontot (óra:perc): ");
            string BekertIdo = Console.ReadLine();
            var reszek = BekertIdo.Split(':');
            int Ora = int.Parse(reszek[0]) * 60;
            int Perc = int.Parse(reszek[1]) * 60;
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.feladat: Bekérés + keresés");
            Console.Write("Kérem adjon meg egy nevet: ");
            string KeresNev = Console.ReadLine();
            int db = 0;
            foreach (var v in Vizi_List)
            {
                if (KeresNev == v.Nev)
                {
                    db++;
                    Console.WriteLine($"{v.Eora}:{v.Eperc} - {v.Vora}:{v.Vperc}");
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző.");
            }
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.feladat: Adatok száma");
            Console.WriteLine($"Letárolt adatok száma: {Vizi_List.Count}");
        }

        private static void Feladat4Beolvasas()
        {
            Console.WriteLine("4.feladat: Beolvasás");
            var sr = new StreamReader(@"kolcsonzesek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Vizi_List.Add(new Vizibicikli(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}