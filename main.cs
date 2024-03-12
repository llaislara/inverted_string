using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar ao usuário que insira o texto a ser invertido
        Console.Write("Digite o texto a ser invertido: ");
        string textoOriginal = Console.ReadLine();

        // Chamar a função para inverter a string
        string textoInvertido = InverterString(textoOriginal);

        // Exibir o resultado
        Console.WriteLine("Texto original: " + textoOriginal);
        Console.WriteLine("Texto invertido: " + textoInvertido);
    }

    // Função para inverter a string
    static string InverterString(string texto)
    {
        // Converter a string em um array de caracteres
        char[] caracteres = texto.ToCharArray();

        // Definir os índices inicial e final para inverter os caracteres
        int inicio = 0;
        int fim = caracteres.Length - 1;

        // Enquanto o índice inicial for menor que o índice final
        while (inicio < fim)
        {
            // Trocar os caracteres de posição
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Avançar para o próximo caractere e retroceder para o anterior
            inicio++;
            fim--;
        }

        // Criar uma nova string com os caracteres invertidos
        string textoInvertido = new string(caracteres);

        // Retornar a string invertida
        return textoInvertido;
    }
}
