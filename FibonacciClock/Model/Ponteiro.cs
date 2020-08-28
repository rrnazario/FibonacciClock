using System.Drawing;

namespace FibonacciClock.Model
{
    public class Ponteiro
    {
        public int Valor { get; set; }
        public Color Cor { get; set; }

        protected virtual void ConfiguraCorHora()
        {
            if (Cor != Color.Red)
                Cor = Color.Red;
        }

        public int ConfiguraCorHora(int hora)
        {
            if (hora >= Valor)
            {
                ConfiguraCorHora();

                return hora - Valor;
            }
            else
                return hora;
        }

        protected void ConfiguraCorMinuto() => Cor = (Cor == Color.Red) ? Color.Blue : Color.Green;

        public int ConfiguraCorMinuto(int minuto)
        {
            if ((minuto / 5) >= Valor)
            {
                ConfiguraCorMinuto();
                return minuto - (5 * Valor);
            }
            else
                return minuto;
        }

        public override string ToString() => $"{Valor} : {Cor}";
    }
}
