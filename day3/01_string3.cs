using System;
using static System.Console;

// ÇÙ½É : string intern pool

string s1 = new string("AAA");
string s2 = new string("AAA");

string s3 = "BBB";
string s4 = "BBB";

WriteLine($"{object.ReferenceEquals(s1, s2)}");
WriteLine($"{object.ReferenceEquals(s3, s4)}");