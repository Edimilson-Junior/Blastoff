using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex5 {
  static void Main(string[] args) {
    int n1 = 0, n2 = 0, resto = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos saber se dois números são múltiplos");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite o primeiro número: ");
    n1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número: ");
    n2 = int.Parse(Console.ReadLine());
    
    //Cáuculos
    resto = (n1 % n2);
    
    //Apresentação de resultados
    if (resto == 0)
    {
        Console.Write(n1 + " e " + n2 + " são números múltiplos");
    }
    else
    {
        Console.Write(n1 + " e " + n2 + " não são números múltiplos");
    }
    
    Console.ReadKey();
  }
}