using FibonacciClock.Model;
using System;
using System.Drawing;

namespace FibonacciClock
{
    public class Relogio
    {
        public Ponteiro PonteiroUm1 { get; set; }
        public Ponteiro PonteiroUm2 { get; set; }
        public Ponteiro PonteiroDois { get; set; }
        public Ponteiro PonteiroTres { get; set; }
        public Ponteiro PonteiroCinco { get; set; }

        public Relogio()
        {
            PonteiroUm1 = new Ponteiro() { Valor = 1, Cor = Color.White };
            PonteiroUm2 = new Ponteiro() { Valor = 1, Cor = Color.White };
            PonteiroDois = new Ponteiro() { Valor = 2, Cor = Color.White };
            PonteiroTres = new Ponteiro() { Valor = 3, Cor = Color.White };
            PonteiroCinco = new Ponteiro() { Valor = 5, Cor = Color.White };
        }

        public override string ToString() => $"{PonteiroUm1}\n{PonteiroUm2}\n{PonteiroDois}\n{PonteiroTres}\n{PonteiroCinco}\n";

        public void CalculaHora()
        {
            Console.WriteLine(DateTime.Now);

            var hora = DateTime.Now.Hour > 12 ? DateTime.Now.Hour - 12 : DateTime.Now.Hour;
            var minuto = DateTime.Now.Minute;

            //olhando as horas
            while (hora > 0)
            {
                Console.WriteLine(hora);

                hora = PonteiroCinco.ConfiguraCorHora(hora);
                hora = PonteiroTres.ConfiguraCorHora(hora);
                hora = PonteiroDois.ConfiguraCorHora(hora);
                hora = PonteiroUm1.ConfiguraCorHora(hora);
                hora = PonteiroUm2.ConfiguraCorHora(hora);
            }

            //olhando os minutos
            while (minuto >= 5)
            {
                Console.WriteLine(minuto);

                minuto = PonteiroCinco.ConfiguraCorMinuto(minuto);
                minuto = PonteiroTres.ConfiguraCorMinuto(minuto);
                minuto = PonteiroDois.ConfiguraCorMinuto(minuto);
                minuto = PonteiroUm1.ConfiguraCorMinuto(minuto);
                minuto = PonteiroUm2.ConfiguraCorMinuto(minuto);
            }
        }
    }
}
