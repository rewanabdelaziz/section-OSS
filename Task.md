## Task (1)

1) Create an abstract Person class containing the following members: -
    - Name: string
    - Age: int
    - ctor(name, age)
    - abstract Print(): void

2) Create a Student class extends from Person class containing the following members: -
    - Year: int
    - Gpa: float
    - ctor(name, age, year, gpa)
    - override Print(): void
        = Should print out "My name is " + Name + ", my age is " + Age + " and my gpa is " + Gpa;

3) Create a Database class containing the following members: -
    - People: Person[]
    - AddStudent(Student student): void
        = Should add a student to the People array

4) Use the Database class in your Main() method to take the students details from the user and add it.

## Task 2

1) Create a Staff class extends from Person class containing the following members: -
    - Salary: double
    - JoinYear: int
    - ctor(name, age, salary, joinYear)
    - override Print(): void
        = Should print out "My name is " + Name + ", my age is " + Age + " and my salary is " + Salary;

2) Update the Database class to contain the following members: -
    - AddStaff(Staff staff): void
        = Should add a staff to the People array

3) Update the Main() method to accept more than option as following: -
    - 1 for adding a student
    - 2 for adding a staff
    - 3 for adding a person
    - 4 for printing out all people in People array

## Task 3

Update the Main() method to accept non-students non-staff people