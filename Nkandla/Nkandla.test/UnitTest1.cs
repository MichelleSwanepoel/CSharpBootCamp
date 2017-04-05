using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nkandla.test
{
    [TestClass]
    public class UnitTest1
    {
        HomeStead nkandla;

        [TestInitialize]
        public void setup()
        {
            nkandla = new Nkandla("Nkandla", "uThungulu", "KwaZulu-Natal", "South Africa");
        }

        [TestMethod]
        public void TestANCMayEnter()
        {
            Politician jacob = new Politician("Jacob", 30, Gender.Male, "ANC");
            Assert.AreEqual(nkandla.accept(jacob), "Jacob is visiting Nkandla");
        }

        [TestMethod]
        [ExpectedException(typeof(VisitorNotAllowedException))]
        public void TestNotANCMayNotEnter()
        {
            Politician helen = new Politician("Helen", 50, Gender.Female, "DA");
            nkandla.accept(helen);
        }

    }
}
