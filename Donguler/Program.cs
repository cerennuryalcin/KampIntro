using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "java";

            // array = dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "programlamaya giriş",
                "java", "python" };

        
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine();
            }
           
           
            Console.WriteLine("sayfa sonu = footer");
        }
    }
}
