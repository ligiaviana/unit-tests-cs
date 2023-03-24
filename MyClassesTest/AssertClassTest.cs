using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region IsInstanceOfType Test

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Ligia", "Viana", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Viana", true);

            Assert.IsNull(per);
        }

        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "Ligia";
            string str2 = "Ligia";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Ligia";
            string str2 = "ligia";

            Assert.AreEqual(str1, str2, false);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Ligia";
            string str2 = "Viana";

            Assert.AreNotEqual(str1, str2);
        }



        #endregion
    }
}
