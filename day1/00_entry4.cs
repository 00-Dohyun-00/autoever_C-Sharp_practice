// 엔트리 포인트

// Top Level Programming 방식의 한계

System.Console.WriteLine("hello, C#");

// C#에서 지원하는 일부 문법이 Top Level에서는 에러
// 동일이름의 함수를 여러개 만들 수 있지만
// Top Level 방식에서는 에러

// int square(int a){return a;}
// double square(double a){return a;}

// 에러의 원인 => 위 코드는 결국 컴파일러에 의해 main 함수 안으로 들어가는데 함수 안에 만드는 함수는 이름이 동일하면 안 된다는 문법 존재
// 결론 => top level 방식은 개인적인 간단한 테스트용으로만.