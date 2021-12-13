using System;

namespace Personabout
{
    class Program
    {
        

       public static void Main(string[] args)
       {

            Listener listener = new Listener("Leyla", "Musayeva" ,23);
            Student student = new Student("Ali", "Rzayev" ,25);

            Console.WriteLine(listener.Age > student.Age);
            

       }

    }
   
}

class Student
{
    public string Name { get; set; }
    public String Surname { get; set; }
    public int Age { get; set; }

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;

    }
}

    public static bool operator > (Listener listener, Student student)
    {

        return listener.Age > student.Age;
    }
    public static bool operator < (Listener listener,Student student)
    {

            return listener.Age  < student.Age;
    }

        class Listener
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public Listener(string name, string surname, int age)
            {

            }
        }
















  
    
