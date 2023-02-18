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
        if (imc < 16)
        {
            Console.WriteLine("Seu IMC indica Magreza Grau III!");
        }
        if (imc > 16 && imc < 16.99f)
        {
            Console.WriteLine("Seu IMC indica Magreza Grau II!");
        }
        if (imc > 17f && imc < 18.49f)
        {
            Console.WriteLine("Seu IMC indica Magreza Grau I!");
        }
        if (imc > 18.5f && imc < 24.99f)
        {
            Console.WriteLine("Seu IMC indica peso Normal(Eutrofia)!");
        }
        if (imc > 25f && imc < 29.99f)
        {
            Console.WriteLine("Seu IMC indica Sobrepeso!");
            Console.WriteLine("Risco a saúde: Aumentado");
        }
        if (imc > 30f && imc < 34.99f)
        {
            Console.WriteLine("Seu IMC indica Obesidade Grau I!");
            Console.WriteLine("Risco a saúde: Moderado");
        }
        if (imc > 35f && imc < 40f)
        {
            Console.WriteLine("Seu IMC indica Obesidade Grau II!");
            Console.WriteLine("Risco a saúde: Grave");
        }
        if (imc > 40f)
        {
            Console.WriteLine("Seu IMC indica Obesidade Grau III!");
            Console.WriteLine("Risco a saúde: Muito Grave");
        }
        Console.WriteLine("Classificações do IMC segundo a OMS(Ordem Mundial da Saude)");
    }
}