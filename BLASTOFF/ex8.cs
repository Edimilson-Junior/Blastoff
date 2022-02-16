using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex6 {
  static void Main(string[] args) {
    int numero, divisores = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos saber se um número é primo");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite o numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    
    //Cáuculos
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            divisores++;
        }
    }
    
    //Apresentação de resultados
    if (divisores == 2)
    {
        Console.WriteLine("O número " + numero + " é primo");
    }
    else
    {
        Console.WriteLine("O número " + numero + " não é primo.");
    }
    
    Console.ReadKey();
  }
}