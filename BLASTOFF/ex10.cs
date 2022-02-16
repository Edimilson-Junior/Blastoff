using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex10 {
  static void Main(string[] args) {
    int i, numero, fatorial;
    
    //Mensagem inicial
    Console.WriteLine("Vamos ver a o resultado fatorial de um número");
    Console.WriteLine(" ");
    
    
    //Recebimento de valores
    Console.WriteLine("Digite o numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    
    fatorial = numero;
    
    //Cáuculos
    for (i = numero - 1; i >= 1; i--)
    {
        fatorial = fatorial * i;
    }
    
    //Apresentação de resultados
    Console.WriteLine("Valor total do Fatorial: " + fatorial);
    
    
    Console.ReadKey();
  }
}