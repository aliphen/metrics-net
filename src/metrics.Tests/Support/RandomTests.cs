﻿using System.Diagnostics;
using NUnit.Framework;

#if COREFX
using Trace = System.Diagnostics.Debug;
#endif

namespace metrics.Tests.Support
{
    [TestFixture]
    public class RandomTests
    {
        [Test]
        public void Can_generate_random_longs()
        {
            for(var i = 0; i < 1000; i++)
            {
                long random = metrics.Support.Random.NextLong();
                Trace.WriteLine(random);
            }
        }
    }
}
