Console.Write("Enter number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
	{
    Console.WriteLine($"Number: {number} - palindrom.");
  	}
  else Console.WriteLine($"Number: {number} - Not palindrom .");
}

if (number!.Length == 5)
	{
 	 CheckingNumber(number);
	}
else Console.WriteLine($"Enter another number");
