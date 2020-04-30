using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            PictureBoxDefault();
        }
        string pictureName = null;

        public void PictureBoxDefault()
        {
            picBoxElement.Image = Properties.Resources.keinBild;
            picBoxElement.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void EditElement(DataRowView drv)
        {
            if (drv.Row.RowState == DataRowState.Detached)
            {
                txtElementName.Text = "Pizza Neu";
                lstZutaten.Items.Add("Neu Zutat 1");
                lstZutaten.Items.Add("Neu Zutat 2");
                lstZutaten.Items.Add("Neu Zutat 3");

            }
            else
            {
                txtElementName.Text = drv["ElementName"].ToString();
                string[] zutaten = drv["Zutaten"].ToString().Split(',');

                foreach (string zutat in zutaten)
                {
                    lstZutaten.Items.Add(zutat.Trim());
                }
                txtGrößeFreddy.Text = drv["Freddy"].ToString();
                txtGrößeMaxi.Text = drv["Maxi"].ToString();
                txtGrößeSupermaxi.Text = drv["SuperMaxi"].ToString();
                txtBurgersUndSalat.Text = drv["Preis"].ToString();
                if (drv["Photo"].ToString() == "")
                    PictureBoxDefault();
                else
                {
                    //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "\\Pizza Bilder\\" + drv["Photo"].ToString());
                    picBoxElement.Image = Image.FromFile("C:\\Temp\\Pizza Bilder\\" + drv["Photo"].ToString());
                }
            }

            if (this.ShowDialog() == DialogResult.OK) // OK
            {
                // Speichern
                drv.BeginEdit();
                drv["ElementName"] = txtElementName.Text;
                string zutaten = string.Empty;
                foreach (var item in lstZutaten.Items)
                    zutaten = string.Concat(zutaten, item.ToString(), ",");

                zutaten = zutaten.TrimEnd(',');
                drv["Zutaten"] = zutaten;
                drv["Freddy"] = Convert.ToDouble(txtGrößeFreddy.Text);
                drv["Maxi"] = Convert.ToDouble(txtGrößeMaxi.Text);
                drv["SuperMaxi"] = Convert.ToDouble(txtGrößeSupermaxi.Text);

                if (drv["ElementName"].ToString().Contains("Pizza"))
                    drv["Preis"] = Convert.ToDouble("0,00");
                else
                    drv["Preis"] = Convert.ToDouble(txtBurgersUndSalat.Text);

                drv["Photo"] = pictureName;

                drv.EndEdit();
            }
            else
            {
                drv.CancelEdit();
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmdNeuesBild_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Bild öffnen";
                dlg.Filter = "Wählen Sie ein Bild(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBoxElement.Image = Image.FromFile(dlg.FileName);

                    pictureName = Path.GetFileName(dlg.FileName);
                }
            }
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            PictureBoxDefault();
        }

        private void cmdNeueZutat_Click(object sender, EventArgs e)
        {
            lstZutaten.Items.Add(txtNeueZutat.Text);
        }

        private void cmdZutatLöschen_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstZutaten);
            selectedItems = lstZutaten.SelectedItems;

            if (lstZutaten.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstZutaten.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("Bitte wählen Sie ein Zutat zu löschen!", "Kein Zutat gewählt",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
