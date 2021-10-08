using System;
					
public class Program
{
	public static void Main()
	{
		double[,] numeros=new double[3,5];
		int x, y;
		double[] res=new double[3];
		
		for(x=0;x<3;x++){
			Console.Clear();
			for(y=0;y<5;y++){
				Console.WriteLine("Digite o {0}o número da {1}a linha: ", y+1, x+1);
				numeros[x,y]=double.Parse(Console.ReadLine());
			}
		}
		Console.Clear();
		for(x=0;x<3;x++){
			for(y=0;y<5;y++){
				res[x]+=numeros[x,y];
			}
				Console.WriteLine("A soma dos números da {0}a linha é: "+res[x]+"", x+1);
		}
    Console.ReadKey();
	}
}