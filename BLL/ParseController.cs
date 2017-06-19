using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ParseController
    {
        public List<char> ParseNumberFrom2DCharList(List<List<char>> chars)
        {
            if (chars.Count == 1)
            {
                return new List<char>() { 'E', 'r', 'r', 'o', 'r' };
            }
            var result = new List<char>();
            int row = 0;
            int col = 0;
            int maxRows = chars.Count;

            var targetChars = new List<char>() { '|', '-' };

            while (row < maxRows)
            {
                if (targetChars.Contains(chars[row][col]))
                {
                    List<char> feature = GetFeature(chars, row, col);

                    char number = GetNumberByFeatures(feature);
                    col += GetWidth(number);

                    result.Add(number);
                }
                else if (chars[row][col] == '\n')
                {
                    row += 4;
                    col = 0;
                    result.Add('\r');
                    result.Add('\n');
                }
                else
                {
                    col++;
                }
            }

            result.RemoveRange(result.Count - 2, 2);

            return result;
        }

        private int GetWidth(char number)
        {
            ///Width is how many chars in 1st row of a Number 2D char array
            ///              v---v                       v-v
            ///Ex: Width of  |   |  is 5 ,     Width of  --- is 3
            ///              |___|                        /         
            ///                  |                        \        
            ///                  |                       --
            switch (number)
            {
                case '3':
                case '2':
                    return 3; //width of number : 3 chars
                case '1':
                    return 1;
                case '4':
                case '5':
                    return 5;
                default:
                    return 1000; // warning for unknown number
            }
        }

        private List<char> GetFeature(List<List<char>> chars, int row, int col)
        {
            ///feature is chars in 1st column of a Number 2D char array
            ///Ex: features of  |   |  are  '|' ,  features of  ---   are '-'
            ///                 |___|       '|'                  /        ' '
            ///                     |       ' '                  \        ' '
            ///                     |       ' '                 --        '-'
            var feature = new List<char>();
            feature.Add(chars[row][col]);
            feature.Add(chars[row + 1][col]);
            feature.Add(chars[row + 2][col]);
            feature.Add(chars[row + 3][col]);
            return feature;
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
            else if (features.SequenceEqual(new List<char> { '-',
                                                             '|',
                                                             ' ',
                                                             '_' }))
            {
                return '5';
            }
            else
            {
                return '*';
            }
        }
    }
}