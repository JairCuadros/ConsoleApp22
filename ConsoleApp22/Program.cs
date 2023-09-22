Console.Write("Por favor ingrese el número límite: ");

int númerolimite = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("******************************");
Console.WriteLine("******************************");
Console.WriteLine("Escoja una opción:");
Console.WriteLine("1) Números pares");
Console.WriteLine("2) Números impares");
Console.WriteLine("3) Factorial");
Console.Write("---> ");
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        for (int i = 1; i <= númerolimite; i++){
            if (i % 2 == 0){
                Console.Write(i + ",");
            }
        }
        break;
    case 2:
        for (int i = 1; i <= númerolimite; i++){
            if (i % 2 != 0){
                Console.Write(i + ",");
            }
        }
        break;
    case 3:
        long resultado = 1;
        for (int i = 1; i <= númerolimite; i++){
            resultado *= i;
        }
        Console.Write("El factorial es " + resultado);
        break;
}