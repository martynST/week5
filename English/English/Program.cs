using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class Program
    {
        static void Main(string[] args)
        {
            English e = new English();
            int numOfWords = e.words("I am in QA");
            Console.WriteLine(numOfWords);
            int occurrences = e.find("I am, going, am To london", "am");
            Console.WriteLine(occurrences);
            e.verticalSentence("I am going to QA");
            e.reverseVerticalSentence("I am going to QA");
            Console.Read();
        }
    }
    class English
    {
        public int words(String na)
        {
            return na.Split(' ').Length;
        }
        public int find(String message, String findWhat)
        {
            int occurrences = 0;
            for (int i = 0; i <= message.Length - findWhat.Length; i++)
            {
                if (message.Substring(i, findWhat.Length) == findWhat)
                {
                    occurrences++;
                }
            }
            return occurrences;
        }

        public void verticalSentence(String message)
        {
            int index = 0;
            int length = 0;
            while(true)
            {
                length = message.IndexOf(" ", index) - index;
                if (length > 0) {
                    Console.WriteLine(message.Substring(index, length));
                    index = message.IndexOf(" ", index) + 1;                    
                } else
                {
                    break;
                }
            }
            Console.WriteLine(message.Substring(message.LastIndexOf(" ")+1));
        }
        public void reverseVerticalSentence(String message)
        {
            int index = message.Length;
            int length = 0;
            
            while (true)
            {
                length = index - message.LastIndexOf(" ", index) - 1;
                if (length > 0)
                {
                    Console.WriteLine(message.Substring(index-length, length));
                    index = message.LastIndexOf(" ", index);

                }
                else
                {
                    break;
                }
            }
        }
    }
    
}