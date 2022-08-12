using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringreverse
{
     class string_reverse
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
       
            for(int i=0; i< words.Length;i++)
            { string word = words[i];
                string rev = "";
                for (int j = 0; j < word.Length;j++)
                {
                    rev = word[j] + rev;
                }
                Console.Write(rev +" ");

            }
        }
    }
}
