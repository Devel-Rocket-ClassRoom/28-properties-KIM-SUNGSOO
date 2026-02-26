using System;
using System.Data.SqlTypes;

// README.md를 읽고 아래에 코드를 작성하세요.

Rectangle rectangle1 = new Rectangle(10,5);
Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {rectangle1.Width}, 세로: {rectangle1.Height}");
Console.WriteLine($"넓이: {rectangle1.Area}");
Console.WriteLine($"둘레: {rectangle1.Perimeter}");
Console.WriteLine($"정사각형: {rectangle1.IsSquare}");
Rectangle rectangle2 = new Rectangle(7, 7);
Console.WriteLine("=== 사각형 2 ===");
Console.WriteLine($"가로: {rectangle2.Width}, 세로: {rectangle2.Height}");
Console.WriteLine($"넓이: {rectangle2.Area}");
Console.WriteLine($"둘레: {rectangle2.Perimeter}");
Console.WriteLine($"정사각형: {rectangle2.IsSquare}");
Rectangle rectangle3 = new Rectangle(1, 1);
Console.WriteLine("=== 사각형 3 ===");
Console.WriteLine($"가로: {rectangle3.Width}, 세로: {rectangle3.Height}");
Console.WriteLine($"넓이: {rectangle3.Area}");
Console.WriteLine($"둘레: {rectangle3.Perimeter}");
Console.WriteLine($"정사각형: {rectangle3.IsSquare}");


class Rectangle
{
    private int _width = 1;
    private int _height = 1;
    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public int Width
    {
        get { return _width; } 
    }

    public int Height
    {
        get { return _height; } 
    }

    public int Area
    {
        get { return _width * _height; }
    }
    public int Perimeter
    {
        get { return 2 * (_height + _width); }
    }
    
    public string IsSquare
    {
        get
        {
            if (Width == Height)
            {
                return "True";
            }
            return "False";
        }
            
    }
    
}