using System;
          
public class Program
{
  public static void Main()
  {
    string[] alunos=new string[10];
    double[,] notas=new double[10,3];
    double[] res=new double[10];
    double[] resTrue=new double[10];
    
    for(int x=0;x<3;x++){
      Console.Clear();
      Console.Write("Digite o nome do {0}° aluno : ", x+1);
      alunos[x]=Console.ReadLine();
    }
    for(int x=0;x<3;x++){
      for(int y=0;y<3;y++){
        Console.Clear();
        Console.WriteLine("Digite a {0}a nota do {1}o aluno", y+1, x+1);
        notas[x,y]=double.Parse(Console.ReadLine());
      }
    }
    for(int x=0;x<3;x++){
      for(int y=0;y<3;y++){
        res[x]+=notas[x,y];
        resTrue[x]=res[x]/3;
      }
    }
    Console.Clear();
    Console.WriteLine("{0,15} {1,12} \t\t\t\t\t{2,6}","Alunos","Notas","Média");
    for(int x=0;x<10;x++){
      Console.WriteLine("\t\t\t\t\t{0}", alunos[x]);
      for(int y=0;y<3;y++){
        Console.Write("{0,12:N}", notas[x,y]);
      }
      for(int w=0;w<1;w++){
          if(res[x]>=7){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,6:N}", resTrue[x]);
          }
          else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,6:N}", resTrue[x]);
        }
      }
    }
    Console.WriteLine("");
  }
}