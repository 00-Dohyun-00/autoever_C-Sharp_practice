using static System.Console;

class Car 
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();
		
		WriteLine( c.ToString() ); // ok

		object o = c;
	}
}

