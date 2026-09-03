using static System.Console;

class Example
{
    // ref, out 이 없이 받으면 "복사본" 생성
    // => main 에서 전달한 변수를 변경하지는 못 함
    // => 함수 내부에서만 사용 - in parameter
    public static void no_modifier_parameter(int x)
    {
        int n = x; // ok. read 가능
        x = 0; // ok. read 가능. 복사본에 쓰기

    }

    // out parameter
    // => 값을 담아주겠다는 의미. 
    // 호출자는 초기화되지 않은 변수도 전달 가능
    public static void out_parameter(out int x)
    {
        //int n = x; // error. 읽을 수 없다
        x = 0; // ok. 쓰기는 가능
               // 단, 쓰는 코드가 없으면 에러 (다음 사용시 값이 있다고 생각하고 사용할 수도 있으므로 반드시 값을 담아야 함).
    }

    // ref parameter
    // => 메소드 내부에서 r/w 모두 사용하겠다는 의도
    // => 호출자는 초기화 되지 않은 변수는 전달 할 수 없다.
    public static void ref_parameter(ref int x)
    {
        int n = x; // ok. read 가능
        x = 0; // ok. write 가능
    }
}

class Program
{
	public static void Main()
	{
		int n1;		
		int n2 = 0; 

        // out의 경우 초기화되지 않아도 전달 가능.
        //Example.out_parameter(out n1); 
        //Example.out_parameter(out n2); 

        // ref의 경우 초기화 된 것만 가능
        Example.ref_parameter(ref n1); // error
        Example.ref_parameter(ref n2); 

        // out의 경우 인자 전달 위치에서 변수를 생성할 수도 있음
        Example.out_parameter(out int n3); 
	}
}