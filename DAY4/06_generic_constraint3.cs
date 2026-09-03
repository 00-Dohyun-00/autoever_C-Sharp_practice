class List<T> where T : struct    // T 는 value type 이어야 한다.
{	
}

class Program 
{
	public static void Main()
	{
		List<int>    c1 = new List<int>();		// ok
		List<string> c2 = new List<string>();	// error

		Nullable<int> n = null; // ok - value타입
        Nullable<string> n = null; // error - reference 타입이라서

		// Nullable 정의 보면 :struct로 제약 걸어놔서.
    }	
}



/*
class C1<T> where T : struct           {} // value
class C2<T> where T : class            {} // reference
class C3<T> where T : class?           {} // null 가능
class C4<T> where T : notnull          {} // null 불가능 타입
class C5<T> where T : unmanaged        {} // managed 타입이 아닌 것

class C6<T> where T : new()        // 디폴트 생성자(인자없는 생성자)
{
	public void Foo()
	{
		T a = new T(); // 제약이 없으면 안됨
	}

}


// class C7<T> where T : base_class_name  {} // base_class_name으로부터 상속되어야 한다
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {} // 인터페이스를 구현해야 한다.
// class C10<T> where T : interface_name?  {}


class C11<T> where T : class, IComparable<T>
{ 
}

class C12<T, U> where T : struct  
			    where U : class
{ 
}
*/