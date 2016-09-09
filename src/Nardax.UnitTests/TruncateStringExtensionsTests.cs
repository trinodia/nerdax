using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateLeft_ValueIsSmaller_TruncateRemovesLeftSide()
        {
            var expected = "123456789";

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsLarger_TruncateRemovesRightSide()
        {
            var expected = "1";

            var result = _value.TruncateRight(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RepeatMe()
        {
            var input = "abc";
            var expected = "abcabcabcabc";
            var result = input.RepeatMe(4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RepeatMe_DefaultValue()
        {
            var input = "NyanCat";
            var expected = "NyanCatNyanCatNyanCatNyanCatNyanCat";
            var result = input.RepeatMe();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveWhiteChar()
        {
            var input = "i\t will \tsurvive\t";
            var expected = "iwillsurvive";

            var result = input.RemoveWhiteChars();

            Assert.AreEqual(expected, result);
        }
    }
}
