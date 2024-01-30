int count = int.Parse(Console.ReadLine());
double countTwo = 0;
double countThree = 0;
double countFour = 0;
double countFive = 0;

double totalGrade = 0;

double avg = 0;
double percent2 = 0;
double percent3 = 0;
double percent4 = 0;
double percent5 = 0;


for (int i = 0; i < count; i++)
{
    double grade = double.Parse(Console.ReadLine());
    totalGrade += grade;
  
    
    if (grade < 3.00)
    {
        countTwo++;
    }
    else if (grade >= 3.00 && grade <= 3.99)
    {
        countThree++;
    }
    else if (grade >= 4.00 && grade <= 4.99)
    {
        countFour++;
    }
    else if (grade >= 5.00)
    {
        countFive++;
    }


}
avg = totalGrade / count;
percent2 = (countTwo / count) * 100;
percent3 = (countThree / count) * 100;
percent4 = (countFour / count) * 100;
percent5 = (countFive / count) * 100;

Console.WriteLine($"Top students: {percent5:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {percent4:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {percent3:f2}%");
Console.WriteLine($"Fail: {percent2:f2}%");
Console.WriteLine($"Average: {avg:f2}");