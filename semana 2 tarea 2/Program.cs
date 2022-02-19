// See https://aka.ms/new-console-template for more information
byte numero1, numero2;
ushort mult;
Console.WriteLine("Ingresar un numero");

numero1 = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Ingresar otro numero");

numero2 = Convert.ToByte(Console.ReadLine());

mult = (ushort)(numero1 * numero2);

Console.WriteLine("El producto es: " + mult);

Console.WriteLine();