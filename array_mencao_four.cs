using System;
					
public class Program
{
	public static void Main()
	{
		int[,] matriz=new int[5,5];
		
		for(int x=0;x<5;x++){
			for(int y=0;y<5;y++){
				Console.Clear();
				Console.WriteLine("Digite o {0}o número da {1}a linha: ",y+1, x+1);
				matriz[x,y]=int.Parse(Console.ReadLine());
			}
		}
		Console.Clear();
		Console.WriteLine("Os números nas posições diagonais da matriz são: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", matriz[0,0], matriz[0,4], matriz[1,1], matriz[1,3], matriz[2,2], matriz[3,1], matriz[3,3], matriz[4,0], matriz[4,4]);
    Console.ReadKey();
	}
}