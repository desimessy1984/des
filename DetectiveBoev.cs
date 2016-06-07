using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();

            int mask = 0;
            foreach (var symbol in secretWord)
            {
                mask += symbol;
            }

            while (mask > 9)
            {
                int sum = 0;
                while (mask != 0)
                {
                    int reminder = mask % 10;
                    mask = mask / 10;
                    sum = sum + reminder;
                }
                mask = sum;
            }

            char[] decryptedMessage = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] % mask == 0)
                {
                    decryptedMessage[i] = (char)(message[i] + mask);
                }
                else
                {
                    decryptedMessage[i] = (char)(message[i] - mask);
                }
            }

            Array.Reverse(decryptedMessage);

            Console.WriteLine(string.Join(string.Empty, decryptedMessage));
        }
    }
}
