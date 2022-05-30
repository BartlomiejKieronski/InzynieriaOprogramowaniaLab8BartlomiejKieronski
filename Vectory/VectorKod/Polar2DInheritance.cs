using System;

namespace VectorKod
{
    public class Polar2DInheritance : Vector2D 
    {
        public double getAngle()
        {
            double[] zmienna = this.getComponents();
            return Math.Atan(zmienna[1] / zmienna[0] / 0) * (180 / Math.PI);
        }
    }
    

}
