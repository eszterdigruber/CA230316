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