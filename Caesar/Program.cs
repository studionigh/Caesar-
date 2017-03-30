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

                for (int i = 0; i < Characters.Length; i++)
                {
                    char letter = Characters[i];
                    letter = (char)(letter + kripKey);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    Console.WriteLine(letter  + kripKey);
                }
               // Console.WriteLine(Characters);
                Console.ReadKey();
            }
            
        }

       
    }
}
