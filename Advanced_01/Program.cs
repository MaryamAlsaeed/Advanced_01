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
        static void Main(string[] args)
        {
            
        }
    }
}
