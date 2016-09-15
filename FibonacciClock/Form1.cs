using System;
using System.Threading;
using System.Windows.Forms;

namespace FibonacciClock
{
    public partial class Principal : Form
    {
        static Clock relogio;
        System.Threading.Timer timer;
        bool borderApearing;

        public Principal()
        {
            InitializeComponent();

            relogio = new Clock();
            Hora(this);

            timer = new System.Threading.Timer(Hora, this, 0, (int)(new TimeSpan(0,0,10)).TotalMilliseconds);

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            borderApearing = true;
        }

        static void Hora(object sender)
        {
            relogio = new Clock();
            relogio.configHora();

            (sender as Principal).btn11.BackColor = relogio.PonteiroUm1.cor;
            (sender as Principal).btn12.BackColor = relogio.PonteiroUm2.cor;
            (sender as Principal).btn2.BackColor = relogio.PonteiroDois.cor;
            (sender as Principal).btn3.BackColor = relogio.PonteiroTres.cor;
            (sender as Principal).btn5.BackColor = relogio.PonteiroCinco.cor;

            (sender as Principal).btn11.ForeColor = relogio.PonteiroUm1.cor;
            (sender as Principal).btn12.ForeColor = relogio.PonteiroUm2.cor;
            (sender as Principal).btn2.ForeColor = relogio.PonteiroDois.cor;
            (sender as Principal).btn3.ForeColor = relogio.PonteiroTres.cor;
            (sender as Principal).btn5.ForeColor = relogio.PonteiroCinco.cor;

            (sender as Principal).Invalidate();
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
           // FormBorderStyle = FormBorderStyle.None;            
        }
    }
}
