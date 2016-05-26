delegate void MyDelegate(float i);
class Output
{
	static void Main(string[] args)
    {
        DelegateA(new MyDelegate(DelegateFunction));
    }
	public static void DelegateFunction(float i)
	{
        System.Console.WriteLine("called by delegate with number:{0}",i);
	}
	public static void DelegateA(MyDelegate Function)
	{
        Function(100.01f);
	}
}