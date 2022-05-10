// solicitar un numero al cliente y si el numero es 1000 imprimir ganaste un premio

Console.WriteLine("Ingrese su numero por favor");
int numero = int.Parse(Console.ReadLine());

if (numero == 1000)
    Console.WriteLine("ganaste un premio");
else if (numero != 1000)
    Console.WriteLine("suerte para la proxima");
