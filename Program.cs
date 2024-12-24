using NetProjects.Models;

string apresentacao = "Olá, seja bem-vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

// Usando $ para executar as variáveis
Console.WriteLine($"{apresentacao}\nQuantos doces? {quantidade} - OK!, O valor do doce é R${preco}\nQual a sua altura? {altura}mts\nTestando = {condicao}");

// Executando uma variável de cada vez
Console.WriteLine(apresentacao);
Console.WriteLine("Executando variável Quantidade = " + quantidade);
Console.WriteLine("Executando variável Altura = " + altura.ToString("0.00mts"));
Console.WriteLine("Executando variável Preço = R$" + preco);
Console.WriteLine("Executando variável Condição = " + condicao);








/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Ygor";
pessoa1.Idade = 31;
pessoa1.Apresentar(); */