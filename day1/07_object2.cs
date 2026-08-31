using static System.Console;

// 핵심 : 대부분의 타입은 object 로 부터 파생 된다.

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
