Console.Write("введите координату b1=");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату k1=");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату b2=");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату k2=");
int k2 = Convert.ToInt32(Console.ReadLine());


void CrossPoint(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}
CrossPoint(k1,b1,k2,b2);