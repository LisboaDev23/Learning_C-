public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Dividir(number1, number2));
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DIVISÃO POR 0 INVÁLIDA!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("FORMATO INVÁLIDO! VERIFIQUE SE O NÚMERO DIGITADO É UM INTEIRO!");
        }
        finally
        {
            Console.WriteLine("Fluxo encerrado!");
        }
    }

    public static int Dividir(int number1, int number2)
    {
        return number1 / number2;
    }
}