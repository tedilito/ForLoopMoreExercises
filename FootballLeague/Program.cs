int capacityStadium = int.Parse(Console.ReadLine());
double cap = capacityStadium;
double percentCap = 0;

int count = int.Parse(Console.ReadLine());

double countA = 0; 
double percentA = 0;

double countB = 0;
double percentB = 0;

double countV = 0; 
double percentV = 0;

double countG = 0;
double percentG = 0;

for  (int i = 0; i < count; i++)
{
    char zone = char.Parse(Console.ReadLine());

	switch (zone)
	{
		case 'A':
			countA++;
			break;

		case 'B':
			countB++;
			break;

		case 'V':
			countV++;
			break;

		case 'G':
			countG++;
			break;

	}
}
percentA = (countA / count) * 100;
percentB = (countB / count) * 100;
percentV = (countV / count) * 100;
percentG = (countG / count) * 100;
percentCap = (count / cap) * 100;

Console.WriteLine($"{percentA:f2}%");
Console.WriteLine($"{percentB:f2}%");
Console.WriteLine($"{percentV:f2}%");
Console.WriteLine($"{percentG:f2}%");
Console.WriteLine($"{percentCap:f2}%");
