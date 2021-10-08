using System;
class Program{
  static void Main(string[] args){
      string[,]matriz= new string[3,3];
      string[] jogador =new string[2];
      int contador=0;
      bool fim =false;
      Jogadores(jogador);
      iniciarTabuleiro(matriz);
      mostrarTabuleiro(matriz);
      do{
        Jogar(contador, matriz);
      }while(contador<9 && fim!=true)
  }
static bool validaJogada(int jogada, string[,] matriz){
  bool j=false
  switch(jogada){
    case 1:
    if(matriz[0,0] != "O" && matriz[0,0] != "X"){
      j=true;
    }
    break;
    case 2:
     if(matriz[0,1] != "O" && matriz[0,1] != "X"){
      j=true;
    break;
    case 3:
     if(matriz[0,2] != "O" && matriz[0,2] != "X"){
      j=true;
    break;
    case 4:
     if(matriz[1,0] != "O" && matriz[1,0] != "X"){
      j=true;
    break;
    case 5:
     if(matriz[1,1] != "O" && matriz[1,1] != "X"){
      j=true;
    break;
    case 6:
     if(matriz[1,2] != "O" && matriz[1,2] != "X"){
      j=true;
    break;
    case 7:
     if(matriz[2,0] != "O" && matriz[2,0] != "X"){
      j=true;
    break;
    case 8:
     if(matriz[2,1] != "O" && matriz[2,1] != "X"){
      j=true;
    break;
    case 9:
     if(matriz[2,2] != "O" && matriz[2,2] != "X"){
      j=true;
    break;
  }
}
  static void Jogar(string[] j, String[,] matriz){
    int jogada,y, w;
    string simbol="";
    bool x= false;
    do{
    Console.WriteLine("{0} digite sua jogada: "j[contador]);
    jogada=int.Parse(Console.ReadLine());
    if(jogada<=9 && jogada>=1){
    for(y=0;y<3;y++){
        for(w=0;w<3;w++){
          if(matriz[y,w]==jogada){
            simbol=(contador%2==0) ? "O" : "X";
            matriz[y,w]=simbol;
          } 
        }
    }
    contador++;
  }else{
    Console.Write(" >> Jogada inválida!!! pressione ENTER para continuar.");
    Console.ReadLine();
    Console.Clear();
  }
    }while(!x)
  }
  staic void Jogadores(String[] players){
    Console.WriteLine("Digite o nome do 1° jogador: ");
    string[0]=Console.ReadLine();
    Console.WriteLine("Digite o nome do 2° jogador: ");
    string[1]=Console.ReadLine();
  }

  static void iniiarTabuleiro(String[,] matriz){
      int x=1, y, w;
      for(y=0;y<3;y++){
        for(w=0;w<3;w++){
          matriz[y,w]=""+x;
          x++;
        }
      }
  }
      static void mostrarTabuleiro(String[,] matriz){
      int x=1, y, w;
      for(y=0;y<3;y++){
        for(w=0;w<3;w++){
                    Console.Write("{0}", matriz[y,w]=x);
        
        Console.WriteLine("");
      }
  }
      }
}