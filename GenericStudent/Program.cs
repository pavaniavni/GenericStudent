using System;

namespace Generic
{
    internal class Program
    {
        public class sample<P>
        {
            //field
            private P data;

            //property
            public P value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        public class Student
        {
            public int StuID { get; set; }
            public string StuName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "Pavani";

            sample<float> version = new sample<float>();
            version.value = 6.0F;

            sample<int> count = new sample<int>();
            count.value = 84;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);
            //display count
            Console.WriteLine(count.value);

            Student s = new Student()
            {
                StuID = 4,
                StuName = "Pavani",
                Age = 21,
                Address = "Hyderabad "
            };
            Console.WriteLine("Student Information");
            Console.WriteLine(s.StuID);
            Console.WriteLine(s.StuName);
            Console.WriteLine(s.Age);
            Console.WriteLine(s.Address);
        }
    }
}
