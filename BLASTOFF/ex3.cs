using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex3 {
  static void Main(string[] args) {
    int na = 0, nb = 0, nc = 0;
    int menorNumero = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos calcular quantos litros de combustível você gastou por Km");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite o número A: ");
    na = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o número B: ");
    nb = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o número B: ");
    nc = int.Parse(Console.ReadLine());
    
    //Cáuculos
    if(na < nb  &&  na < nc)
    {
        menorNumero = na;
    } 
    else if(nb < na  &&  nb < nc)
    {
        menorNumero = nb;
    } 
    else if(nc < na  &&  nc < nb)
    {
        menorNumero = nc;
    }
    
    //Apresentação de resultados
    Console.Write("O menor número é o número " + menorNumero + ".");
    
    Console.ReadKey();
  }
}