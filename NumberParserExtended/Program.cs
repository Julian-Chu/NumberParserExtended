using System;
using System.Collections.Generic;
using BLL;
using DAL;

namespace NumberParserExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\users\yulan\documents\visual studio 2015\Projects\NumberParserExtended\DAL\NumberParserExtended_Simplified.txt";
            ShowDataFromTxt(filePath);
            Console.WriteLine();

            var result = GetParsedResult(filePath);
            foreach (var ch in result)
            {
                Console.Write(ch);
            }

            Console.ReadKey();
        }

        private static List<char> GetParsedResult(string filePath)
        {
            MyDataReader reader = new DataFromTxt(filePath);
            var data = reader.GetData();

            ParseController controller = new ParseController();
            var result = controller.ParseNumberFrom2DCharList(data);

            return result;
        }

        private static void ShowDataFromTxt(string filePath)
        {
            MyDataReader reader = new DataFromTxt(filePath);
            var data = reader.GetData();

            foreach (var row in data)
            {
                foreach (var ch in row)
                {
                    Console.Write(ch);
                }
            }

        }
    }
}
