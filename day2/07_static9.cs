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

}
class Program
{
    public static void Main()
    {
        // 5월달이 며칠까지 있는지 알고싶다
        // 다음 중 편리해 보이는 것은?
        // => 2번. 기준 날짜가 필요한 것이 아니므로.

        // 1. 인스턴스 메소드로 제공
        //Date d = new Date(2026.5.1);
        //int ds1 = d.HowMayDays();

        // 2. static 메소드로 제공
        int ds2 = Date.HowMayDays(5);

        //내일 날짜를 구하고 싶음
        // => 특정 날짜가 필요 -> 인스턴스 메소드로 제공
        //Date d3 = new Date(2026, 9, 1)
        //Date d4 = d3.Tomorrow();

        //// static method 좋지 않은 선택
        //Date d5 = Date.Tomorrow(2026,9,1)

    }
}