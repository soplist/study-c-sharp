using System;
class Output
{
	static void Main(string[] args)
    {
        string a = "how ";
        a += "are you?";
        Console.WriteLine("a={0}",a);
        Console.Write("the second char of a is {0}",a[0]);
        a = "D:\\wangkang\\file\\LocalRepository\\study-c-sharp";
        Console.WriteLine("a={0}",a);
        a = @"D:\wangkang\file\LocalRepository\study-c-sharp";
        Console.WriteLine("a={0}",a);
    }
}
