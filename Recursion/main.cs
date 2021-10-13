using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Insira um número referente à atividade desejada (1 a 10): ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine();


    switch (num)
    {
    case 1:
      Console.WriteLine("1. Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições composto de números aleatórios.\n");

      int[] rndArray = randomArray();

      Console.WriteLine("\nA soma dos elementos do vetor é: " + EX01(rndArray, 19));

      break;


    case 2:
      Console.WriteLine("2. Faça uma função recursiva que mostre o maior número presente em um vetor de números aleatórios com 20 posições.\n");

      int[] randArray = randomArray();

      Console.WriteLine("\nO maior elemento do vetor é: " + EX02(randArray, 19));

      break;


    case 3:
      Console.WriteLine("3. Faça um programa que contenha uma função capaz de inverter uma string fornecida por um usuário.\n");

      Console.Write("Digite uma palavra: ");
      string word = Console.ReadLine();

      Console.WriteLine("\nString invertida: " + EX03(word, word.Length - 1));

      break;


    case 4:
      Console.WriteLine("4. Crie uma função que calcule recursivamente a potência 𝑥^y, sendo 𝑥 e 𝑦 lidos pelo teclado.\n");

      Console.Write("Insira o valor da base: ");
      int baseNumber = int.Parse(Console.ReadLine());

      Console.Write("Insira o valor do expoente: ");
      int exponent = int.Parse(Console.ReadLine());

      Console.WriteLine("\nO resultado da operação é: " + EX04(baseNumber, exponent));

      break;


    case 5:
      Console.WriteLine("5. Faça uma função recursiva que calcule o fatorial de um número lido pelo teclado.\n");

      Console.Write("Digite um número: ");
      int number = int.Parse(Console.ReadLine());

      Console.WriteLine("\nO fatorial de " + number + " é: " + EX05(number));

      break;


    case 6:
      Console.WriteLine("6. Crie uma função recursiva que calcule a seguinte série, sendo 𝑛 lido pelo teclado:\n𝑆 = 1 + 2 − 3 + 4 − 5 + 6 − ⋯ ± n\n");

      Console.Write("Digite um número: ");
      int n = int.Parse(Console.ReadLine());

      Console.WriteLine("\nO resultado da operação é: " + EX06(n, 1));

      break;


    case 7:
      Console.WriteLine("Crie uma função recursiva que receba uma matriz e mostre o maior elemento par que ela possui.\n");

      Random rnd = new Random();
      
      int[,] M = new int[5, 5];


      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          M[i, j] = rnd.Next(10, 100);
          
          Console.Write(M[i, j] + "      ");
        }
        Console.WriteLine("\n");
      }


      Console.WriteLine("O maior número par da matriz é: " + EX07(M, 0, 0, 0));

      break;


    case 8:
      Console.WriteLine("8. Faça um programa que contenha uma função recursiva que mostre se uma frase se classifica como um palíndromo, ou seja, se lida da esquerda para a direita é igual à lida da direita para a esquerda.\n");

      Console.Write("Digite uma palavra: ");
      string str = Console.ReadLine();
      
      if (EX08(str, str.Length, 0) == 1)
      {
        Console.WriteLine("\nÉ um palíndromo!");
      }

      else
      {
        Console.WriteLine("\nNão é um palíndromo.");
      }

      break;


    case 9:
      Console.WriteLine("9. Crie um programa que contenha duas funções recursivas. A primeira transforma um número da base 10 para a base 2 e a segunda transforma um número da base 2 para a base 10.\n");

      Console.WriteLine("1- Converter decimal para binário;");
      Console.WriteLine("2- Converter binário para decimal.");
      Console.Write("\nInsira 1 ou 2 de acordo com a legenda acima: ");
      int option = int.Parse(Console.ReadLine());

      if (option == 1)
      {
        Console.Write("\nDigite um número decimal: ");
        int dec = int.Parse(Console.ReadLine());

        string bin = EX09A(dec);

        Console.WriteLine("\nResultado da conversão: " + EX03(bin, bin.Length - 1));
      }

      else if (option == 2)
      {
        Console.Write("\nDigite um número binário: ");
        string binary = Console.ReadLine();

        Console.WriteLine("\nResultado da conversão: " + EX09B(binary, (binary.Length - 1), 0));
      }

      else
      {
        System.Environment.Exit(0);
      }

      break;


    case 10:
      Console.WriteLine("10. Faça um programa que contenha funções recursivas capazes de gerar, mostrar e somar os elementos da diagonal principal de uma matriz quadrada.\n");

      int[,] matriz = new int[5, 5];

      int somaDiagonal = EX10B(EX10A(matriz, 0, 0), 0);

      Console.WriteLine("A soma dos elementos da diagonal principal da matriz é: " + somaDiagonal);

      break;
    }
  }




  static int[] randomArray() //Método para criar um vetor com vinte números aleatórios.
  {
    Random rnd = new Random();
    int[] array = new int[20];

    for (int i = 0; i < 20; i++)
    {
      array[i] = rnd.Next(0, 100);

      Console.WriteLine(array[i]);
    }
    return array;
  }
  



  static int EX01(int[] array, int num)
  {
    if (num < 0)
    {
      return 0;
    }
    
    else {
      return array[num] + EX01(array, num - 1);
    }
  }


  static int EX02(int[] array, int num)
  {
    if (num == 0)
    {
      return array[0];
    }

    else
    {
      return Math.Max(array[num], EX02(array, num - 1));
    }
  }


  static string EX03(string str, int pos)
  {
    if (pos == 0)
    {
      return str[0] + "";
    }
    
    else
    {
      return str[pos] + EX03(str, pos - 1);
    }
  }


  static int EX04(int b, int e)
  {
    if (e == 0)
    {
      return 1;
    }
    
    else
    {
      return b * EX04(b, (e - 1));
    }
  }


  static int EX05(int n)
  {
    if (n == 0) 
    {
      return 1;
    }

    else
    {
      return n * EX05(n - 1);
    }
  }


  static int EX06(int x, int y)
  {
    if (x < y)
    {
      return 0;
    }
    
    else if (y % 2 != 0 && y > 1)
    {
      return -y + EX06(x, y + 1);
    }
    
    else
    {
      return y + EX06(x, y + 1);
    }
  }


  static int EX07(int[,] M, int l, int c, int max)
  {
    if (l < 5 && c < 5)
    {
      if (M[l, c] % 2 == 0 && M[l, c] > max)
      {
        max = M[l, c];
      }
      max = EX07(M, l, c + 1, max);
      }
      
      else if (l < 5 && c == 5)
      {
        max = EX07(M, l + 1, 0, max);
      }
      return max;
  }


  static int EX08(string str, int tam, int pos)
  {
    if (pos < tam / 2)
    {
      if (str[pos] == str[tam - pos - 1])
      {
        return 1 * EX08(str, tam, pos + 1);
      }
      
      else
      {
        return 0;
      }
    }
    
    else {
      return 1;
    }
  }


  static string EX09A(int n)
  {
    if (n >= 1)
    {
      if (n % 2 == 0)
      {
        return "0" + EX09A(n / 2);
      }
      
      else
      {
        return "1" + EX09A(n / 2);
      }
    }
    
    else
    {
      return "";
    }
  }


  static double EX09B(string bin, int tam, double exp)
  {
    if (tam >= 0)
    {
      if (bin[tam] + "" == "1" + "")
      {
        return ((1 * Math.Pow(2, exp)) + EX09B(bin, (tam - 1), (exp + 1)));
      }
      
      else
      {
        return 0 + EX09B(bin, (tam - 1), (exp + 1));
      }
    }
    
    else
    {
      return 0;
    }
  }


  static int[,] EX10A(int[,] M, int l, int c)
  {
    Random rnd = new Random();
    if (l < 5 && c < 4)
    {
      M[l, c] = rnd.Next(1,10);
      Console.Write(M[l, c] + "    ");
      EX10A(M, l, c + 1);
    }
    
    else if (l < 5 && c == 4)
    {
      M[l, c] = rnd.Next(1,10);
      Console.WriteLine(M[l, c] + "    \n");
      EX10A(M, l + 1, 0);
    }
      return M;
    }


  static int EX10B(int[,] M, int index)
  {
    int sum = 0;
    
    if (index < 5)
    {
      sum = M[index, index] + EX10B(M, index + 1);
    }
    
    return sum;
  }
}