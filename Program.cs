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
        /*
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
        }*/
        #endregion
        #region Q3 - Pair<TKey, TValue>
        /*
        public class Pair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public Pair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }*/
        #endregion
        #region Q4 - Swap<T>
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
