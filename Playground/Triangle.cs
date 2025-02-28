namespace Playground;

public class Triangle
{
    int _base;
    int _height;
        
    public Triangle(int baseLength, int height) {
        _base = baseLength;
        _height = height;
    }
        
    public int CalculateArea () {
        return (_base + _height) / 2 ;
    }
        
    public string AsString() {
        return $"Base is {_base}, height is {_height}";
    }
}