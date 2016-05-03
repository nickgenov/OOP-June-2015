using System;

namespace PlayWithClasses
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle()
        {
        }

        public Rectangle(int size)
            : this(size, size)
        {
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Area
        {
            get
            {
                int area = this.Width*this.Height;
                return area;
            }
        }

        public override string ToString()
        {
            return string.Format("Rectangle ({0}, {1})", this.Width, this.Height);
        }

        public void Print()
        {
            Console.WriteLine("I am a rectangle!");
        }
    }
}