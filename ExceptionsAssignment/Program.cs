using ExceptionsAssignment.exceptions;

namespace ExceptionsAssignment;

public class Program
{

    static void Main(string[] args)
    {
        decimal[] test_radius = { 5, -2, 0 };

        foreach (decimal radius in test_radius)
        {
            try
            {
                Circle c = new Circle();
                c.SetRadius(radius);
                Console.WriteLine(c.ToString());
            }
            catch (InvalidRadiusException e)
            {
                // Can also print it here.
            }   
        }
    }
    
}

