using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertSaples.Tests
{
    [TestClass]
    public class CollectionAssertMethods
    {
        static List<string> employees;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            employees = new List<string>();

            employees.Add("Ivan");
            employees.Add("Sergey");
            employees.Add("Anton");
            employees.Add("Roman");
        }
        [TestMethod]
        public void AllItemsAreNotNull()
        {
            //Check all items has value
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");

        }
        [TestMethod]
        public void AllItemsAreUniquie()
        {
            //check all items uniquie
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
        }
        [TestMethod]
        public void AreEqual()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            CollectionAssert.AreEqual(employees, employeesTest);
        }

        [TestMethod]
        public void AreEQuivalemnt()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            CollectionAssert.AreEquivalent(employees, employeesTest);
        }
        [TestMethod]
        
        public void employees_Subset()
        {
            List<string> employees_Subset = new List<string>();
            employees_Subset.Add(employees[2]);
            // employees_Subset.Add("Alexander");  // if you uncomment the line code test don't get
            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }
    }
}
