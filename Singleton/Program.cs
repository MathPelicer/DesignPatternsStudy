// See https://refactoring.guru/design-patterns/singleton/csharp/example#lang-features for more info

Thread process1 = new Thread(() => TestSingleton("value 1"));
Thread process2 = new Thread(() => TestSingleton("value 2"));

process1.Start();
process2.Start();

process1.Join();
process2.Join();

static void TestSingleton(string value)
{
    Singleton.Singleton singleton = Singleton.Singleton.GetInstance(value);
    Console.WriteLine(singleton.Value.ToString());
}
