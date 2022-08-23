using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequency Counter using Hash Table ");

            UC1_FrequencyInLine line = new UC1_FrequencyInLine();
            line.freqPerWord();

            UC2_FrequencyInLargeParagraph paragraph = new UC2_FrequencyInLargeParagraph();
            paragraph.frequency();

            UC3_RemoveWord delete = new UC3_RemoveWord();
            delete.removeWord("avoidable");

            Console.ReadKey();


        }

    }
}

