using System;
using DAL;

namespace NumberParserExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader reader = new DataReader(@"c:\users\yulan\documents\visual studio 2015\Projects\NumberParserExtended\DAL\NumberParserExtended_Simplified.txt");
            var result = reader.GetData();

            foreach (var row in result)
            {
                foreach (var ch in row)
                {
                    Console.Write(ch);
                }
            }

            Console.ReadKey();

        }
    }
}
