// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicios sesión 1");
Console.WriteLine();
// Ejercicio 1
// Escribe un programa que reciba tu nombre y lo escriba por consola.
Console.WriteLine("Ejercicio 1 => Escribe un programa que reciba tu nombre y lo escriba por consola.");
Console.WriteLine();
Console.Write("Digite su nombre: ");
var nameUser = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Su nombre es: " + nameUser);
Console.WriteLine();
// Ejercicio 2
// Escribe un programa que tome la hora y la escriba por pantalla.
Console.WriteLine("Ejercicio 2 => Escribe un programa que tome la hora y la escriba por pantalla.");
var hora = (DateTime.Now).ToString("hh:mm:ss");
Console.WriteLine(hora);
