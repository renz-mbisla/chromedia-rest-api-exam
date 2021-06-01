using System;

namespace ChromediaRestApiExam.Models
{
    public class Shape
    {
        public virtual double Perimeter { get; set; }
        public virtual double Area { get; set; }
    }

    public class Square : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Perimeter
        {
            get { return this.Width * 4; }
        }

        public override double Area
        {
            get { return this.Width * this.Height; }
        }

        public Square(double size)
        {
            this.Width = size;
            this.Height = size;
        }

        public void UpdateSize(double size)
        {
            this.Width = size;
            this.Height = size;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Perimeter
        {
            get { return (Width * 2) + (Height * 2); }
        }

        public override double Area
        {
            get { return Width * Height; }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void UpdateSize(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }

    public class Triangle : Shape
    {
        public double Left { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }

        public override double Perimeter
        {
            get { return Left + Right + Bottom; }
        }

        public override double Area
        {
            get
            {
                var sp = Perimeter / 2;
                return Math.Sqrt(sp * (sp - Left) * (sp - Right) * (sp - Bottom));
            }
        }

        public Triangle(double left, double right, double bottom)
        {
            Left = left;
            Right = right;
            Bottom = bottom;
        }

        public void UpdateSize(double left, double right, double bottom)
        {
            Left = left;
            Right = right;
            Bottom = bottom;
        }
    }
}