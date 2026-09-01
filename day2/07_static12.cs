class Program
{
    public static void Main()
    {
        // 이미 c# 표준에 날짜 타입 있음.
        // DateTime : 날짜와 시간을 다루는 타입

        DateTime dt1 = DateTime.Todday; // 오늘 날짜 12:00으로 초기화
        DateTime dt2 = DateTime.Now; // 오늘 날짜 현재 시간

        console.WriteLine(dt2);

        DateTime dt3 = dt2.AddDays(1000);
        console.writeLine(dt3);

    }
}