int count = int.Parse(Console.ReadLine());
double endResult = 0;


double percent1 = 0;
double counter1 = 0;

double percent2 = 0;
double counter2 = 0;

double percent3 = 0;
double counter3 = 0;

double percent4 = 0;
double counter4 = 0;

double percent5 = 0;
double counter5 = 0;

double percent6 = 0;
double counter6 = 0;

for (int i = 0; i < count; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num >= 0 && num <= 9)
    {
        endResult += num * 0.2;
        counter1++;
    }
    else if (num >= 10 && num <= 19)
    {
        endResult += num * 0.3;
        counter2++;
    }
    else if (num >= 20 && num <= 29)
    {
        endResult += num * 0.4;
        counter3++;
    }
    else if (num >= 30 && num <= 39)
    {
        endResult += 50;
        counter4++;
    }
    else if (num >= 40 && num <= 50)
    {
        endResult += 100;
        counter5++;
    }
    else
    {
        endResult /= 2;
        counter6++;
    }

}

percent1 = (counter1 / count) * 100;
percent2 = (counter2 / count) * 100;
percent3 = (counter3 / count) * 100;
percent4 = (counter4 / count) * 100;
percent5 = (counter5 / count) * 100;
percent6 = (counter6 / count) * 100;

Console.WriteLine($"{endResult:f2}");
Console.WriteLine($"From 0 to 9: {percent1:f2}%");
Console.WriteLine($"From 10 to 19: {percent2:f2}%");
Console.WriteLine($"From 20 to 29: {percent3:f2}%");
Console.WriteLine($"From 30 to 39: {percent4:f2}%");
Console.WriteLine($"From 40 to 50: {percent5:f2}%");
Console.WriteLine($"Invalid numbers: {percent6:f2}%");
