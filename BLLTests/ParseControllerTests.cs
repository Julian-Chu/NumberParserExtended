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
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '3' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_2_Return_2()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-', '-', '\r', '\n' },
                new List<char>() { ' ', '_', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', '\r', '\n' },
                new List<char>() { '-', '-', '-' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '2' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_1_Return_1()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|'}
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '1' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_4_Return_4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_5_Return_5()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-', '-', '-', '-', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '_', '_', '_', '_', '|' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '5' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_5s1_Return_5_1()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-', '-', '-', '-', ' ', '|', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', ' ', '|', '\r', '\n' },
                new List<char>() { '_', '_', '_', '_', '|', ' ', '|'}
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '5', '1' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_4s1_Return_4_1()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|', ' ', ' ', ' ', '|', ' ', '|', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', '|', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', ' ', '|'}
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '4', '1' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_1s4_Return_1_4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|', ' ', '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', '|' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '1', '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_1ss4_Return_1_4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|', ' ', ' ', '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '1', '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_1n4_Return_1n4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|','\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|' }
            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '1', '\r', '\n', '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_1ss4n1s4_Return_1_4_n_4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '|', ' ', ' ', '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { ' ', ' ', ' ', ' ', '|' }

            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '1', '4', '\r', '\n', '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }


        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_3sss2n1ss4_Return_3_2_n_1_4()
        {
            //Assign 
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-' , '-',' ', ' ', ' ', '-', '-', '-', '\r', '\n' },
                new List<char>() { ' ', '/' , ' ',' ', ' ', ' ', ' ', '_', '|', '\r', '\n' },
                new List<char>() { ' ', '\\', ' ',' ', ' ', ' ', '|', ' ', ' ', '\r', '\n' },
                new List<char>() { '-', '-' , ' ',' ', ' ', ' ', '-', '-', '-', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', '|', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', '|', '_', '_', '_', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|'},


            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '3', '2', '\r', '\n', '1', '4' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_3sss2ssss1n1ss4sss5_Return_3_2_1_n_1_4_5()
        {
            //Assign 
            char sp = ' ';
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-' , '-', sp, sp, sp, '-', '-', '-', sp, sp, sp, sp, '|', '\r', '\n' },
                new List<char>() { ' ', '/' , ' ', sp, sp, sp, ' ', '_', '|', sp, sp, sp, sp, '|', '\r', '\n' },
                new List<char>() { ' ', '\\', ' ', sp, sp, sp, '|', ' ', ' ', sp, sp, sp, sp, '|', '\r', '\n' },
                new List<char>() { '-', '-' , ' ', sp, sp, sp, '-', '-', '-', sp, sp, sp, sp, '|', '\r', '\n' },
                new List<char>() { '|', sp, sp, '|', ' ', ' ', ' ', '|', sp, sp, sp, '-', '-', '-', '-', '-', '\r', '\n' },
                new List<char>() { '|', sp, sp, '|', '_', '_', '_', '|', sp, sp, sp, '|', '_', '_', '_', '\r', '\n' },
                new List<char>() { '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, '_', '_', '_', '_', '|' }

            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '3', '2', '1', '\r', '\n', '1', '4', '5' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ParseNumberFrom2DCharList_Give_3sss2ssss1ss4sss5n1ss4sss5_Return_3_2_1_4_5_n_1_4_5()
        {
            //Assign 
            char sp = ' ';
            var data = new List<List<char>>()
            {
                new List<char>() { '-', '-' , '-', sp, sp, sp, '-', '-', '-', sp, sp, sp, sp, '|', sp, sp, '|', ' ', ' ', ' ', '|', sp, sp, sp, '-', '-', '-', '-', '-', '\r', '\n' },
                new List<char>() { ' ', '/' , ' ', sp, sp, sp, ' ', '_', '|', sp, sp, sp, sp, '|', sp, sp, '|', '_', '_', '_', '|', sp, sp, sp, '|', '_', '_', '_', '\r', '\n' },
                new List<char>() { ' ', '\\', ' ', sp, sp, sp, '|', ' ', ' ', sp, sp, sp, sp, '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '-', '-' , ' ', sp, sp, sp, '-', '-', '-', sp, sp, sp, sp, '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, '_', '_', '_', '_', '|' },
                new List<char>() { '|', sp, sp, '|', ' ', ' ', ' ', '|', sp, sp, sp, '-', '-', '-', '-', '-', '\r', '\n' },
                new List<char>() { '|', sp, sp, '|', '_', '_', '_', '|', sp, sp, sp, '|', '_', '_', '_', '\r', '\n' },
                new List<char>() { '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, ' ', ' ', ' ', ' ', '|', '\r', '\n' },
                new List<char>() { '|', sp, sp, ' ', ' ', ' ', ' ', '|', sp, sp, sp, '_', '_', '_', '_', '|' }

            };
            var controller = new ParseController();

            //Act
            var actual = controller.ParseNumbers(data);
            //Assert
            var expected = new List<char>() { '3', '2', '1', '4', '5', '\r', '\n', '1', '4', '5' };
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}