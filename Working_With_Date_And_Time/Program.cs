using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Date_And_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto que exibe data e horas atuais
            DateTime RightNow = DateTime.Now;
            Console.WriteLine("A data e hora atual é: {0}", RightNow);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Criando um objeto que exibe uma determinada data
            DateTime BirthDay = new DateTime(1996, 07, 07);
            Console.WriteLine("Sua data de aniversario é: {0}", BirthDay);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando o ano de uma data
            Console.WriteLine("O seu dia de nascimento é: {0}", BirthDay.Day);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando o mês de uma data
            Console.WriteLine("O seu mes de nascimento é: {0}", BirthDay.Month);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando o ano de uma data
            Console.WriteLine("O seu ano de aniversario é: {0}", BirthDay.Year);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando as horas de um horario
            Console.WriteLine("As horas especificas deste momento é: {0}", RightNow.Hour);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando os minutos de um horario
            Console.WriteLine("Os minutos especificos deste momento é: {0}", RightNow.Minute);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Acessando os segundos de um horario
            Console.WriteLine("Os segundos especificos deste momento é: {0}", RightNow.Second);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            //Formatando data e hora
            DateTime T1 = new DateTime(2020, 12, 24, 12, 25, 00);
            DateTime T2 = new DateTime(2010, 12, 25, 18, 22, 09);
            //Datas formatadas para uma string
            string FmtT1 = T1.ToString("dd/MM/yyyy HH:mm:ss");
            string FmtT2 = T2.ToString("dd/MM/yy HH:mm:ss");
            Console.WriteLine("Date Time 1 formatado: {0}", FmtT1);
            Console.WriteLine("Date Time 2 formatado: {0}", FmtT2);

            Console.WriteLine("_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>_>");

            TimeSpan TSpan = T1 - T2;
            Console.WriteLine("A diferença de dias entre a data 1 e a data 2 em dias = {0} dias", (int)TSpan.TotalDays);

        }
    }
}
