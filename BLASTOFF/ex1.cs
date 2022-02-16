using System;
class ex1 {
  static void Main(string[] args) {
    int i=0, j=0, k=0, x=0, y=0;
    int soma=0, media=0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos calcular A media");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite a idade I: ");
    i = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a idade J: ");
    j = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a idade K: ");
    k = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a idade X: ");
    x = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a idade Y: ");
    y = int.Parse(Console.ReadLine());
    
    //Cáuculos
    soma = (i + j + k + x + y);
    media = soma/5;
    
    //Apresentação de resultados
    Console.Write("A soma das idades é = " + soma + " anos\r\n");
    Console.Write("A média delas é de = " + media + " anos");
    
    Console.ReadKey();
  }
}