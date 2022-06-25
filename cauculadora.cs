// public static void CalcularSoma()
// {
//     double a, b, resultado;

//     Console.WriteLine("--- Soma A+B ---\n");
//     Console.WriteLine("Digite os valores.");

//     Console.Write("A = ");
//     a = Convert.ToDouble(Console.ReadLine());
//     Console.Write("B = ");
//     b = Convert.ToDouble(Console.ReadLine());

//     resultado = a + b;

//     Console.WriteLine($"{a} somado com {b} é {resultado}");

//     Console.WriteLine("\nPressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;
// }

// public static void CalcularSubtracao()
// {
//     double a, b, resultado;

//     Console.WriteLine("--- Subtração A-B ---\n");
//     Console.WriteLine("Digite os valores.");

//     Console.Write("A = ");
//     a = Convert.ToDouble(Console.ReadLine());
//     Console.Write("B = ");
//     b = Convert.ToDouble(Console.ReadLine());

//     resultado = a - b;

//     Console.WriteLine($"{a} subtraindo {b} é {resultado}");

//     Console.WriteLine("\nPressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;
// }

// public static void CalcularMultiplicacao()
// {
//     double a, b, resultado;

//     Console.WriteLine("--- Multiplicação A*B ---\n");
//     Console.WriteLine("Digite os valores.");

//     Console.Write("A = ");
//     a = Convert.ToDouble(Console.ReadLine());
//     Console.Write("B = ");
//     b = Convert.ToDouble(Console.ReadLine());

//     resultado = a * b;

//     Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

//     Console.WriteLine("\nPressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;
// }

// public static void CalcularDivisao()
// {
//     double a, b, resultado;

//     Console.WriteLine("--- Divisão A/B ---\n");
//     Console.WriteLine("Digite os valores.");

//     Console.Write("A = ");
//     a = Convert.ToDouble(Console.ReadLine());
//     Console.Write("B = ");
//     b = Convert.ToDouble(Console.ReadLine());

//     if (b == 0)
//     {
//         Console.WriteLine("\nNão é possível dividir por zero.");
//     }
//     else
//     {
//         resultado = a / b;

//         Console.WriteLine($"{a} dividido por {b} é {resultado}");
//     }

//     Console.WriteLine("\nPressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;
// }

// public static void CalcularRadiciacao()
// {
//     double raiz, radicando, indice;

//     Console.WriteLine("---Radiciação ArB---\n");

//     Console.Write("Digite o Radicando:");
//     radicando = Convert.ToDouble(Console.ReadLine());

//     Console.Write("Digite o Indice:");
//     indice = Convert.ToDouble(Console.ReadLine());

//     raiz = aritmetica.Radiciacao(indice, radicando);

//     Console.WriteLine($"A raiz de {radicando} com o indice de {indice} é {raiz:n2}");

//     Console.WriteLine("\npressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;
// }

// public static void CalcularExpoenciacao()
// {
//     double numero, expoente, potencia;

//     Console.WriteLine("---Exponenciação a^b---\n");

//     Console.Write("Digite o numero");
//     numero = Convert.ToDouble(Console.ReadLine());

//     Console.Write("Digite o expoente:");
//     expoente = Convert.ToDouble(Console.ReadLine());

//     potencia = aritmetica.Exponenciação(numero, expoente);

//     Console.WriteLine($"{numero} junto ao expoente {expoente} é {potencia}");

//     Console.WriteLine("\npressione uma tecla para continuar...");
//     Console.ReadKey();

//     return;

// }
