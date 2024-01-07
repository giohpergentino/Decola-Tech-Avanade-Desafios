using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Criando um jogador de futebol
namespace Decola_Tech_Avanade.Models
{
    public class Jogador
    {
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
    
    public static Jogador Novo(string nome, string nacionalidade, int idade, string posicao)
    {
      return new Jogador
      {
        Nome = nome,
        Nacionalidade = nacionalidade,
        Idade = idade,
        Posicao = posicao
      };
    }
    }
}