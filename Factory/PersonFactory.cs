using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class PersonFactory
    {
        private int id = 0;

        public Person CreatePerson(string name)
        {
            return new Person { ID = id++, Name = name };
        }
    }
}
