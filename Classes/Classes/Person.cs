using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
//    Create a new project, and include in it the class Person that you just created.
//Create a class "Student" and another class "Teacher", both descendants of "Person".
//The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class."
//The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string.
//The class Person must have a method "SetAge (int n)" which will indicate the value of their age(eg, 20 years old).
//The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).
//You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
//Create a Person and make it say hello
//Create a student, set his age to 21, tell him to Greet and display his age
//Create a teacher, 30 years old, ask him to say hello and then explain.
    class Person
    {
        int age;
        public void Greet()
        {
            Console.WriteLine("Hi");
        }

        public void SetAge(int num)
        {
            age = num;

        }



    }

    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is {age} years old");
        }

    }

    class Teacher : Person
    {
        private string sub;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();
        }
    }
}
