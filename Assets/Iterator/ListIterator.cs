using System;

namespace IteratorPattern
{
    public class ListIterator<T> : Iterator<T>
    {
        private AbstractList<T> list;
        private int current;

        public ListIterator(AbstractList<T> list)
        {
            this.list = list;
            current = 0;
        }

        public override T CurrentItem()
        {
            if (IsDone())
            {
                throw new IndexOutOfRangeException();
            }
            return list.Get(current);
        }

        public override void First()
        {
            current = 0;
        }

        public override bool IsDone()
        {
            return current >= list.Count();
        }

        public override void Next()
        {
            current++;
        }
    }
}