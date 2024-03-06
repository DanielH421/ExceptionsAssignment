using ExceptionsAssignment.exceptions;

namespace ExceptionsAssignment;

public class Circle
{
    private decimal radius;

    public decimal Radius
    {
        get { return radius; }
    }


    public Circle() { }


    public void SetRadius(decimal _radius)
    {
        if (_radius <= 0)
        {
            throw new InvalidRadiusException(radius);
        }
        radius = _radius;
    }


    public override string ToString()
    {
        return $"Radius: {radius}";
    }
}