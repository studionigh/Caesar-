using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                //Get users input for key
                Console.Write("Enter your encription key (number)");
                string userKey = Console.ReadLine();
                int kripKey = int.Parse(userKey);

                //Get users input for text to encript
                Console.WriteLine("Enter text to be encripted");
                string userText = Console.ReadLine();
                var Characters = userText.ToCharArray();

                int key;
                string Cripto;

                for (int i = 0; i < Characters.Length; i++)
                {
                    key = Characters[i] + kripKey;
                    Cripto = (key).ToString();
                    Console.WriteLine(Cripto);
                }
               

                Console.ReadKey();
            }
            
        }

       
    }
}
