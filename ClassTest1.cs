using System;
class ClassTest1
{
	static void Main(string[] args)
    {
        string strvar;
		int classnumber;
		Console.WriteLine("please input your class number:");
		strvar=Console.ReadLine();
		if(strvar=="")
		{
            Console.WriteLine("you have inputed none");
			return;
		}
		else
		{
			classnumber = Convert.ToInt16(strvar);
			switch(classnumber)
			{
				case 1:
					Console.WriteLine("you are in class 1");
				    break;
				case 2:
					Console.WriteLine("you are in class 2");
				    break;
				case 3:
					Console.WriteLine("you are in class 3");
				    break;
				case 4:
					Console.WriteLine("you are in class 4");
				    break;
				default:
                    Console.WriteLine("you class number is not exist");
				    break;
			}
		}
    }
}