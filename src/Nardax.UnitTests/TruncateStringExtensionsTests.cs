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
            var expected

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod] 
             
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {asdsadasdsa
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }
    }
}
