using System.Drawing;

namespace FibonacciClock.Model
{
    public class Ponteiro
    {
        private int Valor { get; }
        public Color Cor { get; private set; } = Color.White;

        public Ponteiro(int valor) => Valor = valor;

        public int ConfiguraCorHora(int hora)
        {
            if (hora >= Valor)
            {
                Cor = Color.Red;

                return hora - Valor;
            }
            else
                return hora;
        }

        public int ConfiguraCorMinuto(int minuto)
        {
            if ((minuto / 5) >= Valor)
            {
                Cor = (Cor == Color.Red) ? Color.Blue : Color.Green;

                return minuto - (5 * Valor);
            }
            else
                return minuto;
        }

        public override string ToString() => $"{Valor} : {Cor}";
    }
}
