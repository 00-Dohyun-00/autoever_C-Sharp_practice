using System;
using static System.Console;

string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}"); 

s2[0] = 'X'; 

WriteLine($"{object.ReferenceEquals(s1, s2)}");

s2 = "XY"; 

WriteLine($"{object.ReferenceEquals(s1, s2)}");

WriteLine($"{s1} {s2}"); 

