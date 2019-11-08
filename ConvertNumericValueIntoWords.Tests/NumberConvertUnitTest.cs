using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertNumericValueIntoWords.Repository;

namespace ConvertNumericValueIntoWords.Tests
{
    [TestClass]
    public class NumberConvertUnitTest
    {
        INumberConverter objNumberConverter;
        [TestInitialize]
        public void InitializeForTests()
        {
            objNumberConverter = new NumberConverter();
        }
        [TestMethod]
        public void NumberConvert()
        {
            string res = objNumberConverter.NumberConvertToWords("123.45");
            Assert.AreEqual("One Hundred Twenty Three dollars and Four Five Cents".Trim().ToLower(), res.Trim().ToLower());

        }
    }
}
