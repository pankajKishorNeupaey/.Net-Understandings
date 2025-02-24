namespace CreationalPatterns;

/// <summary>
/// Implementation of the Singleton pattern.
/// Ensures that a class has only one instance and provides a global point of access to it.
/// This pattern is useful when we want to restrict multiple object creation.
/// 
/// - The class is marked as sealed to prevent inheritance.
/// - Lazy<T> is used for thread-safe, lazy initialization.
/// </summary>
public sealed class Singleton
{
    // Lazy initialization ensures thread safety and improves performance.
    private static readonly Lazy<Singleton> _instance = new(() => new Singleton());

    // Public property to access the single instance.
    public static Singleton Instance => _instance.Value;

    // Private constructor prevents external instantiation.
    private Singleton()
    {
         Console.WriteLine("Singleton instance created.");  // Avoid unnecessary logs in constructor.
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton is doing something!");
    }
}
