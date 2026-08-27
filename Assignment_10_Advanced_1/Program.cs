namespace Assignment_10_Advanced_1;

internal class Program
{
    #region Question2
    // Write a generic class Container<T> with Add and Get methods.
    //public class Container<T>
    //{
    //    private T _item;

    //    public void Add(T item)
    //    {
    //        _item = item;
    //    }

    //    public T Get()
    //    {
    //        return _item;
    //    }
    //}

    #endregion

    #region Question3
    // What are multiple type parameters? Write Pair<TKey, TValue>.

    // => Multiple type parameters allow a generic class to accept more than one variable type, separated by commas.
    //public class Pair<TKey, TValue>
    //{
    //    public TKey Key { get; set; }
    //    public TValue Value { get; set; }
    //}
    #endregion

    #region Question4
    // What is a generic method? Write Swap<T> method.

    // => A generic method is a method declared with its own type parameters
    //public void Swap<T>(ref T a, ref T b)
    //{
    //    T temp = a;
    //    a = b;
    //    b = temp;
    //}
    #endregion

    static void Main(string[] args)
    {
        #region Question1
        // What is a generic class? Why use generics?

        // => A generic class is a class that can work with any data type. We use generics to maximize code reusability, type safety
        #endregion
    }
}