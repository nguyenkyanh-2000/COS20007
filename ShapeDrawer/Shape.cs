using SplashKitSDK;
namespace ShapeDrawer;

public class Shape
{
    private Color _color;
    private float _x;
    private float _y;
    private int _width;
    private int _height;

    public Shape()
    {
      _color = Color.Green;
      _x = 0.0f;
      _y = 0.0f;
      _width = 100;
      _height = 100;
    }

    public void Draw()
    {
       SplashKit.FillRectangle(_color, _x, _y, _width, _height);
    }

    public bool IsAt(Point2D pt)
    {
        if (_x <= pt.X && _x + _width >= pt.X && _y <= pt.Y && _y + _height >= pt.Y)
        {
            return true;
        }
        return false;
    }

    public Color Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public float X
    {
        get { return _x; }
        set { _x = value; }
    }

    public float Y
    {
        get { return _y; }
        set { _y = value; }
    }

    public int Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }
}