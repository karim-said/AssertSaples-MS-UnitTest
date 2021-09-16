using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace AssertSaples.Tests
{
    [TestClass]
    public class AssertMethods
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            //arrange 
            const double input = 4;
            const double expected = 2;

            //act 
            double actual=MyClass.GetSqrt(input);

            //assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have been {1}!", input, expected);

        }
        [TestMethod]
        public void DeltaTest()
        {
            //arrange
            const double expected = 3.1;
            const double delta = 0.07;

            //3.162277660168395
            //0.062
            //act

            double actual = MyClass.GetSqrt(10);

            //assert
            Assert.AreEqual(expected, actual, delta, "fail message!!!");

        }

        [TestMethod]
        public void StringAreEqualTest()
        {
            //arrange
            const string input = "HELLO";
            const string expected = "hello";

            //act and assert
            //3-th parameter ignore case sensetive
            Assert.AreEqual(expected, input, true);
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            //check equal reference 
            Assert.AreSame(a, b);
        }
        [TestMethod]
        public void IntegerSameTest()
        {
            int i = 10;
            int j = 10;

            Assert.AreSame(i, j);
        }
    }
}
