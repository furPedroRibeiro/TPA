using System;
					
public class Program
{
	public static void Main()
	{
	int[] numbers=new int[15];
    int x, y=1;
    for(x=0;x<4;x++){
      Console.WriteLine("Digite o {0}o número: ", x+1);
      numbers[x]=int.Parse(Console.ReadLine());
    }
    for(x=0;x<4;x++){
		if(x%2==0){
			Console.WriteLine("{0} número em posição par do vetor: {1}", y,  numbers[x]);
			y+=1;
      }
	}
Console.ReadKey;
  }
}