using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Dokumenti : Form
    {
        public Dokumenti()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Povratnica povratnica = new Povratnica();
            povratnica.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Primka primka = new Primka();
            primka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Skladisnica skladisnica = new Skladisnica();
            skladisnica.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvidencijaKontrole evidnecijaKontrole = new EvidencijaKontrole();
            evidnecijaKontrole.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReklamacijskiZapisnik reklamacijskiZapisnik = new ReklamacijskiZapisnik();
            reklamacijskiZapisnik.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otpremnica otpremnica = new Otpremnica();
            otpremnica.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            NalogZaSkladistenje nalogZaSkladistenje = new NalogZaSkladistenje();
            nalogZaSkladistenje.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Predracun predracun = new Predracun();
            predracun.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SkladisniZapisnik skladisniZapisnik = new SkladisniZapisnik();
            skladisniZapisnik.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NalogZaPreuzimanjeRepromaterijala nalogZaPreuzimanjeRepromaterijala = new NalogZaPreuzimanjeRepromaterijala();
            nalogZaPreuzimanjeRepromaterijala.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Izdatnica izdatnica = new Izdatnica();
            izdatnica.Show();
        }

        
    }
}
