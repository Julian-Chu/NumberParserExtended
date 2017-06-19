using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    internal class FeatureRecognizer
    {
        public int GetWidth(char number)
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

        public List<char> GetFeature(List<List<char>> chars, int row, int col)
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

        public char GetNumberByFeatures(List<char> features)
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
