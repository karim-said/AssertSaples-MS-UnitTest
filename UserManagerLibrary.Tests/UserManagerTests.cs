using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserManagerLibrary.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        private UserManager manager = new UserManager();


        //DataSource - опредиляет источник данних
        //1  параметр имя провайдера
        //2  параметр строка подключения или пут к файлу
        //3  параметр имя таблиса или или  элемент в XML
        //4  параметр как присходит дуступ к записям из источник данних

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Add_FromXML()
        {
            string userId = Convert.ToString(TestContext.DataRow["userId"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = manager.Add(userId, telephone, email);

            Assert.IsTrue(result, "User can't  create");

        }
    }
}
