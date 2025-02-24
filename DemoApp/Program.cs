using CreationalPatterns;


var singleton1 = Singleton.Instance;
singleton1.DoSomething();

var singleton2 = Singleton.Instance;
singleton2.DoSomething();

Console.WriteLine($"Are instances equal? {ReferenceEquals(singleton1, singleton2)}");
