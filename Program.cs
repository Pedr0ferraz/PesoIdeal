Console.Clear();
 
double altura, PesoIdeal;
string Sexo;
 
Console.WriteLine("--- Peso Ideal ---");
 
Console.WriteLine();
 
Console.Write("Digite sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine();
 
Console.Write("Digite seu sexo: ");
Sexo = Console.ReadLine()!.ToUpper();
 
if(Sexo == "M")
{
PesoIdeal = altura * 72.7-58.0;
 
}
else
{
    PesoIdeal = altura * 62.1-44.7;
}
Console.WriteLine($"Seu peso ideal é {PesoIdeal:N1}Kg.");
 
 
 