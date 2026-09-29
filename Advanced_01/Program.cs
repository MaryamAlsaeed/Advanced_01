namespace Advanced_01
{
    internal class Program
    {
        #region Q1
        /*
         * 1) What is a generic class? Why use generics? 
         * A generic class is a class that works with different data types and represented by <T>.
         */
        #endregion

        #region Q2
        class Container<T>
        {
            private List<T> _mylist = new();
            public void Add(T mylist) => _mylist.Add(mylist);
            public T Get(int index) => _mylist[index];
        }
        #endregion

        #region Q3
        /*
         * What are multiple type parameters?
         * A generic class can have more than one type parameter.
         */
        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }
            public Pair(TFirst first, TSecond second) { First = first; Second = second; }
        }
        #endregion

        #region Q4
        /* What is a generic method?
         * A generic method is a method that has its own type parameter.
         */

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Q5
        static T FindMax<T>(T[] items) where T : IComparable<T> // => to be able to compare with generics
        {
            T max = items[0];
            foreach (var item in items)
                if (item.CompareTo(max) > 0) max = item;
            return max;
        }
        #endregion

        #region Q6
        /* What is a generic interface?
         * A generic interface is an interface that accepts a type parameter.
         */
        interface IRepository<T>
        {
            void Add(T item);
            T Get(int id);
            void Remove(int id);

        }
        #endregion

        #region Q7
        /*
         * What is the 'struct' constraint?
         * The struct constraint means that T data type must be a value type.
         */

        class Containerr<T> where T : struct
        {
            public T Value { get; set; }
        }
        #endregion

        #region Q8
        /*
         *  What is the 'class' constraint?
         *  The class constraint means that T data type must be a reference type.
         */
        class Containerrr<T> where T : class
        {
            public T Value { get; set; }
        }
        #endregion

        #region Q9
        /*
         * What is the 'new()' constraint?
         * The new() constraint means that T must have a public parameterless constructor.
         */
        class ParameterlessCTOR<T> where T : new()
        {
            public T Create()
            {
                return new T();
            }
        }

        #endregion

        #region Q10
        /*
         *  What is the interface constraint?
         * It means that T must implement a specific interface.
         */
        interface IPrintable
        {
            void Print();
        }
        #endregion
        #region Q11:
        /*
         * What is the base class constraint?
         * It means that T must inherit from a specific base class.
         */
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating");
            }
        }

        #endregion

        static void Main(string[] args)
        {
            
        }
    }
}
