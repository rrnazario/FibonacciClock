using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FibonacciClock
{
    public class Clock
    {
        public Ponteiro PonteiroUm1 { get; set; }
        public Ponteiro PonteiroUm2 { get; set; }
        public Ponteiro PonteiroDois { get; set; }
        public Ponteiro PonteiroTres { get; set; }
        public Ponteiro PonteiroCinco { get; set; }


        public Clock()
        {
            PonteiroUm1 = new Ponteiro() { Valor = 1, cor = Color.White };
            PonteiroUm2 = new Ponteiro() { Valor = 1, cor = Color.White };
            PonteiroDois = new Ponteiro() { Valor = 2, cor = Color.White };
            PonteiroTres = new Ponteiro() { Valor = 3, cor = Color.White };
            PonteiroCinco = new Ponteiro() { Valor = 5, cor = Color.White };
        }

        public override string ToString()
        {
            return "Ponteiro 1: " + PonteiroUm1.Valor + " : " + PonteiroUm1.cor + "\n" +
                    "Ponteiro 1: " + PonteiroUm2.Valor + " : " + PonteiroUm2.cor + "\n" +
                    "Ponteiro 2: " + PonteiroDois.Valor + " : " + PonteiroDois.cor + "\n" +
                    "Ponteiro 3: " + PonteiroTres.Valor + " : " + PonteiroTres.cor + "\n" +
                    "Ponteiro 5: " + PonteiroCinco.Valor + " : " + PonteiroCinco.cor + "\n";
        }

        public void configHora()
        {
            var HoraAtual = new
            {
                Hora = DateTime.Now.Hour > 12 ? DateTime.Now.Hour - 12 : DateTime.Now.Hour,
                Minuto = DateTime.Now.Minute
            };

            Console.WriteLine(DateTime.Now);

            var hora = HoraAtual.Hora;
            var minuto = HoraAtual.Minuto;

            //olhando as horas
            while (hora > 0)
            {

                if (hora >= 5 && PonteiroCinco.cor != Color.Red)
                {
                    PonteiroCinco.cor = Color.Red;
                    hora -= 5;
                }
                else
                if (hora >= 3 && PonteiroTres.cor != Color.Red)
                {
                    PonteiroTres.cor = Color.Red;
                    hora -= 3;
                }
                else
                if (hora >= 2 && PonteiroDois.cor != Color.Red)
                {
                    PonteiroDois.cor = Color.Red;
                    hora -= 2;
                }
                else
                {
                    if (PonteiroUm1.cor == Color.White)
                        PonteiroUm1.cor = Color.Red;
                    else
                        PonteiroUm2.cor = Color.Red;

                    hora--;
                }
            }

            while (minuto > 0)
            {
                Console.WriteLine(minuto);

                if (((int)minuto / 5) >= 5 && (PonteiroCinco.cor != Color.Blue && PonteiroCinco.cor != Color.Green))
                {
                    if (PonteiroCinco.cor == Color.Red)
                        PonteiroCinco.cor = Color.Blue;
                    else
                        PonteiroCinco.cor = Color.Green;

                    minuto -= 25;
                }
                else
                if (((int)minuto / 5) >= 3 && PonteiroTres.cor != Color.Blue && PonteiroTres.cor != Color.Green)
                {
                    if (PonteiroTres.cor == Color.Red)
                        PonteiroTres.cor = Color.Blue;
                    else
                        PonteiroTres.cor = Color.Green;

                    minuto -= 15;
                }
                else
                if (((int)minuto / 5) >= 2 && PonteiroDois.cor != Color.Blue && PonteiroDois.cor != Color.Green)
                {
                    if (PonteiroDois.cor == Color.Red)
                        PonteiroDois.cor = Color.Blue;
                    else
                        PonteiroDois.cor = Color.Green;

                    minuto -= 10;
                }
                else
                {
                    if (PonteiroUm1.cor != Color.Blue && PonteiroUm1.cor != Color.Green)
                    {
                        if (PonteiroUm1.cor == Color.Red)
                            PonteiroUm1.cor = Color.Blue;
                        else
                            PonteiroUm1.cor = Color.Green;

                    }
                    else
                    if (PonteiroUm2.cor != Color.Blue && PonteiroUm2.cor != Color.Green)
                    {
                        if (PonteiroUm2.cor == Color.Red)
                            PonteiroUm2.cor = Color.Blue;
                        else
                            PonteiroUm2.cor = Color.Green;

                    }

                    minuto -= 5;
                }
            }
        }
    }
}
