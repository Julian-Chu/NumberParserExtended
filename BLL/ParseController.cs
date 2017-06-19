using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ParseController
    {
        public List<char> ParseNumberFrom2DCharList(List<List<char>> chars)
        {
            var result = new List<char>();
            int row = 0;
            int col = 0;
            int maxRows = chars.Count;

            var targetChars = new List<char>() { '|', '-' };

            while (row < maxRows)
            {
                if (targetChars.Contains(chars[row][col]))
                {
                    List<char> features = GetFeatures(chars, row, col);

                    char number = GetNumberByFeatures(features);
                    col += GetWidth(number);

                    result.Add(number);
                }
                else if (chars[row][col] == '\n')
                {
                    row += 4;
                }
                else
                {
                    col++;
                }
            }

            return result;
        }

        private int GetWidth(char number)
        {
            switch (number)
            {
                case '3':
                case '2':
                    return 3; //width of number : 3 chars
                case '1':
                    return 1;
                case '4':
                    return 5;
                default:
                    return 1000; // warning for unknown number
            }
        }

        private List<char> GetFeatures(List<List<char>> chars, int row, int col)
        {
            var features = new List<char>();
            features.Add(chars[row][col]);
            features.Add(chars[row + 1][col]);
            features.Add(chars[row + 2][col]);
            features.Add(chars[row + 3][col]);
            return features;
        }

        private char GetNumberByFeatures(List<char> features)
        {
            if (features.SequenceEqual(new List<char>() { '-',
                                                          ' ',
                                                          ' ',
                                                          '-' }))
            {
                return '3';
            }
            else if (features.SequenceEqual(new List<char> { '-',
                                                             ' ',
                                                             '|',
                                                             '-' }))
            {
                return '2';
            }
            else if (features.SequenceEqual(new List<char> { '|',
                                                             '|',
                                                             '|',
                                                             '|' }))
            {
                return '1';
            }
            else if (features.SequenceEqual(new List<char> { '|',
                                                             '|',
                                                             ' ',
                                                             ' ' }))
            {
                return '4';
            }
            else
            {
                return '*';
            }
        }
    }
}