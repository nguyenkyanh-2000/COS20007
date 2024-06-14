namespace ShapeDrawer;
using SplashKitSDK;
public class MyRectangle: Shape
{
    private int _width;
    private int _height;

    public MyRectangle()
    {
        _width = 100;
        _height = 100;
        X = 0.0f;
        Y = 0.0f;
        Color = Color.Green;
    }
    
    public MyRectangle(Color color, float x, float y,  int width, int height) : base(color)
    {
        X = x;
        Y = y;
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
    
    public override void Draw()
    {
        if (Selected)
        {
            DrawOutline();
        }
        SplashKit.FillRectangle(Color, X, Y, _width, _height);
    }

    public override void DrawOutline()
    {
        SplashKit.DrawRectangle(Color.Black, X-2, Y-2, _width+5, _height+5);
    }

    public override bool IsAt(Point2D pt)
    {
        return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, _width, _height));
    }

    public override void SaveTo(StreamWriter writer)
    {
        writer.WriteLine("Rectangle");
        base.SaveTo(writer);
        writer.WriteLine(Width);
        writer.WriteLine(Height);
    }
    
    public override void LoadFrom(StreamReader reader)
    {
        base.LoadFrom(reader);
        _width = reader.ReadInteger();
        _height = reader.ReadInteger();
    }
}