					
public class GreaterNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter two numbers:");
		int a= Convert.ToInt32(Console.ReadLine());
		int b= Convert.ToInt32(Console.ReadLine());
		
		if(a>b)
		{
			Console.WriteLine("The Greatest Number is:"+a);
		}
		else
			Console.WriteLine("The Greatest Number is:"+b);
	}
}
