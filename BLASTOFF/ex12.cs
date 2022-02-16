using System.Text;
using System.Threading.Tasks;

class ex12 {
  static void Main(string[] args) {
    //Mensagem inicial
    Console.WriteLine("Vamos ver a Concatenação entre os vetores A=(1, 2, 3, 4) e B=(1, 2, 5, 8)");
    Console.WriteLine(" ");
    
    int[] vetor1 = new int[] {1, 2, 3, 4};
    int[] vetor2 = new int[] {1, 2, 5, 8};

    
    StringBuilder builderConcatenacao = new StringBuilder("Concatenação: ");

    //Cáuculos
    for (int i = 0; i < vetor1.Length; i++)
    {
        builderConcatenacao.Append(vetor1[i].ToString() + vetor2[i].ToString()).Append(" ");
    }
    
    //Apresentação de resultados
    Console.WriteLine(builderConcatenacao);
    
    Console.ReadKey();
  }
}