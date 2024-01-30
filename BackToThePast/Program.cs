double legacyMoney = double.Parse(Console.ReadLine());
int yearWork = int.Parse(Console.ReadLine());
int moneySpent = 0;
double moneyLeft = legacyMoney;


for (int i = 1800; i <= yearWork; i++)
{
    if (i % 2 == 0)
    {
        moneySpent = 12000;
        moneyLeft  -= moneySpent;
        moneySpent = 0;
    }
    else
    {
       
        moneySpent = 12000  + 50 * ((i - 1800) + 18);
        moneyLeft -= moneySpent;
        moneySpent = 0;
    }
}

if (moneyLeft < 0)
{
    
    Console.WriteLine($"He will need {Math.Abs(moneyLeft):f2} dollars to survive.");
}
else if (moneyLeft >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
}