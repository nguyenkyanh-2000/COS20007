using SplashKitSDK;
namespace ShapeDrawer;

public abstract class Shape
{
    private Color _color;
    private float _x;
    private float _y;
    private bool _selected;


    public Shape()
    {
        this.Color = Color.Yellow;
    }
    public Shape(Color color)
    {
      _color = color;
      _x = 0.0f;
      _y = 0.0f;
    }

    public abstract bool IsAt(Point2D pt);

    public abstract void DrawOutline();

    public abstract void Draw();
    
    public bool Selected
    {
        get => _selected;
        set => _selected = value;
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
    
}