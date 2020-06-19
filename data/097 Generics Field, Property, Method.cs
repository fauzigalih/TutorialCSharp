using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person<int> person1 = new Person<int>(23);
            person1.MyMethod(20);
            person1.Print();

            Person<string> person2 = new Person<string>("Fauzi");
            person2.MyMethod("Galih");
            person2.Print();
        }
    }

    class Person<T>
    {
        public Person(T person)
        {
            myField = person;
        }

        private T myField;
        public T MyProperty { get; set; }
        public T MyMethod(T method)
        {
            MyProperty = method;
            return MyProperty;
        }

        public void Print()
        {
            Console.WriteLine($"Your add type is {typeof(T)} with value {myField}");
            Console.WriteLine($"Field: {myField} \nProperty: {MyProperty}");
        }
    }
}
