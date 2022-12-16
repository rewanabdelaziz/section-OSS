using System;
namespace Rewan;

//task 6 & 7

//can't create object of abstract class Person
public  class Person{

    private string _name;
    //property using arrow function    get to return name     set to put value in varaible  

    //can use this
    //  public string Name{get => _name; set=> _name= value;}
    // or this

    public string Name
    {
        get { return _name;}
        set{
            if (value==null || value=="" || value.Length>= 32)
        {
            
            throw new NullReferenceException("invalid name");     //var ex = new Exception{};
          
        }
          _name=value;
        }
    }

    private int _age;

    public int Age{
         get { return _age;}
          set{
        if (value<=0 || value>128){
            throw new Exception("invalid age");
        }

        _age=value;
          }
    }
    

     public Person(string name,int age)
     {  
        // if (name==null || name=="" || name.Length>= 32)
        // {
            
        //     throw new NullReferenceException("invalid name");     //var ex = new Exception{};
               
        //     // Console.WriteLine("invalid name");
        //     // return;
        // }

        // if (age<=0 || age>128){
        //     throw new Exception("invalid age");
        //     // Console.WriteLine("invalid age");
        //     // return;
        // }

        Name=name;
        Age=age;
     }
     
    //  public string Getname() => _name;

    //  public int GetAge()  => _age;

    //  public void SetName(string name){
    //     if (name==null || name=="" || name.Length>= 32)
    //     {
            
    //         throw new NullReferenceException("invalid name");     //var ex = new Exception{};
               
    //     }
    //  }
      public virtual void print()
     {
        Console.Write($"My name is {Name} , my age is {Age} ");
     }
}

public class Student : Person
{
     private int _year;
    public int Year
    {
        get { return _year;}
        set{
            if (value<1 ||value>5)
        {
            
            throw new Exception("invalid year");     
          
        }
          _year=value;
        }
    }
  
  //public float Gpa {get; set;}
    private float _gpa;
    public float Gpa
    {
        get { return _gpa;}
        set{
            if (value<0 ||value>4)
        {
            
            throw new Exception("invalid Gpa");     
          
        }
          _gpa=value;
        }
    }

  

     public Student(string name,int age,int year,float gpa) : base(name,age)
     {
        
        Year=year;
        Gpa=gpa;
     }

     //  public int GetYear() => _year;

    //  public float GetGpa()  => _gpa;


     public override void print()
     {
        base.print();
        Console.WriteLine($" and my gpa is {Gpa}");
     }

}

public class Staff : Person
{
private double _salary;
    public double Salary
    {
        get { return _salary;}
        set{
            if (value<=0 ||value>120000)
        {
            
            throw new Exception("invalid salary");     
          
        }
          _salary=value;
        }
    }

private int _joinYear;
    public int JoinYear
    {
        get { return _joinYear;}
        set{
            if (value<Age+21)
        {
            
            throw new Exception("invalid Join Year");     
          
        }
          _joinYear=value;
        }
    }

public Staff(string name,int age,double salary, int joinYear) : base(name,age){
    Salary=salary;
    JoinYear=joinYear;
}

    //  public double GetSalary() => _Slary;

    //  public int GetJoinYear()  => _joinYear;

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

                    try
                   {
                       var student= new Student(name,age,year,gpa);

                       database.AddStudent(student);
                   }
                   catch 
                   {
                     Console.WriteLine("invalid input");
                   }      

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

                 try
                   {
                      var staff = new Staff(name2,age2,salary,joinYear);

                      database.AddStaff(staff);
                   }
                   catch 
                   {
                     Console.WriteLine("invalid input");
                   }      

                  break;

                case 3:

                    Console.Write("Name : ");

                   var name3 =Console.ReadLine();

                   Console.Write("Age : ");

                   var age3 =Convert.ToInt32(Console.ReadLine());

                   // to catch exception and continue execution
                   try
                   {
                    //statement which I expected it may has exception
                     var person= new Person(name3,age3);
        
                     database.AddPerson(person);
                   }
                   catch 
                   {
                     Console.WriteLine("invalid input");
                   }
                //  try
                //    {
                //    
                //      var person= new Person(name3,age3);
        
                //      database.AddPerson(person);
                //    }
                //    catch (Exception e)
                //    {
                //      Console.WriteLine(e.Message);
                //    }
               

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
