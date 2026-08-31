// type 메소드
/*
인스턴스 메소드 : "변수.메소드이름()"으로 호출
                변수가 보관중인 값과 관련된 연산
정적 메소드 : "타입.메소드이름()"으로 호출
            타입 자체와 관련된 연산
*/

int n1 = 10;

string s = n1.ToString();
int n2 = int.Max(1,2);

int n = int.Parse("30");
double d = double.Parse("3.3");

Console.WriteLine("hell0"); // Console : 클래스 이름
                            // WriteLine : Console의 정적 메소드


// int    n = 0;
// double d = 0;
// string s = "A";

// object o1 = n;
// object o2 = d;
// object o3 = s;

// System.Object o4 = n;
// System.Object o5 = d;
// System.Object o6 = s;