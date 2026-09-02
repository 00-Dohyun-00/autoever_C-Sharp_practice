using static System.Console;

// null-coalescing operator (?? 연산자)

int?   n1 = null;

 
int n2 = n1;    // error

int n3 = n1.GetValueOrDefault(); // ok
int n4 = n1 ?? 0; // 위와 동일

string s1 = null;
string s2 = s1;

string s3 = s1 ?? "none";



