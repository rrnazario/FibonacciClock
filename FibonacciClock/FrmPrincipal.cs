using System;
using System.Windows.Forms;

namespace FibonacciClock
{
    public partial class FrmPrincipal : Form
    {
        readonly System.Threading.Timer timer;

        public FrmPrincipal()
        {
            InitializeComponent();

            CalculaHora(this);

            timer = new System.Threading.Timer(CalculaHora, this, 0, (int)new TimeSpan(0, 0, 10).TotalMilliseconds);

            this.FormBorderStyle = FormBorderStyle.None;
        }

        static void CalculaHora(object sender)
        {
            var relogio = new Relogio();
            relogio.CalculaHora();

            var frm = sender as FrmPrincipal;

            frm.btn11.BackColor = frm.btn11.ForeColor = relogio.PonteiroUm1.Cor;
            frm.btn12.BackColor = frm.btn12.ForeColor = relogio.PonteiroUm2.Cor;
            frm.btn2.BackColor = frm.btn2.ForeColor = relogio.PonteiroDois.Cor;
            frm.btn3.BackColor = frm.btn3.ForeColor = relogio.PonteiroTres.Cor;
            frm.btn5.BackColor = frm.btn5.ForeColor = relogio.PonteiroCinco.Cor;

            frm.Invalidate();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FormBorderStyle = (FormBorderStyle == FormBorderStyle.FixedToolWindow)
                ? FormBorderStyle.None
                : FormBorderStyle.FixedToolWindow;
        }
    }
}
