using System;
using MentoringD1D2.Module2.Task3.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MentoringD1D2.Module2.Task3.Tests
{
    [TestClass]
    public class StringArrayExtensionTest
    {
        private readonly string[] _arrayOfStrings =
               {
                "quiy",
                null,
                "do",
                null,
                "winter",
                "deLimeter",
                "121_number",
                "wonderful",
                "air",
                "История",
                "string",
                "stringExample",
                "mark",
                "человек",
                "902 ^bb",
                "#$!",
                "Da"
            };

        [TestMethod]
        public void CustomStringConcatenateTest()
        {
            string expected = "deLimeterwonderfulИсторияstringExampleчеловек#$!";
            Assert.AreEqual(expected, _arrayOfStrings.CustomStringConcatenate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CocatenateNullTest()
        {
            string[] array = null;
            array.CustomStringConcatenate();
        }


        [TestMethod]
        public void ConcatenateEmptyTest()
        {
            string expected = String.Empty;
            string[] array= new string[] {};
            Assert.AreEqual(expected, array.CustomStringConcatenate());
        }
    }
}
