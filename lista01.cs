//1
/*using System;
class MainClass {
  public static void Main (string[] args) {
  	string s;
    Console.WriteLine ("Digite seu nome: ");
    s= Console.ReadLine();
    Console.WriteLine($"Bem vindo ao c#, ($)");
  }
}*/

//3
/*using System;
class MainClass {
  public static void Main (string[] args) {
  	double n1, n2, n3, n4; 
  	Console.WriteLine("Digite a nota dos três primeiros bimestres:");
  	n1 = double.Parse(Console.ReadLine());
  	n2 = double.Parse(Console.ReadLine());
  	n3 = double.Parse(Console.ReadLine());
  	n4 = (60-(2*n1+2*n2+3*n3))/3;
	  	Console.WriteLine($"Nota pra passar = {n4:0.0}");
  	Console.ReadKey();
  }
}/*

//5
/*using System;
class MainClass{
	public static void Main(string[] args){
		string s;
		Console.WriteLine("Digite um valor monetario");
		s = Console.ReadLine();
		int p = s.IndexOf(",");
		string s1 = s.Substring(0, p);
		string s2 = s.Substring(p+1, 2);
		Console.WriteLine($"{s1}reais e {s2} centavos");
	}
}*/
