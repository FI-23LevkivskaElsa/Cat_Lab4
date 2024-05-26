using System;
using NUnit.Framework;

namespace NUnitTestProject;

[TestFixture]
public sealed class HeapTest
{
    [Test]
    public int[] SortArray(int[] array, int size)
    {
        if (size <= 1)
            return array;
        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(array, size, i);
        }
        for (int i = size - 1; i >= 0; i--)
        {
            var tempVar = array[0];
            array[0] = array[i];
            array[i] = tempVar;
            Heapify(array, i, 0);
        }
        return array;
    }

    static void Heapify(int[] array, int size, int index)
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;
        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }
        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }
        if (largestIndex != index)
        {
            var tempVar = array[index];
            array[index] = array[largestIndex];
            array[largestIndex] = tempVar;
            Heapify(array, size, largestIndex);
        }
    }

    var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
    var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
    var sortFunction = new HeapSortMethods();
    var sortedArray = sortFunction.SortArray(array, array.Length, string.Empty);
    Assert.IsNotNull(sortedArray);
   CollectionAssert.AreEqual(sortedArray, expected);
}
