int count = int.Parse(Console.ReadLine());

double priceElect = 0;
double totalElect = 0;

double priceWat = 20;
double totalWat = 0;

double priceInt = 15;
double totalInt = 0;

double priseOth = 0;
double avg = 0;


for (int i = 0; i< count; i++)
{
    priceElect = Convert.ToDouble(Console.ReadLine());

    totalElect += priceElect;
    totalWat += priceWat;
    totalInt += priceInt;
    priseOth += (priceElect + priceWat + priceInt) + 0.2 * (priceElect + priceWat + priceInt);


}
avg = (totalElect + totalWat + totalInt + priseOth) / count;

Console.WriteLine($"Electricity: {totalElect:f2} lv");
Console.WriteLine($"Water: {totalWat:f2} lv");
Console.WriteLine($"Internet: {totalInt:f2} lv");
Console.WriteLine($"Other: {priseOth:f2} lv");
Console.WriteLine($"Average: {avg:f2} lv");
