using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Simple.Data.IntegrationTest
{
    [TestFixture]
    public class TraceSettingsTest
    {
        [Test]
        public void TraceLevelShouldBePickedUpFromConfig()
        {
            Assert.AreEqual(TraceLevel.Error, SimpleDataTraceSources.TraceSource.Switch.Level);
        }

        [Test]
        public void TraceLevelShouldBeSettableFromCode()
        {
            SimpleDataTraceSources.TraceSource.Switch.Level = SourceLevels.Off;
            Assert.AreEqual(TraceLevel.Off, SimpleDataTraceSources.TraceSource.Switch.Level);

        }
    }
}
