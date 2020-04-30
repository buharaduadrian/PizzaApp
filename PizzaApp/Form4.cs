using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form4 : Form
    {
        KundenDaten kd;
        public Form4(KundenDaten kdaten)
        {
            InitializeComponent();
            kd = kdaten;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtVorname.Text) && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                kd.Vorname = txtVorname.Text;
                kd.Name = txtName.Text;

                
                if (cmbZahlungsMethode.SelectedItem != null)
                    kd.ZahlungMethode = cmbZahlungsMethode.SelectedItem.ToString();
                else
                {
                    MessageBox.Show("Bitte wählen Sie eine Zahlungsmethode");
                    cmbZahlungsMethode.Focus();
                }

                if (chkSpeichern.Checked)
                    kd.Speichern = true;
                else
                    kd.Speichern = false;

                if (optLieferung.Checked)
                {
                    kd.Lieferung = "Lieferung";
                    if (!string.IsNullOrWhiteSpace(txtAdresse.Text) && !string.IsNullOrWhiteSpace(txtPLZ.Text) && !string.IsNullOrWhiteSpace(txtOrt.Text))
                    {
                        kd.Adresse = txtAdresse.Text;
                        kd.PLZ = txtPLZ.Text;
                        kd.Ort = txtOrt.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie Ihre Adresse ein!");
                    }
                        
                }
                    
                else
                {
                    kd.Lieferung = "Abholung";
                    Close();
                }
                    
            }
            else
            {
                MessageBox.Show("Bitte geben Sie Ihre Vorname ein");
                txtVorname.Focus();
            }
        }

    

        private void Lieferung_CheckedChanged(object sender, EventArgs e)
        {
            if(optLieferung.Checked)
            {
                txtAdresse.Enabled = true;
                txtPLZ.Enabled = true;
                txtOrt.Enabled = true;
            }
            else
            {
                txtAdresse.Enabled = false;
                txtPLZ.Enabled = false;
                txtOrt.Enabled = false;
            }
        }
    }
}
