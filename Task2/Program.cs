// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//            _____________________________
// формула d=V(x1-x2)кв+(y1-y2)кв+(z1-z2)кв
double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double dist = Math.Sqrt(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
    return dist;
}