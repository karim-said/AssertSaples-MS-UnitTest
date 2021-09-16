using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextSamples
{
    [TestClass]
    public class MyTestSample
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRunDirectory {0}", TestContext.TestRunDirectory);
            TestContext.WriteLine("TestName {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome {0}", TestContext.CurrentTestOutcome);
        }
        [TestCleanup]
        public void TestCleanup()
        { 
            TestContext.WriteLine("TestName (CleanUp) {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome (CleanUp) {0}", TestContext.CurrentTestOutcome);
        }

    }
}
