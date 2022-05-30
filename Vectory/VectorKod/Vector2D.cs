using System;

namespace VectorKod
{
    public class Vector2D : IVector
    {
        protected double x, y;
        public Vector2D()
        {
            x = 0;
            y = 0;
        }
        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double abs()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public double cdot(IVector param)
        {
            double[] vectorComp = param.getComponents();
            return this.x* vectorComp[0] + this.y * vectorComp[1];
        }
        public double[] getComponents()
        {
            return new double[] {this.x, this.y};
        }

    }
    

}
