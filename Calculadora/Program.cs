using EspacioCalculadora;

char decision = 'Y';
Calculadora MiCalcu = new Calculadora();
int opcion;
double numero = 0;
bool posibleInt, posibleChar;
while (decision == 'Y' || decision == 'y')
{
    do
    {
        Console.WriteLine("Ingrese la operacion que desea realizar:");
        Console.WriteLine("\t[1] - Sumar");
        Console.WriteLine("\t[2] - Restar");
        Console.WriteLine("\t[3] - Multiplicar");
        Console.WriteLine("\t[4] - Dividir");
        Console.WriteLine("\t[5] - Limpiar");
        posibleInt = int.TryParse(Console.ReadLine(), out opcion);
    } while (!posibleInt || opcion < 1 || opcion > 5);
    if (opcion != 5)
    {
        do
        {
            Console.WriteLine("Ingrese un numero");
            posibleInt = double.TryParse(Console.ReadLine(), out numero);
        } while (!posibleInt);
    }
    switch (opcion)
    {
        case 1:
            MiCalcu.Sumar(numero);
            break;
        case 2:
            MiCalcu.Restar(numero);
            break;
        case 3:
            MiCalcu.Multiplicar(numero);
            break;
        case 4:
            if (numero == 0) System.Console.WriteLine("No se puede dividir en 0");
            else
            {
                MiCalcu.Dividir(numero);
            }
            break;
        case 5:
            MiCalcu.Limpiar();
            break;
    }
    Console.WriteLine($"El resultado de la la operacion es {MiCalcu.Resultado}");
    do
    {
        Console.WriteLine("Desea seguir operando? [Y]Si / [N]No");
        posibleChar = char.TryParse(Console.ReadLine(), out decision);
    } while (!posibleChar);
}
