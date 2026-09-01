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

}
class Program
{
    public static void Main()
    {
        // 윤년인지 알고싶음.
        // 어떤것이 좋아보이나요?
        // => 둘 다 제공하는 것도 나쁘지 않음

        // 1. 인스턴스 메소드로 제공
        Date d = new Date(2026, 5, 1);
        bool b1 = decimal.IsLeapYear();

        // 2. static 메소드로 제공
        bool b = Date.IsLeapYear(2026);

    }
}