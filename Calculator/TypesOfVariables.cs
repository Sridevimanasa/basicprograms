using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class TypesOfVariables
    {
        //static variables
        public static int thisIsAStaticIntField;
        private static char thisIsAStaticCharField;
        public static bool thisIsAStaticBoolField;
        private static string thisIsAStaticStringField = "";
        public static float thisIsAStaticFloatField;
        public static int thisIsAStaticIntFieldWithValue = 5;
        private static char thisIsAStaticCharFieldWithValue = 'A';
        public static bool thisIsAStaticBoolFieldWithValue = false;
        private static string thisIsAStaticStringFieldWithValue = "name";
        public static float thisIsAStaticFloatFieldWithValue = 1.5f;

        //instance variables
        public int thisIsAnInstanceField;
        private char thisIsAnInstanceCharField;
        public bool thisIsAnInstanceBoolField;
        private string thisIsAnInstanceStringField = "";
        public float thisIsAnInstanceFloatField;
        public int thisIsAnInstanceIntFieldWithValue = 10;
        private char thisIsAnInstanceFieldWithValue = 'A';
        public bool thisIsAnInstanceBoolFieldWithValue = false;
        private string thisIsAnInstanceStringFieldWithValue = "name";
        public float thisIsAnInstanceFloatFieldWithValue = 2.5f;

    }
}
