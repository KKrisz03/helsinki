using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki
{
    class Program
    {
        private static List<szemely> adatok = new List<szemely>();
        static void Main(string[] args)
        {
            feladat_02();
            feladat_03();
            feladat_04();
            feladat_05();
            //feladat_06(); ezen a feladaton még gondolkodom.
            feladat_07();
            feladat_08();
            Console.ReadKey();
        }

        private static void feladat_08()
        {
            Console.WriteLine("8. feladat");
            int max = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Sp_szam > max)
                    max = adatok[i].Sp_szam;
            }
            for (int i = 0; i < adatok.Count; i++)
            {
                if(adatok[i].Sp_szam == max)
                {
                    Console.WriteLine($"Helyezés: {adatok[i].Helyezes}");
                    Console.WriteLine($"Sportág: {adatok[i].Sportag}");
                    Console.WriteLine($"Versenyszám: {adatok[i].Versenyszam}");
                    Console.WriteLine($"Sportolók száma: {adatok[i].Sp_szam}");
                }
            }
        }

        private static void feladat_07()
        {
            StreamWriter sw = new StreamWriter("helsinki2.txt",false);
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Sportag == "kajakkenu")
                    sw.WriteLine(adatok[i].Helyezes + " " + adatok[i].Sp_szam + " " + adatok[i].Sportag.Replace("kajakkenu", "kajak-kenu") + " " + adatok[i].Versenyszam);
                else
                    sw.WriteLine(adatok[i].Helyezes + " " + adatok[i].Sp_szam + " " + adatok[i].Sportag + " " + adatok[i].Versenyszam);
            }
            sw.Close();
        }

        private static void feladat_06()
        {
            List<string> sportagak = new List<string>();
            int db = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if(adatok[i].Sportag == sportagak[db])
                {

                }
                sportagak[db] = adatok[i].Sportag;
            }
        }

        private static void feladat_05()
        {
            Console.WriteLine("5. feladat");
            int pont=0,ossz=0;
            for(int i=0;i<adatok.Count;i++)
            {
                if(adatok[i].Helyezes == 1)
                {
                    pont = 7;
                    ossz += pont;
                }
                if (adatok[i].Helyezes == 2)
                {
                    pont = 5;
                    ossz += pont;
                }
                if (adatok[i].Helyezes == 3)
                {
                    pont = 4;
                    ossz += pont;
                }
                if (adatok[i].Helyezes == 4)
                {
                    pont = 3;
                    ossz += pont;
                }
                if (adatok[i].Helyezes == 5)
                {
                    pont = 2;
                    ossz += pont;
                }
                if (adatok[i].Helyezes == 6)
                {
                    pont = 1;
                    ossz += pont;
                }
            }
            Console.WriteLine($"Olimpiai pontok száma: {ossz}");
        }

        private static void feladat_04()
        {
            Console.WriteLine("4. feladat");
            int db = 0,db2=0,db3=0;
            for(int i=0;i<adatok.Count;i++)
            {
                if(adatok[i].Helyezes == 1)
                    db++;
                if (adatok[i].Helyezes == 2)
                    db2++;
                if (adatok[i].Helyezes == 3)
                    db3++;
            }
            Console.WriteLine($"Arany: {db}");
            Console.WriteLine($"Ezüst: {db2}");
            Console.WriteLine($"Bronz: {db3}");
            Console.WriteLine($"Összesen:{db+db2+db3}");
        }
        private static void feladat_03()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine($"Pontszerző helyezések száma:{adatok.Count}");
        }

        private static void feladat_02()
        {
            StreamReader sr = new StreamReader("helsinki.txt");
            while(!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(' ');
                adatok.Add(new szemely(int.Parse(temp[0]),int.Parse(temp[1]),temp[2],temp[3]));
            }
        }
    }
}
