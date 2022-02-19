// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class deregi
{
    static void Main(string[] args)
    {

        byte edad;

        Console.WriteLine("qué edad tienes?");
        edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("No aparentas " + edad + "años");
        Console.WriteLine();
        Console.ReadLine();

    }


}
