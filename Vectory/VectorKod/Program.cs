using System;

namespace VectorKod
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector1 = new(3.1, 4.3);
            Vector2D vector2 = new(5.0, 2.2);
            Vector2D vector3 = new(4.4,7.7);

            double[] zmiennaA = vector1.getComponents();
            double[] zmiennaB = vector2.getComponents();
            double[] zmiennaC = vector3.getComponents();

            double kat1 = new Polar2DAdapter(vector1).getAngle();
            double kat2 = new Polar2DAdapter(vector2).getAngle();
            double kat3 = new Polar2DAdapter(vector3).getAngle();

            Console.WriteLine(string.Format("Wektor 1: Układ kartezjański: {0}, {1}; Układ biegunowy {2}, {3}",
                zmiennaA[0], zmiennaA[1], vector1.abs(), kat1));
            Console.WriteLine(string.Format("Wektor 2: Układ kartezjański: {0}, {1}; Układ biegunowy {2}, {3}",
                zmiennaB[0], zmiennaB[1], vector2.abs(), kat2));
            Console.WriteLine(string.Format("Wektor 3: Układ kartezjański: {0}, {1}; Układ biegunowy {2}, {3}",
                zmiennaC[0], zmiennaC[1], vector3.abs(), kat3));

            Vector3DDecorator vector3D1 = new(vector1);
            Vector3DDecorator vector3D2 = new(vector2);
            Vector3DDecorator vector3D3 = new(vector3);

            double[] v1xv2 = vector3D1.cross(vector3D2).getComponents();
            double[] v2xv3 = vector3D2.cross(vector3D3).getComponents(); 
            double[] v1xv3 = vector3D1.cross(vector3D3).getComponents();
            Console.WriteLine(string.Format("Wektor 1 i 2: Iloczyn skalarny: {0}; Iloczyn wektorowy {1}, {2}, {3}",
                vector1.cdot(vector2), v1xv2[0], v1xv2[1], v1xv2[2]));
            Console.WriteLine(string.Format("Wektor 2 i 3: Iloczyn skalarny: {0}; Iloczyn wektorowy {1}, {2}, {3}",
                vector2.cdot(vector3), v2xv3[0], v2xv3[1], v2xv3[2]));
            Console.WriteLine(string.Format("Wektor 1 i 3: Iloczyn skalarny: {0}; Iloczyn wektorowy {1}, {2}, {3}",
                vector3.cdot(vector3), v1xv3[0], v1xv3[1], v1xv3[2]));
        }
    }

}
