using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex4 {
  static void Main(string[] args) {
    float cel = 0, fah = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos converter graus Celsius para graus Fahrenheit");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite os graus em Cº: ");
    cel = float.Parse(Console.ReadLine());
    
    //Cáuculos
    fah = (cel * 9 / 5 + 32);
    
    //Apresentação de resultados
    Console.Write("Os graus em Ceslsius são Cº" + Math.Round(cel, 1).ToString() + " e em Fahrenheit são Fº" + Math.Round(fah, 1).ToString());
    
    Console.ReadKey();
  }
}