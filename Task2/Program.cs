// See https://aka.ms/new-console-template for more information
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
  
  Console.WriteLine("input String: ");
  string str=Console.ReadLine();
  Console.WriteLine(CountVowels(str);