using System;

namespace Assembilies
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SkillAttribute : Attribute
    {

        public string Name { get; private set; }
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }
        public SkillAttribute(string name, int minimum, int maximum)
        {
            Name = name;
            Minimum = minimum;
            Maximum = maximum;
        }
        public bool IsValid(object obj)
        {
            var value = (int)obj;
            return value >= Minimum && value <= Maximum;
        }
    }
}
