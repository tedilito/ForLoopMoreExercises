int count = int.Parse(Console.ReadLine());
double maxE = double.MinValue;
double maxO = double.MinValue;
double minE = double.MaxValue;
double minO = double.MaxValue;

double sumE = 0;
double sumO = 0;

for (int i = 1; i <= count ; i++)
{
    double num = double.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        sumE += num;
        if (maxE < num)
        {
            maxE = num;
        }

       if (minE > num )
        {
            minE = num; 
        }
    }
    else
    {
        sumO += num;
        if (maxO < num)
        {
            maxO = num;
        }

        if (minO > num)
        {
            minO = num;
        }
    }
}
Console.WriteLine($"OddSum={sumO:f2},");
if (minO == double.MaxValue)
{
    Console.WriteLine("OddMin=No,");
}
else
{
    Console.WriteLine($"OddMin={minO:f2},");
}

if (maxO == double.MinValue)
{
    Console.WriteLine("OddMax=No,");
}
else
{
    Console.WriteLine($"OddMax={maxO:f2},");
}

Console.WriteLine($"EvenSum={sumE:f2},");

if (minE == double.MaxValue)
{
    Console.WriteLine("EvenMin=No,");
}
else
{
    Console.WriteLine($"EvenMin={minE:f2},");
}

if (maxE == double.MinValue)
{
    Console.WriteLine("EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMax={maxE:f2}");
}
