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
                    var features = new List<char>();
                    features.Add(chars[row][col]);
                    features.Add(chars[row + 1][col]);
                    features.Add(chars[row + 2][col]);
                    features.Add(chars[row + 3][col]);

                    if (features.SequenceEqual(new List<char>() { '-', ' ', ' ', '-' }))
                    {
                        char number = '3';
                        result.Add(number);
                        col += 3;  //number width : 3 chars
                    }
                    else if (features.SequenceEqual(new List<char> { '-', ' ', '|', '-' }))
                    {
                        char number = '2';
                        result.Add(number);
                        col += 3;
                    }

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
    }
}
