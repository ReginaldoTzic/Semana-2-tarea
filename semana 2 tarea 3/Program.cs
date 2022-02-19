// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite dos numeros largos\n");
Int64 X, Y, suma,resta,multiplicacion;

X = Convert.ToInt64(Console.ReadLine());

Y = Convert.ToInt64(Console.ReadLine());

multiplicacion = Convert.ToInt64(X) * Convert.ToInt64(Y);

suma = Convert.ToInt64(X) + Convert.ToInt64(Y);

resta = Convert.ToInt64(X) - Convert.ToInt64(Y);

Console.WriteLine("El resultado de la suma es:" + suma);
Console.WriteLine("El resultado de la resta es:" + resta);
Console.WriteLine("El resultado de la multiplicacion es:" + multiplicacion);

Console.ReadLine();
