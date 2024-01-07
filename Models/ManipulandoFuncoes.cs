using System;

//Cálculo de Pegada de Carbono
class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de cálculo
        double fatorTransporte = 0.2;
        double fatorEletronicos = 0.1;
        double fatorRefeicoesComCarne = 0.5;

        // Lógica para calcular a pegada de carbono
        double pegadaQuilometros = quilometrosPorDia * 365 * fatorTransporte;
        double pegadaEletronicos = horasDeEletronicos * fatorEletronicos;
        double pegadaRefeicoes = refeicoesComCarne * fatorRefeicoesComCarne;

        // Soma total da pegada de carbono (convertido para toneladas)
        double pegadaTotal = (pegadaQuilometros + pegadaEletronicos + pegadaRefeicoes) / 1;

        return pegadaTotal;
    }
}