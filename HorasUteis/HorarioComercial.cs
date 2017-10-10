using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HorasUteis
{
    public class HorarioComercial
    {

        public DateTime CalculoSla(DateTime inicio, int horasSla)
        {

            double entrada = 9;
            double saida = 18;

            double horasNoPrimeiroDia = saida - inicio.Hour;

            double horasRestantes = horasSla - horasNoPrimeiroDia;

            int adicionarDias = (int) (horasRestantes / entrada);
            double adicionarHoras = horasRestantes % entrada;

            DateTime dataFinal = inicio.Date.AddDays(adicionarDias + 1).AddHours(adicionarHoras + entrada);

            TimeSpan diferenca = dataFinal - inicio;

            var days = diferenca.Days;

            //verificar se os dias são menores que 0
            if (days < 0)
            {
                throw new ArgumentException($"dias da semana não pode ser negativos {days}");
            }
            //verificar se os dias são = 0
            if (days == 0) return inicio;

            //verificar se é sabado
            if (inicio.DayOfWeek == DayOfWeek.Saturday)
            {
                inicio = inicio.AddDays(2);
                days -= 1;
            }

            //verificar se é domingo
            else if (inicio.DayOfWeek == DayOfWeek.Sunday)
            {
                inicio = inicio.AddDays(1);
                days -= 1;
            }

            //verificar se os dias /5 (dias uteis) * dias da semana(7)
            inicio = inicio.AddDays(days / 5 * 7);
            int extraDays = days % 5;

            if ((int)inicio.DayOfWeek + extraDays > 5)
            {
                extraDays += 2;
            }
            return inicio.AddDays(extraDays).AddHours(diferenca.Hours);
        }
    }
}