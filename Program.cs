using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Builder */
            Console.WriteLine("---- Builder ----");
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
            Console.WriteLine();


            /* Factory */
            Console.WriteLine("---- Factory ----");
            PersonFactory pf = new PersonFactory();

            Person p1 = pf.CreatePerson("Ron");
            Person p2 = pf.CreatePerson("Fernando");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();


            /* Prototype */
            Console.WriteLine("---- Prototype ----");
            Point start = new Point(0,1);
            Point end = new Point(0,10);
            Line line = new Line(start, end);
            Line copy = line.DeepCopy();
            copy.Start.X = 10;
            Console.WriteLine($"Original: {line}");
            Console.WriteLine($"Copy: {copy}");


            Console.ReadLine();

        }
    }
}
