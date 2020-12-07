using System;

namespace EventAggregatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EventAggregator eve = new EventAggregator();
            Publisher pub = new Publisher(eve);
            Subscriber sub = new Subscriber(eve);

            pub.PublishMessage();

            Console.ReadLine();
        }
    }
}
