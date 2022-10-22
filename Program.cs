// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Ejercicios sesión 1");
//Console.WriteLine();
//// Ejercicio 1
//// Escribe un programa que reciba tu nombre y lo escriba por consola.
//Console.WriteLine("Ejercicio 1 => Escribe un programa que reciba tu nombre y lo escriba por consola.");
//Console.WriteLine();
//Console.Write("Digite su nombre: ");
//var nameUser = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine("Su nombre es: " + nameUser);
//Console.WriteLine();
//// Ejercicio 2
//// Escribe un programa que tome la hora y la escriba por pantalla.
//Console.WriteLine("Ejercicio 2 => Escribe un programa que tome la hora y la escriba por pantalla.");
//var hora = (DateTime.Now).ToString("hh:mm:ss");
//Console.WriteLine(hora);



Console.WriteLine(" Ejercicios sesión 2");
Console.WriteLine();

Console.WriteLine(" Ejercicio 1 => Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.");
Console.WriteLine("");
Console.WriteLine(" Datos Persona");
Console.WriteLine("");
Console.Write(" Digite su nombre: ");
string nombre = Console.ReadLine();
Console.Write(" Digite su apellido: ");
string apellido = Console.ReadLine();
Console.Write(" Digite su edad: ");
string edad = Console.ReadLine();
Console.Write(" Sabe programar?: ");
string sabeProgramar = Console.ReadLine();
Console.WriteLine("");

string mensaje = $" Su nombre completo es {nombre} {apellido}, tiene {edad} años y {sabeProgramar} sabe programar";
Console.WriteLine(mensaje);


Console.WriteLine("Ejercicio 2");
Console.WriteLine("Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:");
Console.WriteLine();
// Coche: puertas, ruedas, marca, ITV vigente
// Mesa: peso, largo, material, color
// Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

Console.WriteLine("Coche"); 
Console.WriteLine(" int puertas;");
Console.WriteLine(" int ruedas;");
Console.WriteLine(" string marca;");
Console.WriteLine(" bool ITVvigente;");

Console.WriteLine();
Console.WriteLine("Mesa");
Console.WriteLine(" double peso;");
Console.WriteLine(" double largo;");
Console.WriteLine(" string material;");
Console.WriteLine(" string color;");
Console.WriteLine();

Console.WriteLine(" Ejercicio 3");
Console.WriteLine(" Operadores Determina los operadores para verificar las siguientes condiciones:");
Console.WriteLine();
Console.WriteLine(" Un número es mayor o igual a 18");
Console.WriteLine(" x >= 18");
Console.WriteLine();
Console.WriteLine(" Un char es ‘a’");
Console.WriteLine(" char == 'a'");
Console.WriteLine();
Console.WriteLine(" Se cumplen dos condiciones a la vez (ambas verdaderas)");
Console.WriteLine(" (5>4) && (4<5)");
Console.WriteLine();
Console.WriteLine(" Se cumple una de dos condiciones a la vez (una true y otra false)");
Console.WriteLine(" (5<4) || (4<5)");
// Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.