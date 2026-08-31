

// while : 조건을 먼저 조사 후 true 이면 실행
// do-while : 먼저 실행 후 조건 조사

int cnt = 20;

while(cnt < 10) // 처음부터 조건이 false라서 아래 코드는 실행 안 됨
{
    Console.WriteLine($"{cnt}");
    ++cnt;
}

do
{
    Console.WriteLine($"{cnt}");
    ++cnt;
}while(cnt < 10); // 한 번 실행 후 조건 조사

// 언제 쓰나
// ex 사용자에게 3의 배수를 입력받아야 한다, 그러나 입력받은게 3의 배수가 아니면 제대로 입력 할 때 까지 다시 입력.

int num;

do
{
    Console.Write("3의 배수 입력 >>");
    string s = Console.ReadLine();
    num = Convert.ToInt32(s);
}while(num % 3 != 0);