namespace Playground;

public class Rectangle
{
    private readonly int _width;
    private readonly int _length;

    public Rectangle(int width = 0, int length = 0)
    {
        _width = width;
        _length = length;
    }


    public override string ToString()
    {
        return $"Rectangle width: {_width}, height: {_length}";
    }
}
