using System;
using System.Collections;

namespace NUnitTestProject;

public sealed class StackTest
{

    static public void CreatStack()
    {
        Stack my_stack = new Stack();

        my_stack.Push(4);
        my_stack.Push(3);
        my_stack.Push(2);
        my_stack.Push(1);

        foreach (var elem in my_stack)
        {
            Console.WriteLine(elem);
        }
    }
}
