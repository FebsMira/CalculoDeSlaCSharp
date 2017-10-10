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

            Console.Write(calcularHorarioComercial.CalculoSla(DateTime.Now, 15));

            Console.ReadKey();
        }
    }
}
