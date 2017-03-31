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
                string userText  = Console.ReadLine();
                var Characters = userText.ToCharArray();

                string output = "";

                for (int i = 0; i < Characters.Length; i++)
                {
                    char character = Characters[i];

                    character = (char)(character + kripKey);
                    
                    if (character > 'Z')
                        character = (char)(character - 26);

                    else if (character < 'A')
                        character = (char)(character + 26);

                    output += character;
                }  

                Console.WriteLine(output);

                Console.ReadKey();
            }
            
        }

       
    }
}
