using System;
using System.Reflection;
namespace First
{
    //abstract classes and interface cannot create direct objects
    interface Muscic
    {
        void play();
        void genre();
    }
    abstract class Animal  // Base class (parent) 
    {
        //abstract -> must be inherited from another class <- so child must setup it's own way
        public abstract void movement(); 
        //virtual says it is value that could be overriden
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void movement()
        {
            //throw new NotImplementedException();
            Console.Write("Walking");
        }
        //override is overriding 'virtual' value
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        class Car
        {
            public string name = "nice";
            //property 
            //public string Name
            //{
            //    get { return name; }
            //    set { name = value; }
            //}

            public string model = "Ford ";

            //public Car(string modelName)
            //{
            //    model = modelName;
            //}
            string color = "red";
            public void jakouMasBarvu()
            {

                Console.WriteLine(color);
            }

            
        }




        static void MyMethod(string variable)
        {
            Console.Write(variable + "\n");
        }



        static void Main(string[] args)
        {
            WorkWithFiles w = new WorkWithFiles();
            //Creating object
            Car myObj = new Car();

            w.Nice();
            myObj.jakouMasBarvu();
            //Console.WriteLine(w.Nice);
            //Console.Write(myObj.color);
            string username = Console.ReadLine();
            //string.Concat();

            // string interpolation -> changing in string variables
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.Write("Helletnuo World!\n" + username);

            if (firstName == "John")
            {
                Console.Write("nice");
                username= Console.ReadLine();
            }
            // switch statement
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // foreach
            string[] arrayName = { "first", "second" };
            // Array.Length => 2
            // Array.Sort(arrayToSort)


            foreach (string variableName in arrayName)
            {
                //MyMethod(variable:variableName,);
                MyMethod(variableName);
                // break; continue;
            }

        }





    }
}