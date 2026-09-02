using static System.Console;

// 핵심 : 어떤 타입이 "value type" 인지 "reference type"
//        인지를 정확히 알아야 한다.

// c#의 모든 타입은 아래 두 가지로 분류됨

// 1. reference type : 객체 자체는 힙에 생성되고 스택에 있는 레퍼런스 변수가 그 객체를 가리킴

// 2. value type : 객체 자체가 스택에 생성됨
//                  struct 키워드를 사용해서 만드는 타입

// [참고] 파이썬은 모든 변수가 reference type임. (객체 자체가 힙에 생성되고 스택에 있는 레퍼런스 변수가 그 객체를 가리킴)

//==========================================================================================================

// 1. int, double, bool, char, struct 등은 value type임

int n1 = 10;
int n2 = n1;

n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	

// 2. string, class 등은 reference type임

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // XY AB
                          // 이유: string은 reference type이지만, string은 immutable(불변) 타입이기 때문에
                          // s1의 값을 바꾸면 새로운 문자열 객체가 생성되고 s1은 그 새로운 객체를 가리키게 됨.
                          // 따라서 s2는 여전히 원래의 "AB" 문자열을 가리킴.
                          // int 등은 struct로 만들고 string은 class로 만들었기 때문에 이런 차이가 발생함.
                          // struct란 값 타입을 만들기 위한 키워드이고, class란 참조 타입을 만들기 위한 키워드임.