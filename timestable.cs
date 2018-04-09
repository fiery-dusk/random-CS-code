using System;
namespace timestable
{class Program{
	static void Main(string[] args){
		try{
			for (int num = int.Parse(args[0]); num <= int.Parse(args[1]); num++){
				for (int cur = 0; cur <= 10; cur++)
					{Console.WriteLine(num + " * " + cur + " = " + (num*cur));}
				Console.WriteLine("");}}
		catch (Exception except){Console.WriteLine(except);}
}}}
