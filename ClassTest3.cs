using System;
class ClassTest3
{
	static void Main(string[] args)
    {
        Console.WriteLine("0x{0:x}",0x34&0x56);
		Console.WriteLine("0x{0:x}",0x34|0x56);
		Console.WriteLine("0x{0:x}",0x34^0x56);
		Console.WriteLine("0x{0:x}",~0x56);
		Console.WriteLine(!true);
		Console.WriteLine((5>3)&&(2>4));
		Console.WriteLine((5>3)||(2>4));
    }
}