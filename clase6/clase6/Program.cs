int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int contador = 0;
int numero;
do
{
    Console.WriteLine("Intenta adivinar el numero (1 al 20)");
    numero = int.Parse(Console.ReadLine());

    if (numero < numeroSecreto)
    {
        Console.WriteLine("Te quedaste corto. Proba con un numero más grande");
    }

    else if (numero > numeroSecreto)
    {
        Console.WriteLine("Te pasaste. Proba con un numero más chico");
    }

    contador++;
}
while (numeroSecreto != numero);

Console.WriteLine($"Felicidades has adviniado el numero es {numeroSecreto}. Tan solo te tomo {contador} intento(s)");
