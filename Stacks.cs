using System.Collections.Generic;

namespace LearningVisualStudioC
{
    internal class Stacks
    {
        private static void MainStacks(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //  ADD TO STACK
            stack.Push(1);
            //  LOOK AT STACK;
            stack.Peek();
            //  REMOVE ITEM;
            //CHECK IF COUNT IF > 0 TO AVOID CRASHES
            if (stack.Count > 0)
            {
                stack.Pop();
            }
        }
    }
}