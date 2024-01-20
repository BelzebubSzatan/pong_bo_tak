using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace pong_bo_tak {
    public class Ball : ICanvasObject {
        public double X { get ; set ; }
        public double Y { get ; set ; }
        public Canvas Canvas { get ; set ; }
        public int Width { get ; set ; }
        public int Height { get ; set ; }
        public int Angle { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }
        public Ellipse Shape { get; set; }
        public double Speed { get; set; }

        public Ball(Canvas canvas, int width, int height) {
            Canvas = canvas;
            Width = width;
            Height = height;
            Speed = 2;
            Shape = new Ellipse() {
                Width = width,
                Height = height,
                Fill=new SolidColorBrush(Colors.White),
            };
            Random r = new();
            Angle = r.Next(30, 60);
            DirectionX = 1;
            DirectionY = 1;
            X = canvas.Width / 2 - width / 2;
            Y = canvas.Height / 2 - height / 2;
            Canvas.Children.Add(Shape);
            Draw();
        }

        public void Draw() {
            Canvas.SetLeft(Shape, X);
            Canvas.SetTop(Shape, Y);
        }

        public void Move() {
            X += Math.Cos(Angle) * Speed * DirectionX;
            Y += Math.Sin(Angle) * Speed * DirectionY;

            if (Y + Height >= Canvas.Height||Y-Height<=0)
                DirectionY *= -1;

            Draw();
        }

        public void Reset() {
            
        }
    }
}
