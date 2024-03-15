using C_Fundamentals;
using System;
using System.Diagnostics;
namespace CFundamentals

{
    class Program : Program2
    {
        public void getData()
        {
           Console.WriteLine("I am inside the method");  

        }
        static void Main(string[] args) {

            Program p = new Program(); // creating object of class to call the class, below.
            p.getData();
            p.setData();


           Console.WriteLine("How to print values in C#, example below"); 
           Console.WriteLine("Hello There! How are you doing! ");
           Console.WriteLine("Adding another line for code!");


            Console.WriteLine("String and int data types example below");
            int sector = 29;
            String name = "Divyanshu";
            String cityname = "Chandigarh";


            Console.WriteLine("Ways to combine and print values below of string and int data types");
            
            // using conactentaion method
            Console.WriteLine(name + " lives in sector " + sector  +  " from " + cityname);

            // using evaluation method
            Console.WriteLine($"{name} lives in sector {sector}, {cityname}");


            Console.WriteLine("In var data type we cannot reassign values, example below");
           
            var age = 30;
            Console.WriteLine($"age is {age} years young!");
            Console.WriteLine(" below one of reassigning value is not possible");
            //  age = "hello";

            Console.WriteLine("In dynamic data type we can reassign values");
            
            dynamic weight = 66.6;
            Console.WriteLine($"weight is {weight}");

            Console.WriteLine("Reassigning values example below for dynamic data type");
            weight = 68;
            Console.WriteLine($"weight is {weight}");


                }
    }

}