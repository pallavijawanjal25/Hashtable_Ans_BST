﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    class UC1_FrequencyInLine
    {
        private const string V = " ";

        public void freqPerWord()
        {
            string str = "To be or not to be";
            string[] arr = str.Split();
            int size = arr.Length;
            MyMapNode<string, string> hash = new MyMapNode<string, string>(size - 1);


            foreach (var s in arr)
            {

                if (hash.Get(s) != null)
                {
                    int k = Convert.ToInt32(hash.Get(s));
                    k++;
                    hash.Remove(s);
                    hash.Add(s, k.ToString());

                }
                else
                {
                    hash.Add(s, "1");

                }

            }


            printValues(arr, size, hash);

        }

        private static void printValues(string[] arr, int size, MyMapNode<string, string> hash)
        {
            Console.WriteLine("Frequency    Word");
            for (int i = 0; i < size; i++)
            {
                string result = "  " + hash.Get(arr[i]) + "          " + arr[i];
                int j;
                for (j = 0; j < i; j++)
                    if (arr[i] == arr[j])
                        break;
                if (i == j)
                    Console.Write("{0}\n", result);
            }
        }
    }
}
