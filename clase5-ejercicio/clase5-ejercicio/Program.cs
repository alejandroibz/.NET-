Console.Clear();
string rta = "S";
while (rta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("Ingrese su nombre por favor. :)");
    var nombre = Console.ReadLine();

    Console.WriteLine("Hola " + nombre + ", mucho gusto! Un placer conocerte");
    Console.WriteLine("Desea usted " + nombre + " continuar? Si la respuesta es SI por favor ingrese 'S'. Si la respuesta es NO por favor ingrese 'N' ");
    rta = Console.ReadLine();
}
if (rta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
    Console.WriteLine("Presione una tecla para finalizar la ejecucion");
    Console.ReadKey();
    Console.Clear();
}
    
else
{
    Console.WriteLine("Opcion no valida");
}   

