using System;
namespace Rewan;

//task3

//can't create object of abstract class Person 
public  class Person{
    public string Name;
    public int Age;
    

     public Person(string name,int age)
     {
        Name=name;
        Age=age;
     }
      public virtual void print()
     {
        Console.Write($"My name is {Name} , my age is {Age}");
     }
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
        base.print();
        Console.WriteLine($" and my gpa is {Gpa}");
     }

}

public class Staff : Person
{
public double Salary;
public int JoinYear;

public Staff(string name,int age,double salary, int joinYear) : base(name,age){
    Salary=salary;
    JoinYear=joinYear;
}

public override void print()
     {
        base.print();
        Console.WriteLine($" and my Salary is {Salary}");
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

    public void AddStaff(Staff staff)
    {
         People[_currentIndex++]= staff;
    }

    public void AddPerson(Person person)
    {
         People[_currentIndex++]= person;
    }

    public void PrintAll(){
        for( var i=0 ; i<_currentIndex ; i++)
        {
            People[i].print();
        }
    }
}


public class Rewan{
    private static void Main()
    {  
        var database = new Database();

        while( true){
            Console.WriteLine("1)student  2) staff  3)person   4)all people");

            Console.Write("Option: ");

            var option =Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

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

                    break;
                
                case 2:

                    Console.Write("Name : ");

                   var name2 =Console.ReadLine();

                   Console.Write("Age : ");

                   var age2 =Convert.ToInt32(Console.ReadLine());

                   Console.Write("Salary : ");

                   var salary =Convert.ToSingle(Console.ReadLine());
         
                  Console.Write("Join Year : ");

                  var joinYear =Convert.ToInt32(Console.ReadLine());      

                  var staff = new Staff(name2,age2,salary,joinYear);

                  database.AddStaff(staff);

                  break;

                case 3:

                    Console.Write("Name : ");

                   var name3 =Console.ReadLine();

                   Console.Write("Age : ");

                   var age3 =Convert.ToInt32(Console.ReadLine());

                   var person= new Person(name3,age3);
        
                   database.AddPerson(person);

                    break;

                case 4:

                    database.PrintAll();
                    break;

                default:
                    return;
            }
        }
        
        
         
       

        



       
    }
}
