using DesignPatterns.Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Builder */
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);

            
            /* Factory */
            PersonFactory pf = new PersonFactory();

            Person p1 = pf.CreatePerson("Ron");
            Person p2 = pf.CreatePerson("Fernando");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
