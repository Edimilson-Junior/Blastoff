using System;

class ex7 {
  static void Main(string[] args) {
    int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    
    //Mensagem inicial
    Console.WriteLine("Vamos mostrar os números da sequência de 1 a 10");
    Console.WriteLine(" ");
    
    //Cáuculos
    for (int i = 0; i < 10; i++)
    {
        if (a[i] % 2 == 0)
        {
            //Exibição de resultado
            Console.WriteLine(a[i]);
        }
    }
    
    Console.ReadKey();
  }
}