//Использование атрибутов для описания
using System.Reflection;
using System.ComponentModel;

namespace dz11_1
{
    class NameAttribute : Attribute
    {
        public string Description { get; } //{firstDes = 1, secondDes, thirdDes,fourthDes,fifthDes,sixthDes,seventhDes, eighthDes,ninethDes,tenthDes }
        //public string[] Description { firstDes = 1, secondDes, thirdDes, fourthDes, fifthDes, sixthDes, seventhDes, eighthDes, ninethDes, tenthDes }
        public NameAttribute() { }
        public NameAttribute(string description) => Description = description;
    }

    [Name()]
    public class FirstClass
    {
        //public PropertyDescriptor prop;
        [Description("firstDes")]
        public string first { get; }
        [Description("secondDes")]
        public string second { get; }
       [Description( "thirdDes")]
        public string third { get; }
        [Description( "fourthDes")]
        public string fourth { get; }
        [Description( "fifthDes")]
        public string fifth { get; }
       [Description( "sixthDes")]
        public string sixth { get; }
        [Description( "seventhDes")]
        public string seventh { get; }
        [Description( "eighthDes")]
        public string eighth { get; }
       [Description( "ninethDes")]
        public string nineth { get; }
       [Description( "tenthDes")]
        public string tenth { get; }
      
    }
    [Name()]
    class Program
    {
        static void Writing()
        {
            NameAttribute nameAttribute = new();
            FirstClass firstClass = new FirstClass();
            Type type = typeof(FirstClass);
            AttributeCollection? attributes = TypeDescriptor.GetProperties(firstClass)["first"]?.Attributes;
            DescriptionAttribute? myAttribute =
            (DescriptionAttribute?)attributes[typeof(DescriptionAttribute)];
            // proper = firstClass.prop;
            //PropertyInfo[] properties = type.GetProperties();
            foreach (MemberInfo member in type.GetProperties())
            {
                Console.WriteLine($"{member.CustomAttributes} {member.MemberType} {member.Name}" + "      -      " + myAttribute.Description);
            }
        }
        static void Main()
        {
            Writing();
        }



    }
}
