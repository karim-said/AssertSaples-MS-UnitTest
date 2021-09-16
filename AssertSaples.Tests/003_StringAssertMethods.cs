using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AssertSaples.Tests
{
    [TestClass]
    public class StringAssertMethods
    {
        [TestMethod]
        public void StringContainsTest()
        {
            //Проверка на вхождение в строку подстроки
            StringAssert.Contains("Assert samples", "sam");
        }
        [TestMethod]
        public void StreingMatchesTest()
        {
            //Проверка с исползования регулярний виражения
            StringAssert.Matches("123", new System.Text.RegularExpressions.Regex(@"\d{3}"));
        }
        [TestMethod]
        public void StringStartsWithTest()
        {
            //Проверка того что строка начинаестя с оперделогного слово
            StringAssert.StartsWith("Hello world", "Hello");
        }
        [TestMethod]
        public void StringEndsWithTest()
        {
            //Проверка того что строка начинаестя с оперделогного слово
            StringAssert.StartsWith("Hello world", "Hello");
        } 

    }
}
