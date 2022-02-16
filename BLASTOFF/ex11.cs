using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex11 {
  static void Main(string[] args) {
    //Mensagem inicial
    Console.WriteLine("Vamos ver a Intersecção entre os vetores A=(1, 2, 3, 4) e B=(1, 2, 5, 8)");
    Console.WriteLine(" ");
    
    int[] vetor1 = new int[] {1, 2, 3, 4};
    int[] vetor2 = new int[] {1, 2, 5, 8};

    
    StringBuilder builderInterseccao = new StringBuilder("Intersecção: {");

    //Cáuculos
    for (int i = 0; i < vetor1.Length; i++)
    {
        var list = (from b in vetor1
                    where vetor1[i] == vetor2[i]
                    select vetor1[i]).FirstOrDefault();
        if (list > 0)
        {
            builderInterseccao.Append(list).Append(" ");
        }
    }
    
    //Apresentação de resultados
    Console.WriteLine(builderInterseccao + "}");
    
    Console.ReadKey();
  }
}