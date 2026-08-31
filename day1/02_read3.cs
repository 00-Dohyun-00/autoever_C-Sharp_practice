using System;

// 핵심 : 입력 버퍼

Console.Write("input 1 >> ");
string s = Console.ReadLine();	 // 입력 대기
Console.WriteLine(s);			 // "ABCD"	


Console.Write("input 2 >> ");
int n = Console.Read();		
							
Console.WriteLine("{0}, {1}", n, (char)n); 	//"A"


Console.Write("input 2 >> ");
n = Console.Read();		
Console.WriteLine("{0}, {1}", n, (char)n);	
 

