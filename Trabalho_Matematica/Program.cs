using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n=========================================");
        Console.WriteLine("||      Selecione a operação:         ||");
        Console.WriteLine("||          1. Soma                   ||");
        Console.WriteLine("||          2. Subtração              ||");
        Console.WriteLine("||          3. Produto Escalar        ||");
        Console.WriteLine("========================================");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os valores do vetor A separados por espaço:");
        double[] vetorA = LerVetor();

        Console.WriteLine("Digite os valores do vetor B separados por espaço:");
        double[] vetorB = LerVetor();
   
        switch (opcao)
        {
            case 1:
                // Soma dos vetores
                double[] soma = SomaVetores(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Soma dos vetores:");
                ImprimeVetor(soma);
                break;
            case 2:
                // Subtração dos vetores
                double[] subtracao = SubtraiVetores(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Subtração dos vetores:");
                ImprimeVetor(subtracao);
                break;
            case 3:
                // Produto Escalar
                double produtoEscalar = ProdutoEscalar(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Produto Escalar dos vetores: " + produtoEscalar);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static double[] LerVetor()
    {
        string[] valores = Console.ReadLine().Split(' ');
        double[] vetor = new double[valores.Length];
        for (int i = 0; i < valores.Length; i++)
        {
            vetor[i] = double.Parse(valores[i]);
        }
        return vetor;
    }

    static double[] SomaVetores(double[] vetorA, double[] vetorB)
    {
        double[] resultado = new double[vetorA.Length];
        for (int i = 0; i < vetorA.Length; i++)
        {
            resultado[i] = vetorA[i] + vetorB[i];
        }
        return resultado;
    }

    static double[] SubtraiVetores(double[] vetorA, double[] vetorB)
    {
        double[] resultado = new double[vetorA.Length];
        for (int i = 0; i < vetorA.Length; i++)
        {
            resultado[i] = vetorA[i] - vetorB[i];
        }
        return resultado;
    }

    static double ProdutoEscalar(double[] vetorA, double[] vetorB)
    {
        double resultado = 0;
        for (int i = 0; i < vetorA.Length; i++)
        {
            resultado += vetorA[i] * vetorB[i];
        }
        return resultado;
    }

    static void ImprimeVetor(double[] vetor)
    {
        foreach (var elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
