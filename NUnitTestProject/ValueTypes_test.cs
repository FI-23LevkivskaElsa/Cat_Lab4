using System;
using NUnit.Framework;

namespace NUnitTestProject;

[TestFixture]
public sealed class ValueTypeTest
{
    [Test]
    public void AddingNumbTest()
    {
        var val_1 = 7;
        var val_2 = 9;
        var value = val_1 + val_2;
        Assert.That(value, Is.EqualTo(16));
    }
}
