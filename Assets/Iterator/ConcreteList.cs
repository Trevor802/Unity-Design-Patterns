using System.Collections.Generic;

namespace IteratorPattern
{
    public class ConcreteList<T> : AbstractList<T>
    {
        private List<T> list = new List<T>();

        public override void Add(T item)
        {
            list.Add(item);
        }

        public override int Count()
        {
            return list.Count;
        }

        public override Iterator<T> CreateIterator()
        {
            return new ListIterator<T>(this);
        }

        public override T Get(int index)
        {
            return list[index];
        }
    }
}