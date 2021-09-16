using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AssertSaples.Tests
{
    [TestClass]
    public class ExpectingExceptions
    {
        //ExpectedExceptions - тесе будет успешно если в просессе виполнения будут виброшено исключения
        [ExpectedException(typeof(ArgumentNullException), "Exception was not throw")]
        [TestMethod]
        public void MyClass_SayHello_Exeption()
        {
            MyClass instance = new MyClass();
            instance.SayHello(null);
        }
        [TestMethod]
        public void MyClass_SayHello_ReturnDmitry()
        {
            //arrange
            MyClass instance = new MyClass();
            string expected = "Hello Dmitry";

            //act 
            string actual = instance.SayHello("Dmitry");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
