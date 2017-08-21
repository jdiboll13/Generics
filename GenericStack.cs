using System;
using System.Linq;
using System.Collections.Generic;


namespace Generics
{
    public class Stack<T>
    {
        private IList<T> stack = new List<T>();

        public void Push(T item)
        {
            this.stack.Add(item);

        }

        public T Pop()
        {
            var item = stack.Last();
            this.stack.Remove(item);
            return item;
        }
    }
}
