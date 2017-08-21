using System;
using System.Collections.Generic;


namespace Generics
{
    public class GenericStack
    {
        private GenericStack<T> stack = new GenericStack<T>();

        private class GenericStack<T>
        {

        }
    }
}