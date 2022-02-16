using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex14 {
    static void Main(string[] args) {
        string palavra = string.Empty;

        //Mensagem inicial
        Console.WriteLine("Vamos saber se a palavra é um Palíndromo");
        Console.WriteLine(" ");
        
        //Recebimento de valores
        Console.WriteLine("Digite a Palavra para a verificação: ");
        palavra = Console.ReadLine();

        //Apresentação de resultados
        if (ePalindromo(palavra))
        {
            Console.WriteLine(palavra + " é um Palíndromo");
        }
        else
        {
            Console.WriteLine(palavra + " é uma Palavra qualquer");
        }
    }

//Cáuculos
    private static bool ePalindromo(string palavra)
    {
        //Converção sa palavra em um array de letras e reverção das posições.
        char[] letras = palavra.ToCharArray();
        Array.Reverse(letras);

        //Transformação das letras reversas em uma string
        string palavraReversa = new string(letras);

        //Comparação colocando em letras minúsculas
        if (RemoveOthers(palavra.ToLower()) == RemoveOthers(palavraReversa.ToLower()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Remoção de acentuação
    private static string RemoveOthers(string palavra)
    {
        palavra = palavra.Replace("À", "A");
        palavra = palavra.Replace("Â", "A");
        palavra = palavra.Replace("Á", "A");
        palavra = palavra.Replace("Ã", "A");

        palavra = palavra.Replace("à", "a");
        palavra = palavra.Replace("â", "a");
        palavra = palavra.Replace("á", "a");
        palavra = palavra.Replace("ã", "a");

        palavra = palavra.Replace("Ê", "E");
        palavra = palavra.Replace("É", "E");

        palavra = palavra.Replace("ê", "e");
        palavra = palavra.Replace("é", "e");

        palavra = palavra.Replace("Ó", "O");
        palavra = palavra.Replace("Ô", "O");

        palavra = palavra.Replace("ó", "o");
        palavra = palavra.Replace("ô", "o");

        palavra = palavra.Replace("ú", "u");

        return palavra;
    }
}