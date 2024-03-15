using NUnit.Framework;

namespace Selenium_Automation
{
    public class test
    {
        [SetUp]
        public void Setup()
        {
        TestContext.Progress.WriteLine("Test case Setup");
        }
        
        [Test]
        public void Testexecution1()
        {
            TestContext.Progress.WriteLine("Test execution 1"); 
        }


        [Test]
        public void Testexecution2()
        {
            TestContext.Progress.WriteLine("Test execution 2");
        }


        [TearDown]
        public void closebrowser() 
        {
        TestContext.Progress.WriteLine("Test closure");
        }
    }
}