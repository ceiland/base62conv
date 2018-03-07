using System;
using BaseConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Base62Test
{
    [TestClass]
    public class Base62UnitTests
    {
        [DataTestMethod]
        [DataRow(15674, "44O")]
        [DataRow(7026425611433322325, "8n36rbfRcDb")]
        [DataRow(187621, "MO9")]
        [DataRow(237860461, "g62n3")]
        [DataRow(2187521, "9b4B")]
        [DataRow(18752, "4Ss")]
        public void SampleSetA(long input, string output)
        {
            Assert.AreEqual(Base62.Convert(input), output);
        }
    }
}
