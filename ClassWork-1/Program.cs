using System;

namespace ClassWork_1
{
    class Student
    {
        int Id { get; set; }
        //access modifier, public
        public String Name { get; set; }
        //private
        private String Address { get; set; }
        //protected
        protected int Marks;

        //default constructor
        public Student()
        {
            Console.WriteLine("\n------Welcome to Student Records--------");
        }
        //parametarized constructor
        public Student(int id, String name, string address)
        {
            Id = id;
            Name = name;
            Address = address;

            Console.WriteLine("Id\tName\t\tAddress\n" + Id + "\t" + Name +"\t" + Address);
        }


    }

    //inherited class of Student
    class Result : Student
    {
        
        public void getName(int marks)
        {
            //inheriting variables
            Marks = marks;
            Console.WriteLine("\n------" + Name + "'s result resides here------\nThe marks is: " + Marks);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            Student stud2 = new Student(1, "Albert Camus", "Ratnanagar-2, Tandi");

            //creating object with inherited class
            Result res1 = new Result();

            //accessing the fields of inherited class
            res1.Name = "Friedrich Nietzsche";
            res1.getName(85);

            //creating object of Section class
            Section sec1 = new Section();
            sec1.displayGrade("2-A", "Galaxy");

            //creating object of Percentage class
            Percentage per1 = new Percentage();
            per1.calculatePercentage(85, 135);

        }

    }

    //abstract class means there is no way to create new instance from that class
    //it is only supposed to be inherited or extended, and still can have functionalities like methods and functions.
    abstract class Grade
    {
        //creating abstract method, which is a method without a body.
        public string Id { get; set; }
        public string Name { get; set; }

        public Grade(){
            Console.WriteLine("\n-----Grade and Section------");
            }
        public abstract void displayGrade(string id, string grade);

    }
    // Can't instantiate the class to make an object
    //const grade1 = new Grade();

    // inheriting from abstract class
    class Section : Grade
    {

        // provide implementation of abstract method
        public override void displayGrade(string id, string grade)
        {
            Id = id;
            Name = grade;
            Console.WriteLine("This is the section " + Id + " of " + Name);

        }
    }

    //Interface is similar to abstract class
    //But, here all methods of an interface are fully abstract
    interface IGrade
    {
        //there also cannot be any fields or constructors
        
        // method without body, which is an abstract class
        void calculatePercentage(int total, int actualMarks);
    }

    //To use an interface, other classes must implement it, using inheritance
    class Percentage : IGrade
    {

        public Percentage()
        {
            Console.WriteLine("\n-----Results in Percentage------");
        }
        // implementation of methods inside interface
        public void calculatePercentage(int total, int actualMarks)
        {

            int percent =  (actualMarks/total) * 100;
            Console.WriteLine("The scored marks in percentage is: " + percent);
        }
    }




}
