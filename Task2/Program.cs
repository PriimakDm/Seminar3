// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//            _____________________________
// формула d=V(x1-x2)кв+(y1-y2)кв+(z1-z2)кв
double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return dist;
}
Console.WriteLine("Input x coord of point_1: ");
double xCrd1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y coord of point_1: ");
double yCrd1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z coord of point_1: ");
double zCrd1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x coord of point_2: ");
double xCrd2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y coord of point_2: ");
double yCrd2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z coord of point_2: ");
double zCrd2 = Convert.ToDouble(Console.ReadLine());
double dist_1_2 = Distance(xCrd1, xCrd2, yCrd1, yCrd2, zCrd1, zCrd2);
Console.WriteLine($"Distance between points " + dist_1_2);