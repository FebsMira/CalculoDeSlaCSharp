using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasUteis
{
    public class Program
    {
        static void Main(string[] args)
        {

            HorarioComercial calcularHorarioComercial = new HorarioComercial();

            Console.Write(calcularHorarioComercial.CalculoSla(DateTime.Now, 24));

            string S = "13 DUP 4 POP 5 DUP + DUP + -";

            Solution solution = new Solution();

            Console.Write("\n" + solution.Solucao(S));

            Console.ReadKey();
        }
    }
}
