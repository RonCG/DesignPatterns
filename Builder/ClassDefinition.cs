using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ClassDefinition
    {
        public string className;
        public List<ClassAttribute> attributes;
        private const int attrIndent = 2;

        public ClassDefinition()
        {
            this.attributes = new List<ClassAttribute>();
        }

        private string ToStringImpl()
        {
            var sb = new StringBuilder();
            sb.Append($"public class {className}\n").Append("{\n");

            var i = new string(' ', attrIndent);
            foreach (var attr in attributes)
            {
                sb.Append($"{i}public ")
                  .Append($"{attr.type} ")
                  .Append($"{attr.name};\n");
            }

            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl();
        }

    }

    public class ClassAttribute
    {
        public string type, name;

        public ClassAttribute(string name, string type)
        {
            this.type = type;
            this.name = name;
        }
    }

}
