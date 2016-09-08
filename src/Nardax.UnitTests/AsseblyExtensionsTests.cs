using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class AsseblyExtensionsTests
    {
        [TestMethod]
        public void GetAppSettingsValue_ValidKey_ReturnsValue()
        {
            var validKey = "ValidKey";
            var expectedAppSettingVlaue = "SomeValue";

            var assembly = Assembly.GetExecutingAssembly();
            var actualAppSettingValue = assembly.GetAppSettingsValue(validKey);
            asdsadadsaass
            Assert.AreEqual(expectedAppSettingVlaue, actualAppSettingValue);
        }

        [Tes
            var assembly = Assembly.GetExecutingAssembly();
            assembly.GetAppSettingsValue(invalidKey);

            Assert.Fail();
        }
    }
}