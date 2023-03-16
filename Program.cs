using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<Vizibicikli> Vizi_List = new List<Vizibicikli>();
        static void Main(string[] args)
        {
            Feladat3Beolvasas(); Console.WriteLine("\n----------------------------\n");
        }

        private static void Feladat3Beolvasas()
        {
            Console.WriteLine("3.feladat: Beolvasás");
            var sr = new StreamReader(@"kolcsonzesek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Vizi_List.Add(new Vizibicikli(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}