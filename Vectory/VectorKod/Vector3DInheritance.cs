using System;

namespace VectorKod
{
    public class Vector3DInheritance : Vector2D
    {
        double z;
        public Vector3DInheritance() : base()
        {
            z = 0;
        }
        public Vector3DInheritance(double x, double y) : base(x, y)
        {
            z = 0;
        }
        public Vector3DInheritance(double z, double x, double y)
        {
            this.z = z;
            this.x = x;
            this.y = y;
        }
        public new double abs()
        {

            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));

        }
        public new double cdot(IVector param)
        {

            double[] vectorcomp2 = param.getComponents();
            return this.x * vectorcomp2[0] + this.y * vectorcomp2[1] + this.z * vectorcomp2[2];

        }
        public new double[] getComponents()
        {
            return new double[] {this.x, this.y, this.z}; 
        }
        public  Vector3DInheritance cross(IVector param)
        {
            double[] zmienna1 = this.getComponents();
            double[] zmienna2 = param.getComponents();
            return new Vector3DInheritance(
                zmienna1[1] * zmienna2[2] - zmienna2[1] * zmienna2[2],
                -(zmienna1[0] * zmienna2[2] - zmienna1[2] * zmienna2[0]),
                zmienna1[0] * zmienna2[1] - zmienna1[1] * zmienna2[0]
                );
        }
        public IVector getSrcV()
        {
            return new Vector2D(this.x, this.y);
        }
    }
    

}
