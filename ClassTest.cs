using System;
class ClassTest
{
	static void Main(string[] args)
    {
        int i = 24;
		string age;
		if(i==0)
			Console.WriteLine("i is zero");
		else
			Console.WriteLine("i is not zero");
		Console.WriteLine("please input your age:");
		age=Console.ReadLine();
		if(age=="")
		{
            Console.WriteLine("you have input none");
			return;
		}
		else
		{
			i=Convert.ToInt16(age);
			if(i<=20)
                Console.WriteLine("you are junior");
			else if(i<=80)
                Console.WriteLine("you are senior");
			else
                Console.WriteLine("you are too old");
		}
    }
}