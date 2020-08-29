using FibonacciClock.Model;
using System;

namespace FibonacciClock
{
    public class Relogio
    {
        public Ponteiro PonteiroUm1 { get; }
        public Ponteiro PonteiroUm2 { get; }
        public Ponteiro PonteiroDois { get; }
        public Ponteiro PonteiroTres { get; }
        public Ponteiro PonteiroCinco { get; }

        public Relogio()
        {
            PonteiroUm1 = new Ponteiro(1);
            PonteiroUm2 = new Ponteiro(1);
            PonteiroDois = new Ponteiro(2);
            PonteiroTres = new Ponteiro(3);
            PonteiroCinco = new Ponteiro(5);
        }

        public override string ToString() => $"{PonteiroUm1}\n{PonteiroUm2}\n{PonteiroDois}\n{PonteiroTres}\n{PonteiroCinco}\n";

        public void CalculaHora()
        {
            Console.WriteLine(DateTime.Now);

            var hora = DateTime.Now.Hour > 12 ? DateTime.Now.Hour - 12 : DateTime.Now.Hour;
            var minuto = DateTime.Now.Minute;

            //olhando as horas
            Console.WriteLine(hora);

            hora = PonteiroCinco.ConfiguraCorHora(hora);
            hora = PonteiroTres.ConfiguraCorHora(hora);
            hora = PonteiroDois.ConfiguraCorHora(hora);
            hora = PonteiroUm1.ConfiguraCorHora(hora);
            PonteiroUm2.ConfiguraCorHora(hora);

            //olhando os minutos
            Console.WriteLine(minuto);

            minuto = PonteiroCinco.ConfiguraCorMinuto(minuto);
            minuto = PonteiroTres.ConfiguraCorMinuto(minuto);
            minuto = PonteiroDois.ConfiguraCorMinuto(minuto);
            minuto = PonteiroUm1.ConfiguraCorMinuto(minuto);
            PonteiroUm2.ConfiguraCorMinuto(minuto);
        }
    }
}
