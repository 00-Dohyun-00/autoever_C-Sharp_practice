// Python 의 함수 모양
// def add(x, y):
// 	   return x + y


// #1. C# 의 함수 모양
int add1(int a, int b)
{
    return a + b;
}

int n1 = add1(1,2);

// #2. expression bodied
// 함수를 간결하게 만드는 문법
int add2(int a, int b) => a + b;



// #3. 용어
// 메소드(method) : class 안에서 만드는 함수. 인스턴스 메소드, 정적 메소드 등. C++에서는 멤버 함수라고 표현. ex) n1.ToString()
// 함수(function) : class 와 상관없이 만드는 함수. 위 소스의 add1, add2는 메소드가 아닌 함수


