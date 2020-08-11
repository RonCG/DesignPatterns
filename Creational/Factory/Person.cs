using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }

    }
}
