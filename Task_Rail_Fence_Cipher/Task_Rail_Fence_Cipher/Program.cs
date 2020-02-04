using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Rail_Fence_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create message
            string message = "WEAREDISCOVEREDFLEEATONCE";

            int rails = 7;
            Console.WriteLine($"rails: {rails}");
            //Encode
            string encode1 = RailFenceCipher.RailFenceEncode("WEAREDISCOVEREDFLEEATONCE", rails);
            string encode2 = RailFenceCipher.Encode("WEAREDISCOVEREDFLEEATONCE", rails);
            //Decode
            string decode1 = RailFenceCipher.RailFenceDecode(encode1, rails);
            string decode2 = RailFenceCipher.Decode(encode2, rails);

            //Representation
            Console.WriteLine($"message: {message}");
            Console.WriteLine("=====================================");
            Console.WriteLine($"encode 1:\n{encode1}");
            Console.WriteLine($"decode 1:\n{decode1}");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine($"encode 2:\n{encode2}");
            Console.WriteLine($"decode 2:\n{decode2}");
            Console.WriteLine("=====================================");


            Console.ReadLine();
        }
    }
}
