using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for (int i = 0; i<10; i++)
{
    WriteLine($"{x[i]}");
}

foreach(int e in x)
{
    WriteLine($"{e}");
}