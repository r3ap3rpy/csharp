class HelloWorld{
	static void Main(string[] args){
		System.Console.Write("Hello World from C#!" + "\r\n");
		float floatPI = 3.14f; 
		System.Console.Write(floatPI); // 3.14
		//double doublePi = 3.14;
		//System.Console.Write(doublePi);
		double nan = double.NaN;
		System.Console.Write(nan);
		double infinity = double.PositiveInfinity;
		System.Console.Write(infinity);
		float floatPi = 3.141592653589793238f;
		double doublePi = 3.141592653589793238;
		System.Console.Write(floatPi);
		System.Console.Write(doublePi);
	}

}