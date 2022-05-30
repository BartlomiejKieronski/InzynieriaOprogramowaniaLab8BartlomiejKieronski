using System;

namespace VectorKod
{
    public class Polar2DAdapter : IPolar2D, IVector
    {
        private readonly Vector2D srcVector;

        public Polar2DAdapter(Vector2D srcVector)
        {
            this.srcVector = srcVector;
        }
        public double abs()
        {
            return((IVector)srcVector).abs();
        }
        public double cdot(IVector param)
        {
            return ((IVector)srcVector).cdot(param);
        }
        public double[] getComponents()
        {
            return ((IVector)srcVector).getComponents();
        }
        public double getAngle()
        {
            double[] zmienna = this.getComponents();
            return Math.Atan(zmienna[1] / zmienna[0]) * (180 / Math.PI);
        }
    }
    

}
