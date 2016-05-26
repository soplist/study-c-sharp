using System;
class ClassTest4
{
	static void Main(string[] args)
    {
        int x=1;
		string y="it's ";
		y += (x==1)?"ok":"not ok";
		Console.WriteLine(y);
    }
}