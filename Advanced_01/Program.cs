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

        #region Q11
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

        #region Q12
        /*
         *   How do you apply multiple constraints?
         * We can apply more than one constraint using multiple conditions after where and commas
         */

        class Repository<T> where T : class, IPrintable, new()
        {
            public T Create()
            {
                return new T();
            }
        }
        #endregion

        #region Q13
        /*
         * What does the 'default' keyword do in generics?
         * It returns the default value of type T.
         */
        #endregion

        #region Q14
        class SafeList<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                    return default;

                return items[index];
            }
        }
        #endregion

        #region Q15
        /*
         * What is covariance? Explain the 'out' keyword.
         * Covariance allows a generic type to use a more derived type where a base type is expected.
         * it comes out from interfaces as a return value
         */
        #endregion

        #region Q16
        /*
         * What is contravariance? Explain the 'in' keyword. 
         * Contravariance allows a generic type to use a base type where a derived type is expected.
         * in inters the interface as parameters
         */
        #endregion

        #region Q17:
        /*
         * What is the difference between covariance and contravariance? 
         * Covariance (out): Derived to Base, used when returning values.
         * while Contravariance (in: Base to Derived, used when accepting values.
         */
        #endregion

        #region Q18:
        /*
         * Q18: How do static members work in generic types? 
         * Each closed generic type gets its own static members.
         */
        #endregion

        static void Main(string[] args)
        {
            
        }
    }
}
