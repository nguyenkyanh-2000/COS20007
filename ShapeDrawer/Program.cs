// See https://aka.ms/new-console-template for more information

using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();
            
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                
                myShape.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                        Point2D pt = SplashKit.MousePosition();
                        if (myShape.IsAt(pt))
                        {
                            myShape.Color = SplashKit.RandomColor();
                        }
                }

                myShape.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}