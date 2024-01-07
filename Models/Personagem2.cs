using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//A batalha dos RPGistas: herança e subclasse!
namespace Decola_Tech_Avanade.Models
{
    public class Personagem2
    {
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem2(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
    }
}