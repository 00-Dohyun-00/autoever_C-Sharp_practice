using static System.Console;


// 배열의 종류 ( 173 ~ )

// #1. 일차 배열(single-dimension array)
// => 아래 코드는 int를 3개 보관
int[] arr1 = { 1, 2, 3 };
arr1[0] = 10;


// #2. 다차 배열(multi-dimensional array)
// 콤마 찍어야 함
int[,] arr2 = { { 1, 2 }, { 3, 4 } };
arr2[0, 0] = 10;


// #3. 가변 배열(jagged array)
// => 아래 코드는 요소가 3개 짜리 배열인데
// => 각 요소가 다시 배열
int[][] arr3 = new int[3][];

// 요소를 다시 생성해야 함
arr3[0] = new int[3] { 1, 2, 3 };
arr3[1] = new int[2] { 1, 2 };
arr3[2] = new int[1] { 1 };

arr3[0][0] = 0; // jagged array
arr2[0,0] = 0; // 2차원 array

