using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public class DataFromTxt : MyDataReader
    {
        public string FilePath { get; set; }

        public DataFromTxt(string filePath)
        {
            this.FilePath = filePath;
        }

        public List<List<char>> GetData()
        {
            var result = new List<List<char>>();
            result.Add(new List<char>());

            string text = "";
            try
            {
                text = File.ReadAllText(FilePath);
                char[] chars = text.ToCharArray();

                int row = 0;
                for (int i = 0; i < chars.Length; i++)
                {
                    result[row].Add(chars[i]);
                    if (chars[i] == '\n')
                    {
                        result.Add(new List<char>());
                        row += 1;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}