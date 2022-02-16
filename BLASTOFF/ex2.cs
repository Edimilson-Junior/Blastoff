using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex2 {
  static void Main(string[] args) {
    float comb = 0, dist = 0;
    float lPorKm = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos calcular quantos litros de combustível você gastou por Km");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite a quantidade de combustível gasto em litros: ");
    comb = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite quantos quilômetros você percorreu: ");
    dist = float.Parse(Console.ReadLine());
    
    //Cáuculos
    lPorKm = comb/dist;
    
    //Apresentação de resultados
    Console.Write("Você gastou aproximadamente" + Math.Round(lPorKm, 2).ToString() + " litros por quilômetro!");
    
    Console.ReadKey();
  }
}