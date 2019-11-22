using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.TestApp.Tests
{
    [TestFixture]
    public class PathFixerTest
    {
        [Test]
        [Ignore("No reason")]
        public void ShouldCorrectPath()
        {
            var cut = new PathFixer();
            var entries = cut.GetPathEntries();
            var distinctEntries = entries.Distinct();
            cut.SetPath(distinctEntries.ToArray());
        }
    }
}
