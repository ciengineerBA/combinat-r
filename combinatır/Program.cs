using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace combinatır
{
    class Program
    {
        static void Main(string[] args)
        {
            combinator();
            yaz();
        }

       public static string[] Isaretler = { "+", "-" };
       public static string[] SabıtYuk = { "G", "Q" };
       public static string[] DepremYuk = { "Ex", "Ey" };
       public static string[] Katsayı = { "1", "0.3" };
       public static List<string> combins = new List<string>();


        static  void combinator()

        {

          
            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j  = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        combins.Add(SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] +"+"+ Katsayı[k] + "*" + DepremYuk[j]);
                    }
                    
                }
            }

            for (int i = 0; i < combins.Count; i++)
            {
                Console.WriteLine(combins[i]);
            }
            Console.WriteLine(combins[0]);
            Console.ReadKey();
        }

        static void yaz()
        {
            System.IO.TextWriter writeFile = new StreamWriter("c:\\textwriter.txt");
            writeFile.WriteLine("asd");
            writeFile.Flush();
          // writeFile.Close();
        }
        


    }
}
