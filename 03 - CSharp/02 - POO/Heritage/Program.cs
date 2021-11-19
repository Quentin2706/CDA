using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.5, 5.5);
            Console.WriteLine(rectangle.AfficherRectangle());

            TriangleRectangle tr = new TriangleRectangle(10, 6);
            Console.WriteLine(tr.AfficherTriangleRectangle());

            Cercle cercle = new Cercle(10);
            Console.WriteLine(cercle.AfficherCercle());
            sphere sph = new sphere(10);
        }
    }
}
