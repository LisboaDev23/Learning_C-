class Program {
    public static void Main (string[] args){
        //Multiply();
        //CustomSaudation("Gabriel");

        Pessoa pessoa = new Pessoa("Gabriel", 21, "Desenvolvedor FullStack");
        pessoa.Falar();
        pessoa.ExibirDados();
        pessoa.Salario = 2500.90;
        pessoa.ReceberSalario();

        Pessoa gerente = new Gerente("Lisboa", 21, "Software Engineer", 4500.50, 1000.05);
        gerente.Falar();
    }

    static int Multiply (){
        Console.WriteLine("Digite dois números para obter seu produto: ");
        Console.WriteLine("1° número: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2° número: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("O produto dos dois números: " + number1*number2);
        return number1 * number2;
    }

    static void CustomSaudation (String name){
        Console.WriteLine("Olá " + name);
    }
}
