using Decola_Tech_Avanade.Models;

//Classe Pessoa
Console.WriteLine("Digite o nome da pessoa: ");
string nomeInserido = Console.ReadLine();
       
Console.WriteLine("Digite a idade da pessoa: ")
int idadeInserida = int.Parse(Console.ReadLine());
       
Pessoa pessoa = new Pessoa(nomeInserido, idadeInserida);
       
string nome = pessoa.GetNome();
int idade = pessoa.GetIdade();
       
Console.WriteLine($"Nome: {nome}, Idade: {idade}");

//Classe Robo
string[] velocidades = Console.ReadLine().Split();
int vmin = int.Parse(velocidades[0]);
int vmax = int.Parse(velocidades[1]);
        
Robo robo = new Robo(vmin, vmax);
        
string comandos = Console.ReadLine();
        
foreach(char comando in comandos)
{
    if(comando == 'A')
    {
    robo.Acelerar();
    }
    else if(comando == 'D')
    {
        robo.Desacelerar();
    }
}
    Console.WriteLine(robo.VelocidadeAtual);

//Classe Jogador
string nome = Console.ReadLine();
string nacionalidade = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());
string posicao = Console.ReadLine();
        
Jogador jogador = Jogador.Novo(nome, nacionalidade, idade, posicao);
        
Console.WriteLine("Jogador criado!");
Console.WriteLine(jogador.Nome);
Console.WriteLine(jogador.Nacionalidade);
Console.WriteLine(jogador.Idade);
Console.WriteLine($"Posição: {jogador.Posicao}");

//Classe Personagem

string nome = Console.ReadLine();
string raca = Console.ReadLine();
string classe = Console.ReadLine();
        
Personagem personagem = new Personagem(nome, raca, classe);
        
personagem.ExibirStatus();

//Classe Personagem 2 e Subclasse

string EntradaNome = Console.ReadLine();
int EntradaMana = int.Parse(Console.ReadLine());
int EntradaDanoBase = int.Parse(Console.ReadLine());
       
Subclasse sub = new Subclasse(EntradaNome, EntradaMana, EntradaDanoBase);
       
sub.CalcularDano();