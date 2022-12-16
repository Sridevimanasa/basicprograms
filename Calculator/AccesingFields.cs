using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class AccesingFields
    {
        public static void PrintStaticVariable()
        {
            Console.WriteLine("thisIsAStaticBoolField = "+TypesOfVariables.thisIsAStaticBoolField );
            Console.WriteLine("thisIsAStaticIntField = "+TypesOfVariables.thisIsAStaticIntField);
        }
        
        public void PrintInstanceVariable()
        {
            TypesOfVariables obj = new TypesOfVariables();
            Console.WriteLine("thisIsAnInstanceField = " + obj.thisIsAnInstanceField);
            Console.WriteLine("thisIsAnInstanceBoolField = " + obj.thisIsAnInstanceBoolField);
        }

    }
}
