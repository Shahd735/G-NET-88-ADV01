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

    #region Question5
    // Write a generic method FindMax<T> that finds maximum value

    //public T FindMax<T>(T a, T b) where T : IComparable<T>
    //{
    //    return a.CompareTo(b) > 0 ? a : b;
    //}
    #endregion

    #region Question6
    // What is a generic interface? Write IRepository<T>. 

    // => An interface that defines operations for a generic data type.
    //public interface IRepository<T>
    //{
    //    void Add(T item);
    //    T GetById(int id);
    //}
    #endregion

    #region Question7
    // What is the 'struct' constraint? Write an example.

    // => The struct constraint restricts the generic type T to be a value type
    //public class DataProcessor<T> where T : struct
    //{
    //    public T Value { get; set; }
    //}
    #endregion

    #region Question8
    // What is the 'class' constraint? Write an example.

    // => The class constraint restricts the generic type T to be a reference type
    //public class ObjectManager<T> where T : class
    //{
    //    public T ManagedObject { get; set; }
    //}
    #endregion

    #region Question9
    // What is the 'new()' constraint? Write an example.

    // => Ensures that the generic type T has a public parameterless constructor.
    //public class Factory<T> where T : new()
    //{
    //    public T CreateInstance()
    //    {
    //        return new T();
    //    }
    //}
    #endregion

    #region Question10
    // What is the interface constraint? Write an example.

    // => The interface constraint ensures that the generic type T implements a specific interface
    //public class ResourceHandler<T> where T : IDisposable
    //{
    //    public void CleanUp(T resource)
    //    {
    //        resource.Dispose();
    //    }
    //}
    #endregion

    #region Question11
    // What is the base class constraint? Write an example.

    // => The base class constraint ensures that the generic type T inherits from a specific base class.
    //public class Animal { }
    //public class Dog : Animal { }
    //public class AnimalHospital<T> where T : Animal
    //{
    //    public void Admit(T animal) { }
    //}
    #endregion

    #region Question12
    // How do you apply multiple constraints? Write an example. 

    //public class Repository<T> where T : class, new()
    //{
    //    public T CreateAndGet()
    //    {
    //        return new T();
    //    }
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