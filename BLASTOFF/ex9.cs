using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex9 {
  static void Main(string[] args) {
    int numero, resultado;
    
    //Mensagem inicial
    Console.WriteLine("Vamos ver a tabuada de um número");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite o numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    
    //Cáuculos
    for (int i = 1; i < 11; i++)
    {
        resultado = numero * i;
        //Apresentação de resultados
        Console.WriteLine (numero + " x " + i + " = " + resultado);
    }
    
    Console.ReadKey();
  }
}