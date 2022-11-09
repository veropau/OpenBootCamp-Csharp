
// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Ejercicios sesión 4");
Console.WriteLine("\n Ejercicio 1 - While => Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.\n");

Console.Write(" Que tabla desea consultar: ");
var numero = Convert.ToInt32(Console.ReadLine());

int x = 1;

Console.WriteLine();
while (x <= 10)
{
    var result = numero * x;
    Console.WriteLine($" {numero} x {x} = {result}");
    x++;
}

Console.WriteLine("\n Ejercicio 2 - Do while => Escribe un programa que realice estos pasos: \n Reciba al menos un número por consola - Determine si el número es positivo o negativo \n Presente un contador para cada tipo (positivo y negativo).\n");
// Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
Console.Write(" Digite el número a evaluar: ");
var number = Convert.ToInt32(Console.ReadLine());
bool firstTime = true;

do
{
    if (number > 0)
    {
        if (firstTime) Console.WriteLine("\n El número es positivo\n");
        firstTime = false;
        Console.WriteLine(" " + number);
        number--;
    }
    else if (number < 0)
    {
        if (firstTime) Console.WriteLine("\n El número es negativo\n");
        firstTime = false;
        Console.WriteLine(" " + number);
        number++;
    }
    else if (number == 0)
    {
        Console.WriteLine(" El número digitado es 0");
    }

} while (number != 0);

Console.WriteLine("\n Ejercicio 3 - For => Escribe un programa que realice estos pasos: \n Reciba 3 datos: ancho - alto - relleno o no. \n Dibuje en consola con un mismo caracter, por ejemplo *, " +
    "un rectángulo de las dimensiones introducidas \n y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.");
Console.WriteLine(" En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.\n");
//Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

//Console.WriteLine("");
DrowYSquare(2, 2, 3, true);
//Console.WriteLine("");
DrowYSquare(3, 3, 2);
//Console.WriteLine("");
DrowYSquare(4, 3, 1, true);
//Console.WriteLine("");
DrowYSquare(4, 4, 3);

void DrowYSquare(int width, int heigth, int amount , bool filled = false) {
    Console.WriteLine($"\n {amount} Cuadrados: {width} x {heigth}\n");
    while (amount > 0) { 
        DrowSquare(width, heigth, filled);
        amount--;
    }
}

void DrowSquare(int width, int heigth, bool filled = false) {
    var initialHeigth = heigth;
    var initialWidth = width-1;
    if (filled) {
        Console.WriteLine("");
        while (heigth > 0)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write($"*");
            }
            Console.WriteLine();
            heigth -= 1;
        }        
    } else
    {
        Console.WriteLine("");
        while (heigth > 0)
        {
            for (int i = 0; i < width; i++)
            {
                if (heigth == 1 || heigth == initialHeigth)
                {
                    Console.Write($"*");
                }
                else
                {
                    if (i == 0 || i == initialWidth )
                    {
                        Console.Write($"*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            heigth -= 1;
        }
    }
}
