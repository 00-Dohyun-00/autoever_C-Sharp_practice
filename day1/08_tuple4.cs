using static System.Console;

// #1. 함수는 기본 적으로 한개의 값을 반환 합니다.
string Get1()       
{
    return "john";
}

string ret1 = Get1();  

// #2. 함수에서 2개 이상 반환하려면 tuple사용
(string, int, int) Get2()       
{
    return ("john", 20, 180);
}

(string, int, int) ret2 = Get2();  

Console.WriteLine(ret2);
Console.WriteLine($"{ret2.Item1}, {ret2.Item2}, {ret2.Item3}");

// #3. 2번 예제는 named member를 사용하는 것이 좋다
(string name, int age, int height) Get3()       
{
    return ("john", 20, 180);
}

var ret3 = Get3();  

Console.WriteLine($"{ret3.name}, {ret3.age}, {ret3.height}");


