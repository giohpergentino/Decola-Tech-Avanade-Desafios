using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decola_Tech_Avanade.Models
{
    public class Pessoa
    {
    private string nome;
    private int idade;
    
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
    }
}