using System;
using System.Linq;

namespace Prime_number
{
	public static class Program
	{
		public static void Main()
		{
           Console.WriteLine("Enter first number :");
           int num1=int.Parse(Console.ReadLine());
           
           Console.WriteLine("=============================================");
           
           Console.WriteLine("Enter second number :");
           int num2=int.Parse(Console.ReadLine());
           
           Console.WriteLine("=============================================");
           
           for(int i=num1; i<num2; i++)
           {
           	int sum=0;
           	for(int j=2; j<=(i/2); j++)
           	{
           		if(i%j==0)
           		{
           			sum+=1;
           		}
           	}
           	if(sum==0)
           	{
           		Console.WriteLine("The number {"+i+"} is prime");
           	}
           }
		}
	}
}