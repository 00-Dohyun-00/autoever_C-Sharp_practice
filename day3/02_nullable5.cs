using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)

// 안전하게 사용하려면 null check

if(s2 != null)
{
    var ret3 = s2.ToString(); // ok
})

var ret4 = s2?.ToString(); // ok. null이면 null 반환, null이 아니면 ToString() 호출
