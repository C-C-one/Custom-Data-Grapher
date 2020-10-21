using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adress_book
{
    class SortString
    {
        static void Main1(string[] args)
        {
            string mystr = "HELLO";
            char temp;
            string str = mystr.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 0; i < charstr.Length; i++)
            {

                for (int j = 0; j< charstr.Length-1; j++)
                {
                    if (charstr[j]> charstr[j+1])
                    {
                        temp = charstr[j];

                    }
                }
            }

        }
    }
}
