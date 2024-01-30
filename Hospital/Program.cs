int countDays = int.Parse(Console.ReadLine());
int countDc = 7;

int treated = 0;
int untreated = 0;



for (int i = 1; i <= countDays; i++)
{
    int pacientes = int.Parse(Console.ReadLine());
    if (i % 3 == 0 )
    {
        if (untreated > treated)
        {
           countDc++; 
        }
        
    }

    if (countDc < pacientes)
    {
        treated += countDc;
        untreated += pacientes - countDc;
    }
    else 
    {
        treated += pacientes;
        
    }
    
    


}
Console.WriteLine($"Treated patients: {treated}.");
Console.WriteLine($"Untreated patients: {untreated}.");

