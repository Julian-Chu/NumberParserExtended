using System.Collections.Generic;

namespace BLL
{
    public class ParseController : IParseController
    {
        public List<char> ParseNumbers(List<List<char>> chars)
        {
            FeatureRecognizer recognizer = new FeatureRecognizer();

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
                    List<char> feature = recognizer.GetFeature(chars, row, col);
                    char number = recognizer.GetNumberByFeatures(feature);
                    col += recognizer.GetWidth(number);

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

    }
}