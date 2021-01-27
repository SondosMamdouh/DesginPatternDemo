using System;

namespace MementoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator("hello its the first state.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
        }
    }
}
