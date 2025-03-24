using System;
using System.Text;

public class StringManipulation
{
    public static void Main(string[] args)
    {
        // Concatenates three strings.
        string firstName = "John";
        string middleName = "Michael";
        string lastName = "Doe";
        string fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);

        // Converts a string to uppercase.
        string lowercaseString = "hello world";
        string uppercaseString = lowercaseString.ToUpper();
        Console.WriteLine("Uppercase String: " + uppercaseString);

        // Creates a StringBuilder and builds a paragraph of text, one sentence at a time.
        StringBuilder paragraph = new StringBuilder();
        paragraph.Append("This is the first sentence. ");
        paragraph.Append("Here comes the second sentence. ");
        paragraph.Append("And finally, this is the third sentence.");
        Console.WriteLine("Paragraph: " + paragraph.ToString());

        Console.ReadLine(); // Keep the console window open until a key is pressed.
    }
}