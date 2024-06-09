using SplashKitSDK;
using System.Collections.Generic;
using ShapeDrawer;

public class Drawing
{
    private readonly List<Shape> _shapes;
    private Color _background;

    public Color Background
    {
        get => _background;
        set => _background = value;
    }

    public int ShapeCount => _shapes.Count;

    public Drawing(Color background)
    {
        _shapes = new List<Shape>();
        _background = background;
    }

    public Drawing() : this(Color.White) { }

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    public void RemoveShape(Shape shape)
    {
        _shapes.Remove(shape);
    }

    public void Draw()
    {
        SplashKit.ClearScreen(_background);
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }

    public void SelectShapesAt(Point2D pt)
    {
        foreach (var shape in _shapes)
        {
            shape.Selected = shape.IsAt(pt);
        }
    }

    public List<Shape> SelectedShapes
    {
        get
        {
            var result = new List<Shape>();
            foreach (var shape in _shapes)
            {
                if (shape.Selected)
                {
                    result.Add(shape);
                }
            }
            return result;
        }
    }
}