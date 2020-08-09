using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class CodeBuilder
    {
        private readonly string className;
        private ClassDefinition classDef = new ClassDefinition();

        public CodeBuilder(string className)
        {
            this.className = className;
            classDef.className = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            classDef.attributes.Add(new ClassAttribute(name, type));
            return this;
        }

        public override string ToString()
        {
            return classDef.ToString();
        }
    }

   }
