Console.WriteLine("Informe seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu idade:");
int idade = Convert.ToInt16(Console.ReadLine());

var respostas = new string [4];

Console.WriteLine("Seu cartão de vacina está em dia?");
respostas[0] = Console.ReadLine();
for(int i = 1; i <= 3;i++)
{
    if(respostas[0].ToUpper() != "SIM" && respostas[0].ToUpper() != "NAO")
    {
        Console.WriteLine("Seu cartão de vacina está em dia?");
        respostas[0] = Console.ReadLine();
    }
    if (i == 3 && respostas[0].ToUpper() != "SIM" && respostas[0].ToUpper() != "NAO")
    {
        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
        Environment.Exit(0);
    }
}

Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)");
respostas[1] = Console.ReadLine();
for(int i = 1; i <= 3;i++)
{
    if(respostas[1].ToUpper() != "SIM" && respostas[1].ToUpper() != "NAO")
    {
        Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)");
        respostas[1] = Console.ReadLine();
    }
    if (i == 3 && respostas[1].ToUpper() != "SIM" && respostas[1].ToUpper() != "NAO")
    {
        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
        Environment.Exit(0);
    }
}

Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias?");
respostas[2] = Console.ReadLine();
for(int i = 1; i <= 3;i++)
{
    if(respostas[2].ToUpper() != "SIM" && respostas[2].ToUpper() != "NAO")
    {
        Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias?");
        respostas[2] = Console.ReadLine();
    }
    if (i == 3 && respostas[2].ToUpper() != "SIM" && respostas[2].ToUpper() != "NAO")
    {
        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
        Environment.Exit(0);
    }
}

Console.WriteLine("Está retornando de viagem realizada no exterior?");
respostas[3] = Console.ReadLine();
for(int i = 1; i <= 3;i++)
{
    if(respostas[3].ToUpper() != "SIM" && respostas[3].ToUpper() != "NAO")
    {
        Console.WriteLine("Está retornando de viagem realizada no exterior?");
        respostas[3] = Console.ReadLine();
    }
    if (i == 3 && respostas[3].ToUpper() != "SIM" && respostas[3].ToUpper() != "NAO")
    {
        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
        Environment.Exit(0);
    }
}

double risco = 0;
string orientaçao = "";

if(respostas[0].ToUpper() == "SIM")
    risco += 10;
if(respostas[1].ToUpper() == "SIM")
    risco += 30;
if(respostas[2].ToUpper() == "SIM")
    risco += 30;
if(respostas[3].ToUpper() == "SIM")
    risco += 30;

if(risco <= 30)
    orientaçao = "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
else if(risco <= 60)
    orientaçao = "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
else if(risco >= 90)
    orientaçao = "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado";
else if(respostas[3].ToUpper() == "SIM")
    orientaçao = "Você ficará sob observação por 05 dias.";

Console.WriteLine("Nome: {0} \nIdade: {1} \nSe o cartão de vacina está em dia: {2} \nSe teve sintomas recentemente: {3} \nSe teve contato com pessoas infectadas: {4} \nSe a pessoa está retornando de viagem: {5} \nA probabilidade dessa pessoa estar infectada: {6}% \nA orientação final do atendimento: {7}",nome.ToUpper(),idade,respostas[0].ToUpper(),respostas[1].ToUpper(),respostas[2].ToUpper(),respostas[3].ToUpper(),risco,orientaçao);
Console.ReadLine();
