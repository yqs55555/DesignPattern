using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPattern_CSharp.ProxyPattern.Example2
{
    public class Example2Test
    {
        public static void Test()
        {
            IPerson person = new PersonImpl();
            person.Name = "Person Name";
            person.Gender = "Person Gender";
            person.HotOrNotRating = 2;
            person.Interests = "Person Interests";

            IInvocationHandler invocationHandler = new OwnerInvocationHandler(person);
//            person.GetType().GetProperty("Name").GetSetMethod().Invoke(person, new object[]{"dsa"} );
//            var properties = person.GetType().GetProperties();
//            foreach (PropertyInfo property in properties)
//            {
//                Console.WriteLine(property.Name);
//            }
            if (!invocationHandler.Invoke(person.GetType().GetProperty("Name"), "Changed Name"))
            {
                Console.WriteLine("You can't change your name");
            }
            else
            {
                Console.WriteLine("Current Name is" + person.Name);
            }
        }
    }
}
