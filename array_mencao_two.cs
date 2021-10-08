using System;
					
public class Program
{
	public static void Main(){
 	int x, y, m=0, n;
	double maxValor;
    string[] nomes=new string [10];
    double[] precos=new double [10];
		for (x=0;x<3;x++){     // for nomes
	Console.Write("Digite o nome do {0}º produto: ",x+1);
	nomes[x]=Console.ReadLine();
			for (y=0;y<1;y++){      // for das notas
		Console.Write("Digite o preço do {0}º produto: ",x+1);
		precos[x]=double.Parse(Console.ReadLine());
	}
			Console.Clear();
}
		Console.Clear();
		do{
		Console.WriteLine("********Pesquisa de produtos********");
		Console.WriteLine("\n\nDigite o valor máximo: ");
		maxValor=double.Parse(Console.ReadLine());
			for(n=0;n<10;n++){
			if(precos[n]<=maxValor){
					Console.WriteLine("Produto: {0}                Preço: {1:N2} R$", nomes[n], precos[n]);
				}
			}
			Console.WriteLine("\n\n\nDeseja consultar novamente?\n 1-sim\n 2-não");
			m=int.Parse(Console.ReadLine());
			if(m==1){
				Console.Clear();
				m=1;
			}
			else{
				Console.Clear();
				Console.WriteLine("Tchau :)");
			}
		}while(m==1);
		
    Console.ReadKey();
	}
}