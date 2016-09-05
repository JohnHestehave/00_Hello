using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual("hello", Functions.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            Assert.AreEqual("hello, Fred", Functions.Hello("Fred"));
        }
    }

	internal class Functions
	{
		public static String Hello()
		{
			return "hello";
		}
		public static String Hello(String i)
		{
			return "hello, "+i;
		}
	}
}
