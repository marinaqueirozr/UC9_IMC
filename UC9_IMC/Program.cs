// VARIAVEIS

double peso, altura, imc;
string nome;

peso = 0;
altura = 0;
imc = 0;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();

Console.WriteLine(nome + ", qual sua altura (em Metros, Centímetros...)");
altura = double.Parse(Console.ReadLine());

Console.WriteLine(nome + ", qual seu peso (em Kg...)");
peso = double.Parse(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine(nome + ", seu imc é: " + imc);

if (imc < 18.5)
{
    Console.WriteLine(nome + ", você está abaixo do peso");
}
else
{
    if(imc < 25)
    {
        Console.WriteLine(nome + ", você está no peso Normal");
    }
    else
    {
        if (imc < 30)
        {
            Console.WriteLine(nome + ", você está no Excesso de peso");
        }
        else
        {
            if (imc < 35)
            {
                Console.WriteLine(nome + ", você está com Obesidade classe 1");
            }
            else
            {

            }
        }       
    }


}
