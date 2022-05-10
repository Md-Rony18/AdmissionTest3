using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class VowelCounter
    {
        bool isVowel(Char ch)
        {
            ch=char.ToUpper(ch);
            return (ch =='A' || ch =='E' || ch =='I' || ch == 'O' || ch=='U')
        }
    int CountVowels(string str)
    {
      int count = 0;
      
      for (int i = 0; i < str.Length; i++)
        {
        if (isVowel(str[i]))
            {
            count++;
            }
        }
      return count;
    } 

        public string GetCounts(string text)
        {
            
        }
    }
}
