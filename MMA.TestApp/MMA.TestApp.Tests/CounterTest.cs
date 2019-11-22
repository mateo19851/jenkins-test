using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.TestApp.Tests
{
    [TestFixture]
    public class CounterTest
    {
        [Test]
        public void ShouldAdd()
        {
            var cut = new Counter();
            var result = cut.Add(1, 2);
            Assert.AreEqual(3, 3);
        }
    }
}
