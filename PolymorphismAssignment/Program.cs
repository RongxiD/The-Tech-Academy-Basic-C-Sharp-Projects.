using System; // Importing the System namespace for basic functionalities like Console.

// Creating an interface named IQuittable. Interfaces define a contract that classes can implement.
interface IQuittable
{
    // Defining a void method named Quit() within the IQuittable interface.
    // Any class that implements this interface must provide an implementation for this method.
    void Quit();
}

// Assuming you have a pre-existing Employee class.
// Declaring a public class named Employee that inherits from a base class (if any) and the IQuittable interface.
public class Employee : Person, IQuittable // Inheriting from Person (assuming it exists) and implementing IQuittable.
{
    // Properties of the Employee class (assuming these existed in your previous Employee class).
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementing the Quit() method as required by the IQuittable interface.
    // This is a specific implementation for what it means for an Employee to "Quit".
    public void Quit()
    {
        // Writing a message to the console indicating that the employee is quitting.
        Console.WriteLine(FirstName + " " + LastName + " has quit their job.");
        // You could add more complex logic here, such as updating database records or sending notifications.
    }

    // A constructor for the Employee class (assuming this existed previously).
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // (Assuming a SayName() method existed in your previous Employee/Person class)
    public override void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}

// The main program class where the application execution begins.
class Program
{
    // The Main method is the entry point of the console application.
    static void Main(string[] args)
    {
        // Creating an instance of the Employee class.
        Employee employee = new Employee(1, "John", "Doe");

        // Using polymorphism: creating an object of type IQuittable and assigning the Employee object to it.
        // This is possible because the Employee class implements the IQuittable interface.
        IQuittable quitter = employee;

        // Calling the Quit() method on the 'quitter' object, which is of type IQuittable.
        // Due to polymorphism, the specific implementation of the Quit() method in the Employee class will be executed.
        quitter.Quit(); // This will output: "John Doe has quit their job."

        // Keeping the console window open until a key is pressed so the user can see the output.
        Console.ReadKey();
    }
}