using System;
namespace Rewan;
public abstract class Person{
    public string Name;
    public int Age;
    

     public Person(string name,int age)
     {
        Name=name;
        Age=age;
     }
     public abstract void print();
}


public class Student : Person
{
  public int Year;
  public float Gpa;
  

     public Student(string name,int age,int year,float gpa) : base(name,age)
     {
        Name=name;
        Age=age;
        Year=year;
        Gpa=gpa;
     }

     public override void print()
     {
        Console.WriteLine($"My name is {Name}, my age is {Age}, and my gpa is {Gpa}");
     }

}
public class Database
{
    private int _currentIndex;
    //private int _count=50;
    
    //create array --> name is people and type is Person
    public Person[] People =new Person[50];

    public void AddStudent(Student student)
    {   
        //if (cuurentIndex == _count-1) return;
        People[_currentIndex++]= student;
    }
}

public class Rewan{
    private static void Main()
    {  
        var database = new Database();
        
        Console.Write("Name : ");

        var name =Console.ReadLine();

        Console.Write("Age : ");

        var age =Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Year : ");

        var year =Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Gpa : ");

        var gpa =Convert.ToSingle(Console.ReadLine());

        var student= new Student(name,age,year,gpa);
        
        database.AddStudent(student);



       
    }
}
