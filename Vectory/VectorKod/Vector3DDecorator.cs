using System;

namespace VectorKod
{
    public class Vector3DDecorator : IVector
    {
        private readonly IVector srcVector;
        double z;
        public Vector3DDecorator(IVector srcVector)
        {
            this.srcVector = srcVector;
            this.z = 0;
        }
        public Vector3DDecorator(IVector srcVector, double z)
        {
            this.srcVector = srcVector;
            this.z = z;
        }
        public double abs()
        {
            return srcVector.abs();
        }
        public double cdot(IVector param)
        {
            return srcVector.cdot(param);
        }
        public double[] getComponents()
        {
            double[] zmienna = srcVector.getComponents();
            Array.Resize(ref zmienna, zmienna.Length+1);
            zmienna[2] = this.z;
            return zmienna;
        }
        public Vector3DDecorator cross(IVector param)
        {
            double[] zmienna1 = this.getComponents();
            double[] zmienna2 = new Vector3DDecorator(param).getComponents();
            double ix, iy, iz;
            ix = zmienna1[1] * zmienna2[2] - zmienna2[1] * zmienna1[2];
            iy = -(zmienna1[0] * zmienna2[2] - zmienna1[2] * zmienna2[0]);
            iz = zmienna1[0] * zmienna2[0] - zmienna1[1] * zmienna2[0];
            return new Vector3DDecorator(new Vector2D(ix, iy ),iz);
        }
        public IVector gtSrcV()
        {
            return srcVector;
        }
        
    }
    

}
