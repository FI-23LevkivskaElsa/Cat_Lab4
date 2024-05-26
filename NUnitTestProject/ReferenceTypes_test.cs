using System;
using NUnit.Framework;

namespace NUnitTestProject;

[TestFixture]
public sealed class ReferenceTypeTest
{
    [Test]
    public void ZoomArray()
    {
        var value = new[] { 15, 1, 2003 };
        ZoomFunction(value);
        Assert.That(value, Is.EquivalentTo(new[] { 16, 2, 2004 }));

        static void ZoomFunction(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
    }
}
