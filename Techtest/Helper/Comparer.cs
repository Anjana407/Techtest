using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techtest.Helper
{
   
        public class CustomComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
             var str1 = x.ToCharArray();
             var str2 = y.ToCharArray();
             Array.Sort(str1);
             Array.Sort(str2);
             int minSize = Math.Min(str1.Length, str2.Length);
             for (int i = 0; i < minSize; i++)
             {
                if (str1[i] == str2[i])
                    continue;
                else if (str1[i] > str2[i])
                    return 1;
                else
                    return -1;
             }
             return 0;
        }
        }
   
}
