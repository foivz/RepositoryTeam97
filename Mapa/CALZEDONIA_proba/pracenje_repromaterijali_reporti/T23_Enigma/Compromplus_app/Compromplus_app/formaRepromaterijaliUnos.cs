﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compromplus_app
{
    public partial class formaRepromaterijaliUnos : Form
    {
       private Repromaterijal azuriraj;
        
        /// <summary>
        /// Otvaramo repromaterijal koji želimo mjenjati/ažurirati u novoj formi
        /// </summary>
        /// <param name="repromaterijal">Repromaterijal koji želimo mjenjati</param>

        public formaRepromaterijaliUnos(Repromaterijal repromaterijal)
        {
            InitializeComponent();
            azuriraj = repromaterijal;        
        }

    

        private void formaRepromaterijaliUnos_Load(object sender, EventArgs e)
        {
            txtIdRepromaterijal.Focus();
            if (azuriraj != null)
            {
                txtIdRepromaterijal.ReadOnly = true;
                txtBoja.Text = azuriraj.boja.ToString();
                txtOpis.Text = azuriraj.opis.ToString();
                txtNaziv.Text = azuriraj.naziv.ToString();           
                txtKolicina.Text = azuriraj.kolicina.ToString();
                txtVelicina.Text = azuriraj.velicina.ToString();
                txtKod.Text = azuriraj.barkod.ToString();
            }
           
        }


        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T23_EnigmaEntities())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase Repromaterijal te ga popunjavamo podacima iz forme
                    Repromaterijal repromaterijal = new Repromaterijal
                    {
                        IdRepromaterijal = int.Parse(txtIdRepromaterijal.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        naziv = txtNaziv.Text,                     
                        kolicina = int.Parse(txtKolicina.Text),
                        velicina= int.Parse(txtVelicina.Text),
                        barkod = int.Parse(txtKod.Text)
                    };

                    db.Repromaterijal.Add(repromaterijal);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći repromaterijal  
                {
                    db.Repromaterijal.Attach(azuriraj); //registriramo postojeći repromaterijal

                    azuriraj.naziv = txtNaziv.Text;
                    azuriraj.boja = txtBoja.Text;
                    azuriraj.opis = txtOpis.Text;
                    azuriraj.kolicina = int.Parse(txtKolicina.Text);
                    azuriraj.velicina= int.Parse(txtVelicina.Text);
                    azuriraj.barkod = int.Parse(txtKod.Text);
                    db.SaveChanges();
                }

            }
            this.Close();
        }
        

       // public Repromaterijal repromaterijal { get; set; }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
