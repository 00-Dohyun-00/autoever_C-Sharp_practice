// Collection 

// #1. 일반 변수: 값을 한 개 보관
int n = 1;
double d = 3.4;
string s = "hello";

// #2. 배열, 튜플, 컬랙션(collection): 같은 타입의 값을 여러 개 보관

// 배열: 같은 타입의 값을 여러 개 보관, 고정된 크기
// javascript는 크기 고정이 없지만, C#은 배열의 크기가 고정되어있음
int[] x = {1, 2, 3, 4, 5 };

// 튜플: 다른 타입의 값을 여러 개 보관, 고정된 크기
var tp = (1, 3.4, "hello");

// 컬랙션: 같은 타입의 값을 여러 개 보관, 크기 가변
// => 언어 자체가 지원하는 타입이 아닌 class 문법으로 만들어진 것.
// => 데이터를 어떻게 보관하는가에 따라 여러가지 존재.
// => tree, linked list, hash, set 등의 자료구조를 구현한 것

List<int> s = new List<int>(); // 모든 데이터를 연속된 메모리에 보관하는 자료구조
s.Add(1);
s.Add(2);

LinkedList<int> s2 = new LinkedList<int>(); // 데이터를 떨어진 메모리에 보관하는 자료구조
s2.Add(3);
s2.Add(4);
