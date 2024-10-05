public class Gerente : Pessoa
{
    private double bonus;

    public double Bonus {
        get {return bonus;}
        set {
            if(value >= 0) bonus = value;
            else Console.WriteLine("Bonus não pode ser negativo!");
        }
    }
    public Gerente(string name, int age, string profissao) : base(name, age, profissao)
    {
        this.Bonus = 0;
    }
    public Gerente(string name, int age, double bonus) : base(name, age)
    {
        if (bonus < 0) {
            Console.WriteLine("Não se pode instânciar um gerente com bonus negativo!");
        } else {
            this.Bonus = bonus;
        }
    }

    public Gerente(string name, int age, string profissao, double salario, double bonus) : base(name, age, profissao, salario)
    {
        if (bonus < 0) {
            Console.WriteLine("Não se pode instânciar um gerente com bonus negativo!");
        } else {
            this.Bonus = bonus; 
        }
    }

    public override void Falar ()
    {
        Console.WriteLine("Gerente Falando!");
    }
}