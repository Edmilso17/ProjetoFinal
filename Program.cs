string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 6 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[r] Radiciação");
Console.WriteLine("[?] Exponenciação");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("\nSelecione a operação desejada: ");
Console.ResetColor();

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        CalcularSoma();
        break;
    case "-":
        CalcularSubtracao();
        break;
    case "*":
        CalcularMultiplicacao();
        break;
    case "/":
        CalcularDivisao();
        break;
    case "r":
        CalcularRadiciacao();
        break;
    case "?":
        CalcularExponenciacao(); 
        break;       
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nObrigado por utilizar nosso programa.");
Console.ResetColor();





void CalcularSoma()
{
    double a, b, resultado;

    Console.WriteLine("--- Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"{a} somado com {b} é {resultado}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ResetColor();
    Console.ReadKey();

    return;
}

void CalcularSubtracao()
{
    double a, b, resultado;

    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} subtraindo {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularMultiplicacao()
{
    double a, b, resultado;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularDivisao()
{
    double a, b, resultado;

    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("\nNão é possível dividir por zero.");
    }
    else
    {
        resultado = a / b;

        Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularRadiciacao()
{
    double raiz, radicando, indice;

    Console.WriteLine("---Radiciação ArB---\n");

    Console.Write("Digite o Radicando:");
    radicando = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o Indice:");
    indice = Convert.ToDouble(Console.ReadLine());

    raiz = Aritimetica.Radiciação(indice, radicando);

    Console.WriteLine($"A raiz de {radicando} com o indice de {indice} é {raiz:n2}");

    Console.WriteLine("\npressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularExponenciacao()
{
    double numero, expoente, potencia;

    Console.WriteLine("---Exponenciação a^b---\n");

    Console.Write("Digite o numero");
    numero = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o expoente:");
    expoente = Convert.ToDouble(Console.ReadLine());

    potencia = Aritimetica.Exponenciação(numero, expoente);

    Console.WriteLine($"{numero} junto ao expoente {expoente} é {potencia}");

    Console.WriteLine("\npressione uma tecla para continuar...");
    Console.ReadKey();

    return;

}
 Console.ForegroundColor = ConsoleColor.DarkGreen;
 Console.WriteLine("GitHub: Edmilson17");
 Console.ResetColor();
