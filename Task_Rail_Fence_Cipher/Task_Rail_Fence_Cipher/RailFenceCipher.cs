using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Rail_Fence_Cipher
{
    public static class RailFenceCipher
    {
        public static string RailFenceEncode(string message, int numberOfRail)
        {
            if (numberOfRail >= 2)
            {
                //Create list of char's lists
                List<List<char>> rails = new List<List<char>>();

                //Initialization list rails
                for (int i = 0; i < numberOfRail; i++)
                {
                    rails.Add(new List<char>());
                }

                //Create boolean variable to select direction
                bool isIncrement = true;
                for (int i = 0, j = 0; i < message.Length; i++)
                {
                    rails[j].Add(message[i]);
                    for (int k = 0; k < numberOfRail; k++)
                    {
                        if (k != j) rails[k].Add(' ');
                    }

                    //Changing direction
                    if (isIncrement) j++;
                    else j--;

                    if (j >= numberOfRail - 1 || j <= 0)
                    {
                        isIncrement = !isIncrement;
                    }
                }

                //Create string for result
                string result = "";
                for (int i = 0; i < rails.Count; i++)
                {
                    string rail = new string(rails[i].ToArray());
                    result += rail + "\n";
                }
                return result;
            }
            else return string.Empty;
        }

        public static string RailFenceDecode(string encodedString, int numberOfRail)
        {
            if (numberOfRail >= 2)
            {
                //Create list of char's lists
                List<string> rails = new List<string>();

                //Initialization list rails
                rails = encodedString.Split('\n').ToList();

                //Create boolean variable to select direction
                bool isIncrement = true;
                //Get count of decoded message
                int count = encodedString.ToArray().Where(symbol => symbol != ' ' && symbol != '\n').Count();
                //Create list for result
                List<char> message = new List<char>();
                for (int i = 0, j = 0; i < count; i++)
                {
                    //filling list
                    message.Add(rails[j][i]);

                    //Changing direction
                    if (isIncrement) j++;
                    else j--;
                    if (j >= numberOfRail - 1 || j <= 0)
                    {
                        isIncrement = !isIncrement;
                    }
                }

                return new string(message.ToArray());
            }
            else return string.Empty;
        }

        public static string Encode(string railFenceString, int numberOfRail)
        {
            if (numberOfRail >= 2)
            {
                return new string(RailFenceEncode(railFenceString, numberOfRail)
                .ToArray()
                .Where(symbol => symbol != ' ' && symbol != '\n')
                .ToArray());
            }
            else return string.Empty;
        }

        public static string Decode(string encodedString, int numberOfRail)
        {
            if (numberOfRail >= 2)
            {
                //Create boolean variable to select direction
                bool isIncrement = true;
                //Create list of char's lists
                List<List<char>> rails = new List<List<char>>();

                //Initialization list rails
                for (int i = 0; i < numberOfRail; i++)
                {
                    rails.Add(new List<char>());
                }

                //Create array for counter
                int[] arrayCounter = new int[numberOfRail];
                for (int i = 0, j = 0; i < encodedString.Length; i++)
                {
                    //Console.WriteLine(j);
                    for (int k = 0; k < numberOfRail; k++)
                    {
                        if (k == j) arrayCounter[k]++;
                    }
                    //Changing direction
                    if (isIncrement) j++;
                    else j--;
                    if (j >= numberOfRail - 1 || j <= 0)
                    {
                        isIncrement = !isIncrement;
                    }
                }

                //Geting all rails
                for (int i = 0, j = 0, k = 0; i < encodedString.Length && j < arrayCounter.Length; i++, k++)
                {
                    if (arrayCounter[j] == k)
                    {
                        j++;
                        k = 0;
                    }
                    rails[j].Add(encodedString[i]);
                }

                //boolean variable to select direction
                isIncrement = true;
                //Create result list of char
                List<char> message = new List<char>();
                //Create rails counter
                int[] counter = new int[numberOfRail];
                for (int i = 0, j = 0; i < encodedString.Length; i++)
                {
                    //filling list
                    message.Add(rails[j][counter[j]]);
                    //counter
                    counter[j]++;
                    //Changing direction
                    if (isIncrement) j++;
                    else j--;
                    if (j >= numberOfRail - 1 || j <= 0)
                    {
                        isIncrement = !isIncrement;
                    }
                }
                //Console.WriteLine(counter[0]);

                return new string(message.ToArray());
            }
            else return string.Empty;
        }
    }
}