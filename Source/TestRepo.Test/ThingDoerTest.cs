using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TestRepoLib;

namespace TestRepo.Test
{
    [TestFixture]
    public class ThingDoerTest
    {
        [Test]
        public void ThingDoerDoesThing()
        {
            const string name = "Gary";
            var returnedThing = new ThingDoer().DoThing(name);
            Assert.That(returnedThing, Is.EqualTo("Hello " + name));
        }
    }
}
