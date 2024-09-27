using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFeatures
{
    //class
    public class TestClass
    {
        public string name;
        public int age;
        public DateTime dob;
        public TestClass()
        {
            
        }
        public TestClass(string name)
        {
            this.name = name;
        }

        public TestClass(string name, int age)
        {
             this.name = name;
            this.age = age;
        }

        public TestClass(string name, int age, DateTime dob)
        {
             this.name = name;
            this.age = age;
            this.dob = dob;
        }
    }

    //structure
    public struct TestStruct
    {
        public string name;
        public int age;
        public DateTime dob;

        public TestStruct(string name, int age, DateTime dob)
        {
            this.name = name;
            this.age = age;
            this.dob = dob;
        }
    }
}
