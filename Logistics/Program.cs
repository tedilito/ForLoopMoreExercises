int count = int.Parse(Console.ReadLine());
double totalPrice = 0;
double totalWeight = 0;

double percentMB = 0;
double tonPerMB = 0;

double percentKM = 0;
double tonPerKM = 0;

double percentVK = 0;
double tonPerVK = 0;

for (int i = 0; i < count; i++)
{
    int weight = int.Parse(Console.ReadLine());
    totalWeight += weight;
    if (weight <= 3) // mikrobus
    {
        tonPerMB += weight;
        totalPrice += weight * 200;
    }
    else if (weight <= 11) // kamion
    {
        tonPerKM += weight;
        totalPrice += weight * 175;
    }
    else if (weight >= 12) // vlak
    {
        tonPerVK += weight;
        totalPrice += weight * 120;
    }
}
double average = totalPrice / totalWeight;
percentMB = (tonPerMB / totalWeight) * 100;
percentKM = (tonPerKM / totalWeight) * 100;
percentVK = (tonPerVK / totalWeight) * 100;

Console.WriteLine($"{average:f2}");
Console.WriteLine($"{percentMB:f2}%");
Console.WriteLine($"{percentKM:f2}%");
Console.WriteLine($"{percentVK:f2}%");