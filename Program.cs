//Programa que lea un número entero por teclado y que calcule su factorial.

internal class Program
{
    private static void Main(string[] args)
    {
        int num; int factorial = 1; int i = 1;

        Console.WriteLine("Digite un número");
        num = int.Parse(Console.ReadLine());
        while(i <= num)
        {
            factorial = factorial * i;
             i++;

        }
        Console.WriteLine("El factorial de "+num+" es: "+factorial);
        
    }
}