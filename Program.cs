namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        #region Q1 - Generic Class
        /*
        public class Box<T>
        {
            private T _value;

            public void Set(T value) => _value = value;
            public T Get() => _value;
        }
        */
        #endregion

        #region Q2 - Container<T>
        public class Container<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                return items[index];
            }
        }
        #endregion
    }
}
