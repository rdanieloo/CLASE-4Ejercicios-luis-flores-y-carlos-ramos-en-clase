

using System;

//Enunciado 1

//1



int contador = 0;
int numero = 0;

Console.WriteLine("A continuacion te mostrare los primeros 5 números pares:");

while (contador < 5)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
        contador++;
    }
    numero++;
}

Console.ReadLine();

//2




{
    int n = 10;
    int suma = (n * (n + 1)) / 2;

    Console.WriteLine("La suma de los primeros 10 números naturales es: " + suma);

}

Console.ReadLine();


//Enunciado 2

//1



{
    int suma = 0;

    Console.WriteLine("Ingrese números enteros positivos. Ingrese un número negativo para terminar.");

    int num;
    while ((num = Convert.ToInt32(Console.ReadLine())) >= 0)
    {
        suma += num;
    }

    Console.WriteLine("La suma de los números ingresados es: " + suma);
}


Console.ReadLine();


//2


int numeroa = 1;

while (true)
{
    if (numeroa % 7 == 0 && numeroa % 11 == 0)
    {
        Console.WriteLine("El primer número entero positivo divisible entre 7 y 11 es: " + numero);
        break;
    }
    numeroa++;
}


Console.ReadLine();


//Enunciado 3


//1



{
    string contraseñaCorrecta = "jutiapa";

    while (true)
    {
        Console.Write("Ingrese la contraseña: ");
        string contraseñaIngresada = Console.ReadLine();

        if (contraseñaIngresada == contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña correcta.\nBienvenido :) ");
            break;
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.\nPuedes intentarlo de nuevo de nuevo, por favor :)");
        }
    }
}


Console.ReadLine();




//2


{
    Random rnd = new Random();
    int numeroAleatorio = rnd.Next(1, 101);

    Console.WriteLine("Adivina el número secreto entre 1 y 100");

    while (true)
    {
        Console.Write("Ingresa tu suposición: ");
        int suposicion = Convert.ToInt32(Console.ReadLine());

        if (suposicion == numeroAleatorio)
        {
            Console.WriteLine("¡Felicidades! ¡Has adivinado el número aleatorio!");
            break;
        }
        else if (suposicion < numeroAleatorio)
        {
            Console.WriteLine("El número aleatorio es mayor. ¡Intenta de nuevo!");
        }
        else
        {
            Console.WriteLine("El número aleatorio es menor. ¡Intenta de nuevo!");
        }
    }
}
Console.ReadLine();



//Para todos:

//1



static void Main(string[] args)
{
    bool todasAsignaturasAprobadas = true;
    double promedioGeneral = 80;
    bool noSancionadoPorComportamiento = true;

    if (todasAsignaturasAprobadas && promedioGeneral >= 70 && noSancionadoPorComportamiento)
    {
        Console.WriteLine("Felicidades!\nEl estudiante puede graduarse :)");
    }
    else
    {
        Console.WriteLine("El estudiante no cumple con los requisitos para graduarse.");
    }
}


//2





{
    string tipoLibro = "ficcion";
    bool disponible = true;
    bool MiembroPremium = false;
    int librosPrestados = 2;
    int edadUsuario = 14;

    if ((tipoLibro == "ficcion" && disponible) ||
        (tipoLibro == "no_ficcion" && edadUsuario > 18) ||
        (tipoLibro == "referencia" && MiembroPremium && librosPrestados < 3))
    {
        Console.WriteLine("El libro puede ser prestado al usuario.");
    }
    else
    {
        Console.WriteLine("El libro no puede ser prestado al usuario.");
    }
}













