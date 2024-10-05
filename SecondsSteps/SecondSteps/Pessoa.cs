public class Pessoa {
    private String name;
    private int age;
    private String profissao;

    public Pessoa (String name, int age, String profissao){
        this.name = name;
        this.age = age;
        this.profissao = profissao;
    }

    public void ExibirDados (){
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(profissao);
    }
    public void Falar (){
        Console.WriteLine("Olá, eu sou o " + name);
    }
}