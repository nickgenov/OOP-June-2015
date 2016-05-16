namespace Paths
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        private double xCoord;
        private double yCoord;
        private double zCoord;

        public Point3D() 
            : this(0, 0, 0)
        {
        }

        public Point3D(double x) 
            : this(x, 0, 0)
        {
        }

        public Point3D(double x, double y) 
            : this(x, y, 0)
        {
        }

        public Point3D(double x, double y, double z)
        {
            this.XCoord = x;
            this.yCoord = y;
            this.ZCoord = z;
        }

        public static Point3D StartingPoint
        {
            get
            {
                return Point3D.startingPoint;
            }
        }

        public double XCoord
        {
            get
            {
                return this.xCoord;
                
            }
            set
            {
                this.xCoord = value;
                
            }
        }

        public double YCoord
        {
            get
            {
                return this.yCoord;
                
            }
            set
            {
                this.yCoord = value;
                
            }
        }

        public double ZCoord
        {
            get
            {
                return this.zCoord;
                
            }
            set
            {
                this.zCoord = value;
                
            }
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.XCoord, this.YCoord, this.ZCoord);
        }
    }
}