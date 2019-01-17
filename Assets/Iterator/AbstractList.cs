namespace IteratorPattern
{
    public abstract class AbstractList<T>
    {
        public abstract Iterator<T> CreateIterator();
        public abstract int Count();
        public abstract T Get(int index);
        public abstract void Add(T item);
    }
}
