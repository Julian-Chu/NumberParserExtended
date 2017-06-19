using System.Collections.Generic;

namespace BLL
{
    public interface IParseController
    {
        List<char> ParseNumbers(List<List<char>> chars);
    }
}
