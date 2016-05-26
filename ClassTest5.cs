using System;
class ClassTest5
{
	static void Main(string[] args)
    {
        byte var = 255;
		unchecked
		{
			var++;
		}
		Console.WriteLine(var);
    }
}