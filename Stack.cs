using System;
using System.Collections.Generic;

namespace Stack
{
    class Stack
    {
        private readonly List<object> _list;

        public Stack()
        {
            _list = new List<object>();
        }
        public void Push(object obj)
        {
            if(obj == null) throw new InvalidOperationException("The input value is null");
            _list.Add(obj);
        }

        public object Pop()
        {
            if(_list.Count == 0) throw new InvalidOperationException("Stack is empty");
            var lastElement = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return lastElement;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}