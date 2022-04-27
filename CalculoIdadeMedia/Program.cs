//Declarações das variáveis

int media = 0;
int idade1 = 0;
int idade2 = 0;
int idade3 = 0; 

//Solicitação dos dados
Console.WriteLine("Esse é um progama que calculará a idade média entre os alunos.\n");
Console.Write("Informe a idade do 1º aluno: ");
idade1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe a idade do 2º aluno: ");
idade2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe a idade do 3º aluno: ");
idade3 = Convert.ToInt32(Console.ReadLine());

//Realização do cálculo 
media = (idade1 + idade2 + idade3) / 3;
Console.WriteLine("\nA idade média dos alunos é " + media + ".\n");
Console.WriteLine("Pressione 'ENTER' para sair do programa.");
Console.ReadKey();