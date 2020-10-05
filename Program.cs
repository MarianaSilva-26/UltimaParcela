using System; 
 

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal financiamento; 
            decimal parcelas; 
            DateTime UltimaParcela;
            decimal resultadoFinal; 

            DateTime dataAtual = DateTime.Now; 
            UltimaParcela = dataAtual.AddMonths(8);

            Console.Write("valor total do financiamento..:");
            financiamento = decimal.Parse(Console.ReadLine());

            Console.Write("quantidade de parcelas mensais (sem juros) ..:");
            parcelas = decimal.Parse(Console.ReadLine()); 
            Console.Write("\n"); 

            resultadoFinal = financiamento / parcelas; 
            
            Console.WriteLine($"Sua ultima parcela será em : {UltimaParcela}, no valor de r${resultadoFinal}");
        }
    }
}
