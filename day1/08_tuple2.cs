using static System.Console;

// #1. tuple 생성
int n = 0; // 일반변수
int[] arr = {1,2,3}; // 배열

(int, int, int) t1 = (1, 2, 3); // tuple을 만드는 정확한 표기법
var t3 = (1, 3.4, "hello");



// #2. 요소 접근
var t4 = (1, 2, 3);
t4.Item1 = 20;
Console.WriteLine("{0} {1}", t4.Item1, t4.Item2);


// #3. Named Member
(int,     int,     int)       t5 = (1,2,3); // unnamed tuple
(int one, int two, int three) t6 = (1,2,3); // named tuple

Console.WriteLine(t5.Item1);
Console.WriteLine(t6.one);


// Named Member를 만드는 2가지 기술
// 타입에 이름 표기
// 초기값에 이름 표기
(int one, int two, int three) t7 = (1,2,3); 
var t8 = (one:1, two:2, three:3);

