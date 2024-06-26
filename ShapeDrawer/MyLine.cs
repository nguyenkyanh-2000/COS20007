using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private int _length;
        
        public MyLine()
        {
            _length = 100;
            X = SplashKit.MouseX();
            Y = 0.0f;
            Color = Color.Red;
        }

        public MyLine(Color color, int length) :base(color)
        {
            _length = length;
        }
        

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, X + _length,Y);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X-2, Y-2, _length+5,5);

        }

        public override bool IsAt(Point2D p)
        {
            return SplashKit.PointOnLine(p, SplashKit.LineFrom(X, Y, X + _length,Y));
        }


        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
            base.SaveTo(writer);
            writer.WriteLine(_length);
        }
        
        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _length = reader.ReadInteger();
        }
    }
}