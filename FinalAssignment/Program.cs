using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

// Define the namespace for the application.
namespace EFCodeFirstDemo
{
    // Define the Student entity class.  This class represents the structure of the Student table in the database.
    public class Student
    {
        // Define the primary key for the Student table.  The [Key] attribute specifies that this property is the primary key.
        [Key]
        public int StudentId { get; set; }

        // Define a property to store the student's first name.
        [Required] // Adds a NOT NULL constraint to the column in the database.
        [MaxLength(50)] // Limits the maximum length of the string to 50 characters.
        public string FirstName { get; set; }

        // Define a property to store the student's last name.
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
    }

    // Define the database context class, which inherits from DbContext.
    // This class is responsible for interacting with the database.
    public class StudentContext : DbContext
    {
        // Define a DbSet property for the Student entity.  This property represents the Students table in the database.
        public DbSet<Student> Students { get; set; }

        //  Override the OnModelCreating method to configure the database mapping.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  Configure default schema
            modelBuilder.HasDefaultSchema("School");

            // Call the base class implementation to ensure any base configurations are applied.
            base.OnModelCreating(modelBuilder);
        }
        // Constructor that takes a connection string.  This allows you to specify which database to use.
        public StudentContext(string connectionString) : base(connectionString)
        {
        }

        // Default constructor.  If no connection string is provided, it will use the default connection string.
        public StudentContext() : base("name=StudentDB") // "StudentDB" is the name of the connection string in the config file.
        {
        }
    }

    // The main program class.
    class Program
    {
        // The main method, which is the entry point of the application.
        static void Main(string[] args)
        {
            //  Create the database if it does not exist
            Database.SetInitializer(new CreateDatabaseIfNotExists<StudentContext>());

            // Use a using statement to ensure that the StudentContext is properly disposed of after it is used.
            //  Create a new StudentContext, using the connection string.
            using (var db = new StudentContext())
            {
                // Create a new Student object.
                var student = new Student { FirstName = "John", LastName = "Doe" };

                // Add the student to the Students DbSet.  This tells Entity Framework to insert the student into the database.
                db.Students.Add(student);

                // Save the changes to the database.  This is where the actual INSERT statement is executed.
                db.SaveChanges();

                // Display a success message to the console.
                Console.WriteLine("Student added successfully.");
            }
            // Use a using statement to ensure that the StudentContext is properly disposed of after it is used.
            using (var db = new StudentContext())
            {
                // Retrieve and display the student.
                var student = db.Students.Find(1);
                if (student != null)
                {
                    Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            // Keep the console window open until a key is pressed.
            Console.ReadKey();
        }
    }
}
