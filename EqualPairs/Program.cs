int count = int.Parse(Console.ReadLine());
int prevNum1 = int.Parse(Console.ReadLine());
int prevNum2 = int.Parse(Console.ReadLine());
int prevSum = prevNum1 + prevNum2;
int maxDif = 0;
for (int i = 0; i < count - 1 ; i++)
{
     int num1 = int.Parse(Console.ReadLine());
     int num2 = int.Parse(Console.ReadLine());
     int sum = num1 + num2;
     int diff = Math.Abs(sum - prevSum);
       prevSum = sum;
    if (diff > maxDif)
    {
        maxDif = diff;
    }

}
if (maxDif == 0)
{
    Console.WriteLine("Yes, value=" + prevSum);
}
else
{
    Console.WriteLine("No, maxdiff=" + maxDif);
}
