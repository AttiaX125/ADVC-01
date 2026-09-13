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
        /*
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }*/
        #endregion
        #region Q5 - FindMax<T>
        /*
        public static T FindMax<T>(List<T> items) where T : IComparable<T>
        {
            T max = items[0];
            foreach (var item in items)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        */
        #endregion
        #region Q6 - IRepository<T>
        public interface IRepository<T>
        {
            void Add(T item);
            T GetById(int id);
            List<T> GetAll();
            void Remove(T item);
        }
        #endregion
        #region Q7 - struct Constraint
        public class StructOnly<T> where T : struct
        {
            public T Value { get; set; }
        }
        #endregion
        #region Q8 - class Constraint
        public class ClassOnly<T> where T : class
        {
            public T Value { get; set; }
        }
        #endregion
        #region Q9 - new() Constraint
        public class Factory<T> where T : new()
        {
            public T CreateInstance()
            {
                return new T();
            }
        }
        #endregion
        #region Q10 - Interface Constraint
        public interface IShape
        {
            double GetArea();
        }

        public class ShapePrinter<T> where T : IShape
        {
            public void PrintArea(T shape)
            {
                Console.WriteLine(shape.GetArea());
            }
        }
        #endregion
        #region Q11 - Base Class Constraint
        public class Animal
        {
            public string Name { get; set; }
        }

        public class AnimalHandler<T> where T : Animal
        {
            public void PrintName(T animal)
            {
                Console.WriteLine(animal.Name);
            }
        }
        #endregion
        #region Q12 - Multiple Constraints
        public class Repository<T> where T : class, new()
        {
            public T CreateNew()
            {
                return new T();
            }
        }
        #endregion
        #region Q13 - default Keyword
        public T GetDefault<T>()
        {
            return default(T);
        }
        #endregion
        #region Q14 - SafeList<T>
        public class SafeList<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                    return default(T);

                return items[index];
            }
        }
        #endregion
        #region Q15 - Covariance (out)
        public interface IProducer<out T>
        {
            T Produce();
        }

        public class AnimalProducer : IProducer<Animal>
        {
            public Animal Produce()
            {
                return new Animal();
            }
        }

        // Usage:
        // IProducer<Animal> producer = new AnimalProducer();
        // This works because 'out' allows a more derived type to be used
        // where a less derived type is expected (covariance).
        #endregion
    }
}
