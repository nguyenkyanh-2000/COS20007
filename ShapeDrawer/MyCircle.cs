namespace ShapeDrawer;
using SplashKitSDK;

public class MyCircle : Shape
{
    private int _radius;
    public MyCircle()
    {
        Radius = 50;
        X = 0.0f;
        Y = 0.0f;
        Color = Color.Blue;
    }
    
    public MyCircle(Color color, float x, float y, int radius) : base(color)
    {
        X = x;
        Y = y;
        Radius = radius;
    }
    
    public override void Draw()
    {
        if (Selected)
        {
            DrawOutline();
        }
        SplashKit.FillCircle(Color, X, Y, Radius);
    }
    
    public override void DrawOutline()
    {
        SplashKit.DrawCircle(Color.Black, X, Y, Radius+3);
    }
    
    public override bool IsAt(Point2D pt)
    {
        return SplashKit.PointInCircle(pt, SplashKit.CircleAt(X, Y, Radius));
    }
    public int Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }
    
    public override void SaveTo(StreamWriter writer)
    {
        writer.WriteLine("Circle");
        base.SaveTo(writer);
        writer.WriteLine(Radius);
    }
    
    public override void LoadFrom(StreamReader reader)
    {
        base.LoadFrom(reader);
        Radius = reader.ReadInteger();
    }
}