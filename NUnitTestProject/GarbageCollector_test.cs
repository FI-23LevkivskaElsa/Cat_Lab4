﻿using System;
using NUnit.Framework;

namespace NUnitTestProject;

[TestFixture]
class GarbageCollectorTest
{
    private const int maxGarbage = 1000;

    [Test]
    public void Main()
    {
        GarbageCollectorTest.MakeSomeGarbage();
        var before = GC.GetTotalMemory(false);

        GC.Collect();
        var after = GC.GetTotalMemory(true);
        Assert.That(before > after, Is.EqualTo(true));
    }

    static void MakeSomeGarbage()
    {
        Version vt;

        for (int i = 0; i < maxGarbage; i++)
        {
            vt = new Version();
        }
    }
}
