using System;
class Program  
{
    static int ageGabriel = 56;
    static int ageIsaias = 56;
    static float heightGabriel = 188f;
    static float heightIsaias = 185f;

    static bool ageIsSame = ageGabriel == ageIsaias;
    static bool heightNotIsSame = heightGabriel != heightIsaias;

    static void Main(string[] args){
        //entendo as saídas do console e utilizando as variáveis
        Console.WriteLine("Olá Gabriel Lisboa, Bem vindo ao C#");  
        Console.WriteLine("Age: " + ageGabriel);
        Console.WriteLine("Height: " + heightGabriel); 
        Console.WriteLine(ageGabriel + 15);
        //----entendendo as estruturas condicionais com C#----------------------
        if(ageGabriel < ageIsaias){
            Console.WriteLine("Isaias é mais velho que o Gabriel.");
        }
        else if (ageGabriel > ageIsaias)
        {
            Console.WriteLine("Gabriel é mais velho que o Isaias.");
        }
        //----Entendendo os operadores lógicos sendo atribuídos aos valores das variáveis------
        Console.WriteLine(ageIsSame);
        Console.WriteLine(heightNotIsSame);
        //---------Utilizando o ReadLine() para inputs no console----------------------------
        Console.WriteLine("Digite dois numeros para fazer todas as operações matemáticas:");
        Console.WriteLine("Número 1: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Número 2: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Adição " + (numberOne + numberTwo));
        Console.WriteLine("Diminuição " + (numberOne - numberTwo));
        Console.WriteLine("Divisão " + (numberOne / numberTwo));
        Console.WriteLine("Multiplicação " + (numberOne * numberTwo));
        Console.WriteLine("Resto " + (numberOne % numberTwo));
        //utilizar o if, else, switch
        Console.WriteLine("Digite sua idade:");
        int insertAge = int.Parse(Console.ReadLine());
        if(insertAge > 13 && insertAge < 18 ){
            Console.WriteLine("Adolescente");
        }
        Console.WriteLine("Digite o dia da semana:");
        int insertNumberDay = int.Parse(Console.ReadLine());
        switch(insertNumberDay) {
            case 1:
            Console.WriteLine("Domingo");
            break;
            case 2: 
            Console.WriteLine("Segunda");
            break;
            case 3: 
            Console.WriteLine("Terça");
            break;
            case 4: 
            Console.WriteLine("Quarta");
            break;
            case 5: 
            Console.WriteLine("Quinta");
            break;
            case 6: 
            Console.WriteLine("Sexta");
            break;
            case 7: 
            Console.WriteLine("Sábado");
            break;
            default:
            Console.WriteLine("Número Inválido!");
            break;
        }
        bool isInvalid = true;
        while(isInvalid) {
            String nome = Console.ReadLine();
            if(nome.Length > 3) {
                isInvalid = false;
                Console.WriteLine(nome);
            } else {
                Console.WriteLine("Insira um nome válido!");
            }
        }

        bool numberInvalid = true;
        while(numberInvalid) {
            int number = int.Parse(Console.ReadLine());
            if(number < 0) {
                numberInvalid = false;
                Console.WriteLine(number);
            } else {
                Console.WriteLine("Insira um número negativo!");
            }
        }
        for (int i = 0; i <= 20; i++){
            if(i % 2 == 0){
                Console.WriteLine(i);
            }
        }
        int input = 0;
        do {
            Console.WriteLine("Insira um número maior que 0: ");
            input = int.Parse(Console.ReadLine());
        }
        while(input < 0);
    }
}
