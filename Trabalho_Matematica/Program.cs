using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
  __  __       _                       _   _           
 |  \/  |     | |                     | | (_)          
 | \  / | __ _| |_ ___ _ __ ___   __ _| |_ _  ___ __ _ 
 | |\/| |/ _` | __/ _ | '_ ` _ \ / _` | __| |/ __/ _` |
 | |  | | (_| | ||  __| | | | | | (_| | |_| | (_| (_| |
 |_|  |_|\__,_|\__\___|_| |_| |_|\__,_|\__|_|\___\__,_|
                                                       
                                                       
");    
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n=========================================");
        Console.WriteLine("||      Selecione a operação:         ||");
        Console.WriteLine("||          1. Soma de vetores        ||");
        Console.WriteLine("||          2. Subtração de vetores   ||");
        Console.WriteLine("||          3. Produto Escalar        ||");
        Console.WriteLine("||          4. Multiplicação Escalar  ||");
        Console.WriteLine("||          5. Módulo de Vetor        ||");
        Console.WriteLine("||          6. Vetor AB               ||");
        Console.WriteLine("||          7. Verificar CPF          ||");
        Console.WriteLine("========================================");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
   _____                             _       __      __  _                     
  / ____|                           | |      \ \    / / | |                    
 | (___   ___  _ __ ___   __ _    __| | ___   \ \  / ___| |_ ___  _ __ ___ ___ 
  \___ \ / _ \| '_ ` _ \ / _` |  / _` |/ _ \   \ \/ / _ | __/ _ \| '__/ _ / __|
  ____) | (_) | | | | | | (_| | | (_| |  __/    \  |  __| || (_) | | |  __\__ \
 |_____/ \___/|_| |_| |_|\__,_|  \__,_|\___|     \/ \___|\__\___/|_|  \___|___/
                                                                               
                                                                               
");          
                Console.ForegroundColor = ConsoleColor.Green;    
                Console.WriteLine("Digite os valores do vetor A separados por espaço:");
                double[] vetorA = LerVetor();
                Console.WriteLine("Digite os valores do vetor B separados por espaço:");
                double[] vetorB = LerVetor();
                double[] resultado = SomaVetores(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Soma dos vetores:");
                ImprimeVetor(resultado);
                break;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
   _____       _     _                  /\/|             _       __      __  _                     
  / ____|     | |   | |                |/\/             | |      \ \    / / | |                    
 | (___  _   _| |__ | |_ _ __ __ _  ___ __ _  ___     __| | ___   \ \  / ___| |_ ___  _ __ ___ ___ 
  \___ \| | | | '_ \| __| '__/ _` |/ __/ _` |/ _ \   / _` |/ _ \   \ \/ / _ | __/ _ \| '__/ _ / __|
  ____) | |_| | |_) | |_| | | (_| | (_| (_| | (_) | | (_| |  __/    \  |  __| || (_) | | |  __\__ \
 |_____/ \__,_|_.__/ \__|_|  \__,_|\___\__,_|\___/   \__,_|\___|     \/ \___|\__\___/|_|  \___|___/
                                    )_)                                                            
                                                                                                   
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite os valores do vetor A separados por espaço:");
                vetorA = LerVetor();
                Console.WriteLine("Digite os valores do vetor B separados por espaço:");
                vetorB = LerVetor();
                resultado = SubtraiVetores(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Subtração dos vetores:");
                ImprimeVetor(resultado);
                break;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
  _____               _       _          ______               _            
 |  __ \             | |     | |        |  ____|             | |           
 | |__) _ __ ___   __| |_   _| |_ ___   | |__   ___  ___ __ _| | __ _ _ __ 
 |  ___| '__/ _ \ / _` | | | | __/ _ \  |  __| / __|/ __/ _` | |/ _` | '__|
 | |   | | | (_) | (_| | |_| | || (_) | | |____\__ | (_| (_| | | (_| | |   
 |_|   |_|  \___/ \__,_|\__,_|\__\___/  |______|___/\___\__,_|_|\__,_|_|   
                                                                           
                                                                           
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite os valores do vetor A separados por espaço:");
                vetorA = LerVetor();
                Console.WriteLine("Digite os valores do vetor B separados por espaço:");
                vetorB = LerVetor();
                double produtoEscalar = ProdutoEscalar(vetorA, vetorB);
                Console.Clear();
                Console.WriteLine("Produto Escalar dos vetores: " + produtoEscalar);
                break;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
  __  __       _ _   _       _ _                /\/|         ______               _            
 |  \/  |     | | | (_)     | (_)              |/\/         |  ____|             | |           
 | \  / |_   _| | |_ _ _ __ | |_  ___ __ _  ___ __ _  ___   | |__   ___  ___ __ _| | __ _ _ __ 
 | |\/| | | | | | __| | '_ \| | |/ __/ _` |/ __/ _` |/ _ \  |  __| / __|/ __/ _` | |/ _` | '__|
 | |  | | |_| | | |_| | |_) | | | (_| (_| | (_| (_| | (_) | | |____\__ | (_| (_| | | (_| | |   
 |_|  |_|\__,_|_|\__|_| .__/|_|_|\___\__,_|\___\__,_|\___/  |______|___/\___\__,_|_|\__,_|_|   
                      | |                   )_)                                                
                      |_|                                                                      
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite os valores do vetor A separados por espaço:");
                vetorA = LerVetor();
                Console.WriteLine("Digite o valor do escalar:");
                double escalar = double.Parse(Console.ReadLine());
                resultado = MultiplicaEscalar(vetorA, escalar);
                Console.Clear();
                Console.WriteLine("Resultado da multiplicação escalar:");
                ImprimeVetor(resultado);
                break;
            case 5:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
  __  __   __      _       _             _       __      __  _             
 |  \/  | /_/     | |     | |           | |      \ \    / / | |            
 | \  / | ___   __| |_   _| | ___     __| | ___   \ \  / ___| |_ ___  _ __ 
 | |\/| |/ _ \ / _` | | | | |/ _ \   / _` |/ _ \   \ \/ / _ | __/ _ \| '__|
 | |  | | (_) | (_| | |_| | | (_) | | (_| |  __/    \  |  __| || (_) | |   
 |_|  |_|\___/ \__,_|\__,_|_|\___/   \__,_|\___|     \/ \___|\__\___/|_|   
                                                                           
                                                                           
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite os valores do vetor A separados por espaço:");
                vetorA = LerVetor();
                double modulo = ModuloVetor(vetorA);
                Console.Clear();
                Console.WriteLine("Módulo do vetor A: " + modulo);
                break;
            case 6:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
 __      __  _                        ____   
 \ \    / / | |                 /\   |  _ \  
  \ \  / ___| |_ ___  _ __     /  \  | |_) | 
   \ \/ / _ | __/ _ \| '__|   / /\ \ |  _ <  
    \  |  __| || (_) | |     / ____ \| |_) | 
     \/ \___|\__\___/|_|    /_/    \_|____/  
                                             
                                             
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite os valores do ponto A separados por espaço:");
                double[] pontoA = LerVetor();
                Console.WriteLine("Digite os valores do ponto B separados por espaço:");
                double[] pontoB = LerVetor();
                resultado = VetorAB(pontoA, pontoB);
                Console.Clear();
                Console.WriteLine("Vetor AB:");
                ImprimeVetor(resultado);
                break;
            case 7:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
 __      __       _  __ _                   _____ _____  ______ 
 \ \    / /      (_)/ _(_)                 / ____|  __ \|  ____|
  \ \  / ___ _ __ _| |_ _  ___ __ _ _ __  | |    | |__) | |__   
   \ \/ / _ | '__| |  _| |/ __/ _` | '__| | |    |  ___/|  __|  
    \  |  __| |  | | | | | (_| (_| | |    | |____| |    | |     
     \/ \___|_|  |_|_| |_|\___\__,_|_|     \_____|_|    |_|     
                                                                
                                                                
");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Digite o CPF para verificar:");
                string cpf = Console.ReadLine();
                if (ValidarCPF(cpf))
                {
                    Console.WriteLine("CPF válido!");
                }
                else
                {
                    Console.WriteLine("CPF inválido!");
                }
                break;
        }
        Console.WriteLine("\n=============================================");
        Console.WriteLine("||                                        ||");
        Console.WriteLine("||  Deseja testar outra operação? (S/N)   ||");
        Console.WriteLine("||                                        ||");
        Console.WriteLine("=============================================");
        } while (Console.ReadLine().ToUpper() == "S");

            Console.Clear();
            Console.WriteLine("\n=========================================");
            Console.WriteLine("||                                      ||");
            Console.WriteLine("||   OBRIGADO POR RODA O MEU PROGRAMA   ||");
            Console.WriteLine("||                                      ||");
            Console.WriteLine("========================================");
            Console.ReadKey();
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

    static double[] MultiplicaEscalar(double[] vetor, double escalar)
    {
        double[] resultado = new double[vetor.Length];
        for (int i = 0; i < vetor.Length; i++)
        {
            resultado[i] = vetor[i] * escalar;
        }
        return resultado;
    }

    static double ModuloVetor(double[] vetor)
    {
        double somaQuadrados = 0;
        foreach (var elemento in vetor)
        {
            somaQuadrados += elemento * elemento;
        }
        return Math.Sqrt(somaQuadrados);
    }

    static double[] VetorAB(double[] pontoA, double[] pontoB)
    {
        if (pontoA.Length != pontoB.Length)
        {
            throw new ArgumentException("Os pontos devem ter o mesmo número de coordenadas.");
        }

        double[] vetorAB = new double[pontoA.Length];
        for (int i = 0; i < pontoA.Length; i++)
        {
            vetorAB[i] = pontoB[i] - pontoA[i];
        }
        return vetorAB;
    }

    static void ImprimeVetor(double[] vetor)
    {
        foreach (var elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        int resto = soma % 11;
        int digito1 = resto < 2 ? 0 : 11 - resto;

        if (int.Parse(cpf[9].ToString()) != digito1)
        {
            return false;
        }

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        resto = soma % 11;
        int digito2 = resto < 2 ? 0 : 11 - resto;

        return int.Parse(cpf[10].ToString()) == digito2;
    }
}
