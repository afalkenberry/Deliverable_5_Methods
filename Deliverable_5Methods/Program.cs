// See https://aka.ms/new-console-template for more information
using System;

namespace Deliverable_5Methods
{
	class Program
	{
		static int[] Random_Array(int array_length)
		{
			Random rand = new Random();
			int[] MyArray = new int[array_length];
			for (int i = 0; i < array_length; i++)
			{
				MyArray[i] = rand.Next(10, 50);
			}
			return MyArray;
		}

		static int sum(int[] Array)
		{
			int MySum = Array.Sum();
			return MySum;
		}




		static void Main(string[] args)
		{

			
				try
				{
					Console.WriteLine("Enter an integer number between 5 and 15: ");
					int input = int.Parse(Console.ReadLine());
					
					if (input >= 5 && input <= 15)
					{
						int[] myArray = Random_Array(input);
						Console.Write("The elements in the random array are: ");

						foreach (int i in myArray)
						{
							Console.Write(i + " ");
						}

						Console.WriteLine("\nThe sum is: " + sum(myArray));
					}
					else
					{
						Console.WriteLine("Enter an integer within the acceptable range");
					}

				}
				catch
				{
					Console.WriteLine("Enter an integer data type");

				}

			/*Console.WriteLine("Enter a number 5 -> 15");
			int input;

					**other way I was trying to use for input validation**
			try
			{
				while (!int.TryParse(Console.ReadLine(), out input) || (input > 5 || input < 15))
				{
					Console.Clear();
					Console.WriteLine("Please enter a number between 5-15");
					Console.WriteLine("Enter a number 5 -> 15");

				}
			}

			catch
			{
				Console.WriteLine("Please enter a valid int");
			}*/















		}


	}
}






 /*void Method1()
{
	/*int[] array = new int[] { };
	Random rand = new Random();
	int num = rand.Next(10, 51);
	array = array.Append(num).ToArray();
	Console.WriteLine(array.ToString());
	

	//New block of code to test


	int[] array1 = new int[0];
	int completeArray, position, Number;
	completeArray = int.Parse(Console.ReadLine());
	array1 = new int[completeArray];
	Console.WriteLine(array1.ToString());

}


void Method2(int sum)
{
	
	for (int i = 0; i < numbers.Length; i++)
	{
		sum += numbers[i];
	}
	Console.WriteLine(sum.ToString());
}
 */
 



