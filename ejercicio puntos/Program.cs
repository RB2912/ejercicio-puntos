// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

void Adivina()
{
    const int Oportunidades =4;
    int numeroCPU, numeroUsuario;
    byte Intentos, BanderaControl;
    string linea;

    Random rand = new Random();
    //Arreglarlo
    do
    {
        numeroCPU = Convert.ToInt32(rand.Next(1, 21));
        //console.WriteLine(numeroCpu);
        Console.WriteLine(numeroCPU);
    } while (!(((numeroCPU >= 1) & (numeroCPU <= 20))));

    //proceso
    Intentos = 1;
    BanderaControl = 0;
    do
    {
        Console.WriteLine("Hola estoy pensando en un número, cual crees que es ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if((numeroUsuario==numeroCPU))
        {
            Console.WriteLine("Yes! adivinaste!");
            BanderaControl = 1;
        }
        else
        {
            if (numeroUsuario > numeroCPU) 
            {
                Console.WriteLine("me pase");
            }else
            {
                Console.WriteLine("me quede corto");
            }
        }
        Intentos++;

    } while (((Intentos <= Oportunidades) & (BanderaControl == 0)));
}

void buscaMayorYMenor()
{
    int mayor = 0;
    int menor = 100;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero);
        if (numero < menor)
        {
            menor = numero;
        }
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número menor es: " + menor);
}


void arreglos()
{
    int[] notas = new int[5];
    Random rnd = new Random();
    Console.WriteLine("Cargando información");
    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }
    Console.WriteLine("Desplegando Información:");
    int mayor = 0;
    int suma = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
        suma += notas[i];
        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }
    }
    double promedio = (double)suma / notas.Length;
    Console.WriteLine("Nota Mayor=" + mayor);
    Console.WriteLine("Promedio=" + promedio);
}

void nombres()
{
    string[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Hugo";
    nombre[7] = "Mateo";
    nombre[8] = "Lucas";
    nombre[9] = "Daniel";
    nombre[10]="Lucia";

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + ": " + nombre[i]);
    }
}
void rifa()
{
    string[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Hugo";
    nombre[7] = "Mateo";
    nombre[8] = "Lucas";
    nombre[9] = "Daniel";
    nombre[10] = "Lucia";

    Random rand = new Random();
    List<int> numerosSeleccionados = new List<int>();
    string ganador1 = "";
    string ganador2 = "";

    Console.WriteLine("Comenzando la rifa...");

    while (numerosSeleccionados.Count < 2)
    {
        int numero = rand.Next(0, nombre.Length);
        if (!numerosSeleccionados.Contains(numero))
        {
            numerosSeleccionados.Add(numero);
            if (ganador1 == "")
            {
                ganador1 = nombre[numero];
            }
            else
            {
                ganador2 = nombre[numero];
            }
        }
    }

    Console.WriteLine($"Ganador 1: {ganador1}");
    Console.WriteLine($"Ganador 2: {ganador2}");
    Console.WriteLine("Rifa finalizada.");
}





rifa();

//nombres();


//arreglos();

//buscaMayorYMenor();

//Adivina();

