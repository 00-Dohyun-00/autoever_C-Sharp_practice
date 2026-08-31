using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

var t1 = (a, b, c);


// #2. deconstruction
int x, y, z;

// 아래 코드는 tuple의 값을 각각 x,y,z에 담은 것
// => tuple을 분해(deconstruction) 한 것
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// C#에서는 위 세 줄을 아래처럼 하면 됨
(x, y, z) = t1;

// 변수 선언 자체를 () 안에
(int b1, int b2, int b3) = t1;


// #3. 아래 두 줄의 차이는?
(int a1, int a2, int a3) t2 = (1, 2, 3);  // construction
(int b1, int b2, int b3)    = (4, 5, 6);  // deconstruction

