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

## Task (4)

1) Add Validation in the Person class to match the following: -
    - Name should be not null, not empty, and no more than 32 characters
    - Age should be more than zero and no more than 128

## Task (5)

1) Use Exception to break the code execution if something goes wrong

## Task 6

1) Add Validation in the Student class to match the following: -
    - Year should between 1 and 5
    - Gpa should between 0 and 4
    - Make sure not to create the object if there's any validation issue (Optional)

2) Add Validation in the Staff class to match the following: -
    - Salary should be more than zero and no more than 120,000
    - JoinYear should be more than age by 21 years
    - Make sure not to create the object if there's any validation issue (Optional)

## Task 7 (Optional)

- Apply the encapsulation concept for the Student and Staff classes
    - Use Getter/Setter methods
    - Using Properties