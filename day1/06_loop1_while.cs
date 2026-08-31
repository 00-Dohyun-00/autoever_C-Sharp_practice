using static System.Console;

// �ٽ� : while loop

int cnt = 0;

while(cnt < 10)
{
    WriteLine($"{cnt}");
    ++cnt;
}

cnt = 0;

while(true)
{
    WriteLine($"{cnt}");
    ++cnt;

    if(cnt == 10)
    {
        break;
    }
}