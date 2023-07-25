using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    class rs
    {

        public static string Reverse(string Input)
        {

            // Converting string to character array
            char[] charArray = Input.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;
        }

        // Driver code
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("pradeepsekar"));
        }
    }
}
