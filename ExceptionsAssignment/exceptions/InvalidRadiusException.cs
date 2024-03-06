namespace ExceptionsAssignment.exceptions;

public class InvalidRadiusException : Exception
{

    private string message;

    public string Message
    {
        get { return message; }
    }
    
    
    public InvalidRadiusException()
    {
        message = "Invalid Radius. Radius must be greater than 0.";
        Console.WriteLine(Message);
    }

    public InvalidRadiusException(decimal radius)
    {
        message = $"Invalid Radius {radius}. Radius must be greater than 0.";
        Console.WriteLine(Message);
    }
}