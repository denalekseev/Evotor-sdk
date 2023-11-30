using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EvotorSdk.DataContracts;
using NUnit.Framework;

namespace EvotorSdk.Tests
{
    [TestFixture]
    public class MethodTests
    {
        private TestClient Client { get; } = new TestClient("");

        [Test, Ordered]
        public void GetStores()
        {
            var regions = Client.GetStores(new DataContracts.Stores.StoresRequest());
            Assert.That(regions, Is.Not.Null);
            Assert.That(regions.Items, Is.Not.Null);
            Assert.That(regions.Items.Count, Is.GreaterThan(0));
        }
    }
}