using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    [TestClass()]
    public class ParseControllerTests
    {
        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_3_Return_3()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-', '-', '\r', '\n' },
                new List<char>() { ' ', '/', ' ', '\r', '\n' },
                new List<char>() { ' ', '\\', ' ', '\r', '\n' },
                new List<char>() { '-', '-', ' ' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumberFrom2DCharList(data);
            //Assert
            var expected = new List<char>() { '3' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}