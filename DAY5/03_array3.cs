using static System.Console;

// 일반적으로 변수에 대해서 어떤 연산을 하고싶다면
// 변수.메소드()
// 변수.프라퍼티
// 에서 찾으면 됨
int n = 0;
string s = n.ToString();


int[] arr = { 1, 2, 3, 4, 5 };

// #1. 배열 타입 변수는 자체 메소드와 속성이 많지 않다.
// 정렬, 뒤집기, 검색 등의 작업은 자체 메소드로 할 수 없다.
// array 클래스를 사용해야 함
int n1 = arr.Length; // 5


// #2. 배열에 관한 연산은 "Array 클래스의 static method" 활용
Array.Sort(arr);
Array.Reverse(arr);

foreach (var e in arr)
    Console.WriteLine(e);