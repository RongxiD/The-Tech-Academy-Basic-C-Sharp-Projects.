using System;

// Namespace declaration for organizing the code.
namespace OperatorOverloadingDemo
{
    // Class definition for Employee.
    public class Employee
    {
        // Property to store the unique identifier for an employee.
        public int Id { get; set; }

        // Property to store the first name of an employee.
        public string FirstName { get; set; }

        // Property to store the last name of an employee.
        public string LastName { get; set; }

        // Default constructor for the Employee class.  While not strictly required, it's good practice.
        public Employee() { }

        // Constructor for the Employee class that takes Id, FirstName, and LastName as parameters.
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;            // Initialize the Id property.
            FirstName = firstName;  // Initialize the FirstName property.
            LastName = lastName;    // Initialize the LastName property.
        }

        // Overloading the "==" operator to compare two Employee objects based on their Id.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null. If so, they are considered equal.
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // Check if either object is null, but not both.  If only one is null, they are not equal.
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Compare the Id properties of the two Employee objects.
            return employee1.Id == employee2.Id;
        }

        // Overloading the "!=" operator.  It's required to overload "!=" when overloading "==".
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Reuse the "==" operator to determine inequality.
            return !(employee1 == employee2);
        }

        // Overriding the Equals method for completeness and to avoid potential issues.
        public override bool Equals(object obj)
        {
            // Check if the object is null or not of the same type.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Cast the object to an Employee object.
            Employee other = (Employee)obj;
            // Compare the Id
            return Id == other.Id;
        }

        // Overriding the GetHashCode method for consistency when overriding Equals().
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // A simple hash code based on the Id.
        }
    }

    // Main program class.
    class Program
    {
        // Main method, the entry point of the application.
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties.
            Employee employee1 = new Employee(101, "John", "Doe");
            Employee employee2 = new Employee(101, "Jane", "Smith");
            Employee employee3 = new Employee(102, "Jane", "Smith");


            // Compare the two Employee objects using the overloaded "==" operator and display the result.
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee1 and Employee2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee1 and Employee2 are not equal (different Id).");
            }

            if (employee1 == employee3)
            {
                Console.WriteLine("Employee1 and Employee3 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee1 and Employee3 are not equal (different Id).");
            }

            // Compare to null
            Employee employee4 = null;
            if (employee1 == employee4)
            {
                Console.WriteLine("employee1 and employee4 are equal");
            }
            else
            {
                Console.WriteLine("employee1 and employee4 are not equal");
            }

            // Use the != operator
            if (employee1 != employee2)
            {
                Console.WriteLine("employee1 and employee2 are not equal using !=");
            }
            else
            {
                 Console.WriteLine("employee1 and employee2 are equal using !=");
            }

            // Keep the console window open until a key is pressed.
            Console.ReadKey();
        }
    }
}
