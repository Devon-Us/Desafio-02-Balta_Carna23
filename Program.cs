internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Olá, vamos calcular seu Indice de Massa Corporal(IMC):");
        Console.WriteLine("Para começar, digite o seu peso: ");
        var peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Agora digite sua altura: ");
        var altura = float.Parse(Console.ReadLine());
        var imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc}");
        if (imc < 18.5f)
        {
            Console.WriteLine("Seu IMC indica baixo peso!");
        }
        if (imc > 18.5f && imc < 24.99f)
        {
            Console.WriteLine("Seu IMC indica peso normal!");
        }
        if (imc > 25f && imc < 29.99f)
        {
            Console.WriteLine("Seu IMC indica sobre peso!");
        }
        if (imc > 30f)
        {
            Console.WriteLine("Seu IMC indica obesidade!");
        }
    }
}