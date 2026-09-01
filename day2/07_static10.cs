class Date
{
    private int year = 0;
    private int month = 0;
    private int day = 0;

    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
                throw new Exception();
            month = value;
        }
    }

    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    public Date AddDays(int ds)
    {
        Date temp = new Date(year, month, day + ds); // 잘못된 구현

        return temp;
    }

    public static int HowMayDays(int m) {  return days[m-1]; }

    public static bool IsLeapYear(int y)
    {
        return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
    }
    public bool IsLeapYear()
    {
        return IsLeapYear(year); // static method를 호출
    }

    // 오늘 날짜를 반환하는 static method
    public static Date TodayM()
    {
        // 여기선 시스템 내부 함수로 오늘 날짜를 구하는 것이 가능하지만, 여기서는 간단히 2026년 9월 1일로 하드코딩
        Date temp = new Date(2026, 9, 1);
        return temp;
    }
    // 오늘 날짜를 가진 정적 필드
    public static Date Today = Date.Today();
}
class Program
{
    public static void Main()
    {
        // 일반적으로 사용자가 아래처럼 사용(날짜 하드코딩)하는 경우는 많지 않음
        Date d1 = new Date(2026, 9, 1);

        // 오늘 날짜 객체가 필요하면 아래 처럼 사용하게
        // 1과 2 중에 좋은것은?
        Date today = Date.TodayM(); // 1. 매번 새로 계산
        Date today2 = Date.Today; // 2. 한 번 계산 후 복사해서 사용

    }
}