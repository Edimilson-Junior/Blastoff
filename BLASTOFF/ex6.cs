using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex6 {
  static void Main(string[] args) {
    int h1 = 0, m1 = 0, h2 = 0, m2 = 0;
    
    //Mensagem inicial
    Console.WriteLine("Vamos saber quanto tempo a partida teve em minutos");
    Console.WriteLine(" ");
    
    //Recebimento de valores
    Console.WriteLine("Digite a hora que começou (formato 24h): ");
    h1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o minuto que começou: ");
    m1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o horário que terminou(formato 24h): ");
    h2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o minuto que terminou: ");
    m2 = int.Parse(Console.ReadLine());
    
    //Cáuculos
    TimeSpan horaIni = new TimeSpan(h1, m1, 0);
    TimeSpan horaFim = new TimeSpan(h2, m2, 0);
    
    //Apresentação de resultados
    Console.WriteLine("O jogo durou " + horaFim.Subtract(horaIni).ToString());
    
    Console.ReadKey();
  }
}