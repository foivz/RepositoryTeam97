﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPromPlusAplikacija
{
    public partial class formaDjelatniciUnos : Form
    {
        private Djelatnik izmjeniDjelatnika;

        public formaDjelatniciUnos(Djelatnik djelatnik)
        {
            InitializeComponent();
            izmjeniDjelatnika = djelatnik;

            T23_Enigma2Entities db = new T23_Enigma2Entities();

            cboBrojStroja.DataSource = db.Stroj.ToList();
            cboBrojStroja.ValueMember = "Id";
            cboBrojStroja.DisplayMember = "naziv";


        }

        private void formaDjelatniciUnos_Load(object sender, EventArgs e)
        {
            txtIdDjelatnik.Focus();

            if (izmjeniDjelatnika != null)
            {
                txtIdDjelatnik.Enabled = false;
                txtIme.Text = izmjeniDjelatnika.ime.ToString();
                txtPrezime.Text = izmjeniDjelatnika.prezime.ToString();
                txtAdresa.Text = izmjeniDjelatnika.adresa.ToString();
                cboStrucnaSprema.SelectedItem = izmjeniDjelatnika.strucnaSprema.ToString();
            }
        }

        private void picSpremi_Click_1(object sender, EventArgs e)
        {
            using (var db = new T23_Enigma2Entities())
            {
                if (izmjeniDjelatnika == null)
                {
                    Djelatnik djelatnik = new Djelatnik
                    {
                        Id = int.Parse(txtIdDjelatnik.Text),
                        ime = txtIme.Text,
                        prezime = txtPrezime.Text,
                        adresa = txtAdresa.Text,
                        strucnaSprema = cboStrucnaSprema.Text,
                        stroj = int.Parse(cboBrojStroja.SelectedValue.ToString())

                    };

                    db.Djelatnik.Add(djelatnik);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći    
                {
                    db.Djelatnik.Attach(izmjeniDjelatnika); //registriramo postojeći 

                    izmjeniDjelatnika.ime = txtIme.Text;
                    izmjeniDjelatnika.prezime = txtPrezime.Text;
                    izmjeniDjelatnika.adresa = txtAdresa.Text;
                    izmjeniDjelatnika.strucnaSprema = cboStrucnaSprema.Text;
                    izmjeniDjelatnika.stroj = int.Parse(cboStrucnaSprema.SelectedValue.ToString());
                    db.SaveChanges();
                }

            }
            this.Close();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
    }
}
