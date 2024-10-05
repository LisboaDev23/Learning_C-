public class Pessoa {
    private String name;
    private int age;
    private String profissao;
    private double salario;

    public Pessoa (String name, int age){
        this.name = name;
        this.age = age;
        this.profissao = "Undefined";
        this.salario = 0;
    }

    public Pessoa (String name, int age, String profissao){
        this.name = name;
        this.age = age;
        this.profissao = profissao;
        this.salario = 0;
    }
    public Pessoa (String name, int age, String profissao, double salario){
        this.name = name;
        this.age = age;
        this.profissao = profissao;
        if(salario < 0) {
            Console.WriteLine("Não é possível instânciar uma pessoa com o salário negativo!");
        } else {
            this.salario = salario;
        }
    }
    public String Name {
        get {return name;}
        set{name = value;}
    }
    public int Age {
        get{return age;}
        set{
            if(value > 0) age = value;
        }
    }
    public String Profissao {
        get {return profissao;}
        set {profissao = value;}
    }
    public double Salario {
        get{return salario;}
        set{
            if(value > 0) salario = value;
        }
    }

    public void ReceberSalario () {
        Console.WriteLine(Salario);
    }

    public void ExibirDados (){
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Profissao);
    }
    public virtual void Falar (){
        Console.WriteLine("Olá, eu sou o " + Name);
    }
}