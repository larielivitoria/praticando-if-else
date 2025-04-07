
Console.WriteLine("Informe a nota final do aluno:");

double notaFinal = double.Parse(Console.ReadLine());

if (notaFinal >= 9)
{
    Console.WriteLine("você tirou A");
}if (notaFinal >= 7 && notaFinal < 9)
{
    Console.WriteLine("Você tirou B");
}
if (notaFinal >= 5 && notaFinal < 7)
{
    Console.WriteLine("Você tirou C");
}
if (notaFinal < 5)
{
    Console.WriteLine("Você tirou D");
}