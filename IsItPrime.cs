using System;
class IsItPrime{
	public static void Main(){
	System.Console.Write("Write a positive number: ");
	int num = int.Parse(System.Console.ReadLine());
	int divider = 2;
	int MaxDivider  = (int)Math.Sqrt(num);
	bool prime = true;
	while(prime && (divider <= MaxDivider)){
			if(num % divider == 0){
				prime = false;
			}
		divider++;
	}
	System.Console.WriteLine("Prime? " + prime);
	}

}