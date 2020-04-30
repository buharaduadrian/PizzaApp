using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PizzaApp
{
    public partial class UserControl3 : UserControl
    {

        public Form1 Parent { get; set; }
        public static int bNr = 1;
        KundenDaten kd = new KundenDaten();
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Temp\\PizzaApp.accdb");

        // Für Warenkorb
        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;

        // Für Getränke
        private OleDbDataAdapter daGetränke = null;
        private DataTable dtGetränke = null;
        private DataView dvGetränke = null;

        // Für EisUndDesserts
        private OleDbDataAdapter daEisUndD = null;
        private DataTable dtEisUndD = null;
        private DataView dvEisUndD = null;

        public UserControl3()
        {
            InitializeComponent();
            picBoxEisUndDesserts.Image = Properties.Resources.getränke;
            picBoxEisUndDesserts.SizeMode = PictureBoxSizeMode.StretchImage;

            picBoxGetränke.Image = Properties.Resources.eis_und_desserts;
            picBoxGetränke.SizeMode = PictureBoxSizeMode.StretchImage;
            

        }

        

        private void UserControl3_Load(object sender, EventArgs e)
        {
            StartUp();
            dgvWarenKorb.ReadOnly = true;
            dgvWarenKorb.Columns["ItemName"].Width = 100;
            dgvWarenKorb.Columns["Zutaten"].Width = 250;
            dgvWarenKorb.Columns["Preis"].Width = 50;
            dgvWarenKorb.Columns["Preis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvWarenKorb.Columns["Menge"].Width = 50;
            dgvWarenKorb.Columns["Menge"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvWarenKorb.Columns["Total"].Width = 50;
            dgvWarenKorb.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GetränkeUndEisDeserts();
            
        }

        public void StartUp()
        {
            da = new OleDbDataAdapter("SELECT ItemName, Zutaten, Preis, Menge, Total " +
                "FROM warenKorb", conn);


            dt = new DataTable("warenKorb");
            conn.Open();
            da.Fill(dt);
            conn.Close();

            dv = new DataView(dt);
            dgvWarenKorb.DataSource = dv;
            Form1.warenKorbElements = dgvWarenKorb.Rows.Count;
            dgvWarenKorb.Refresh();
            Gesamtbetrag();
        }

        public void GetränkeUndEisDeserts()
        {
            daGetränke = new OleDbDataAdapter("SELECT * FROM getränke", conn);

            dtGetränke = new DataTable("getränke");
            conn.Open();
            daGetränke.Fill(dtGetränke);
            conn.Close();
            dvGetränke = new DataView(dtGetränke);

            foreach (DataRowView drvG in dvGetränke)
            {
                cmbGetränke.Items.Add(drvG["Getränkename"].ToString() + " " + drvG["Größe"].ToString() + "L");
            }

            // ****************************
            daEisUndD = new OleDbDataAdapter("SELECT * FROM eisunddesserts", conn);

            dtEisUndD = new DataTable("eis&desserts");
            conn.Open();
            daEisUndD.Fill(dtEisUndD);
            conn.Close();
            dvEisUndD = new DataView(dtEisUndD);

            foreach (DataRowView drvED in dvEisUndD)
            {
                cmbEisUndDesserts.Items.Add(drvED["EDName"].ToString());
            }
        }

        private void cmdGetränke_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = dvGetränke[cmbGetränke.SelectedIndex];
                string getränkeGröße = "Größe - " + drv["Größe"].ToString() + "gr";
                double totalWert = Convert.ToDouble(drv["Preis"].ToString()) * Convert.ToDouble(numGetränke.Value);
                string itemName = drv["Getränkename"].ToString();
                string preis = drv["Preis"].ToString();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO warenKorb (ItemName, Zutaten, Preis, Menge, Total) " +
                "VALUES (?,?,?,?,?) ";


                cmd.Parameters.AddWithValue("?", itemName);
                cmd.Parameters.AddWithValue("?", getränkeGröße);
                cmd.Parameters.AddWithValue("?", preis);
                cmd.Parameters.AddWithValue("?", numGetränke.Value);
                cmd.Parameters.AddWithValue("?", totalWert.ToString("N2"));


                int anzahl = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            StartUp();
            Gesamtbetrag();
            cmbGetränke.SelectedItem = null;
            numGetränke.Value = numGetränke.Minimum;
        }

        private void cmdEisUndDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = dvEisUndD[cmbEisUndDesserts.SelectedIndex];
                string größe = "Größe - " + drv["Größe"].ToString() + "gr";
                double totalWert = Convert.ToDouble(drv["Preis"].ToString()) * Convert.ToDouble(numEisUndD.Value);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO warenKorb (ItemName, Zutaten, Preis, Menge, Total) " +
                "VALUES (?,?,?,?,?) ";

                cmd.Parameters.AddWithValue("?", drv["EDName"].ToString());
                cmd.Parameters.AddWithValue("?", größe);
                cmd.Parameters.AddWithValue("?", drv["Preis"].ToString());
                cmd.Parameters.AddWithValue("?", numEisUndD.Value);
                cmd.Parameters.AddWithValue("?", totalWert.ToString("N2"));

                int anzahl = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
            StartUp();
            Gesamtbetrag();
            cmbEisUndDesserts.SelectedItem = null;
            numEisUndD.Value = numEisUndD.Minimum;
        }

        public void Gesamtbetrag()
        {


            double sum = 0;
            for (int i = 0; i < dgvWarenKorb.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvWarenKorb.Rows[i].Cells[4].Value);
            }
            lblZahlung.Text = sum.ToString("C2");


        }

        private void cmdItemLöschen_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWarenKorb.SelectedRows)
            {
                if (dgvWarenKorb.Rows[row.Index].Cells[1].Value.ToString().Contains("Größe"))
                {
                    DeleteFromWarenKorb(dgvWarenKorb.Rows[row.Index].Cells[0].Value.ToString(),
                        Convert.ToInt32(dgvWarenKorb.Rows[row.Index].Cells[3].Value));
                    dgvWarenKorb.Rows.RemoveAt(row.Index);
                }
                else
                {
                    MessageBox.Show("Bitte auswählen Sie Ihre Wahl von Menu!");
                    this.SendToBack();
                }

            }
            Gesamtbetrag();
            Form1.warenKorbElements = dgvWarenKorb.Rows.Count;
        }

        private void DeleteFromWarenKorb(string itemName, int menge)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM warenKorb WHERE " +
                "ItemName = ? AND Menge = ?";
                cmd.Parameters.AddWithValue("?", itemName);
                cmd.Parameters.AddWithValue("?", menge);
                //MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                //if (anzahl > 0)
                //    MessageBox.Show("Datensatz gespeichert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void cmdFortfahren_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4(kd);

            f4.Show();
            f4.FormClosed += new FormClosedEventHandler(this.f4_FormClosed);



        }

        private void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            BestellungDateiZumDB();
            MessageBox.Show("Vielen Dank " + kd.Vorname + " für Ihre Bestellung!");
        }

        private void BestellungDateiZumDB()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                string bestellungsNr = "Nr_" + bNr;
                for (int i = 0; i < dgvWarenKorb.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO bestellungen (BestellungsNr, BstUhrzeit, Vorname, Name, Adresse, PLZ, Ort, Zahlung, LiefOderAb, ItemName, Zutaten, Preis, Menge, Total) " +
                    "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?) ";
                    // "VALUES (?,Now(),?,?,?,?,?,?,?) " // simpler alternativ

                    cmd.Parameters.AddWithValue("?", bestellungsNr);
                    cmd.Parameters.AddWithValue("?", GetDateWithoutMilliseconds(DateTime.Now));
                    cmd.Parameters.AddWithValue("?", kd.Vorname);
                    cmd.Parameters.AddWithValue("?", kd.Name);
                    cmd.Parameters.AddWithValue("?", kd.Adresse);
                    cmd.Parameters.AddWithValue("?", kd.PLZ);
                    cmd.Parameters.AddWithValue("?", kd.Ort);
                    cmd.Parameters.AddWithValue("?", kd.ZahlungMethode);
                    cmd.Parameters.AddWithValue("?", kd.Lieferung);
                    cmd.Parameters.AddWithValue("?", dgvWarenKorb.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("?", dgvWarenKorb.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("?", dgvWarenKorb.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(dgvWarenKorb.Rows[i].Cells[3].Value.ToString()));
                    cmd.Parameters.AddWithValue("?", Convert.ToDouble(dgvWarenKorb.Rows[i].Cells[4].Value.ToString()));

                    //dgvWarenKorb.Rows[row.Index].Cells[0].Value.ToString()

                    int anzahl = cmd.ExecuteNonQuery();
                }

                bNr += 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        private void cmdNeueBestellung_Click(object sender, EventArgs e)
        {
            DeleteAllFromWarenkorb();

            WeShoudlResetUserControl();
        }

        private void DeleteAllFromWarenkorb()
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM warenKorb";
                //MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                //if (anzahl > 0)
                //    MessageBox.Show("Datensatz gespeichert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void WeShoudlResetUserControl()
        {
            Parent.ResetUserControl2();
        }
        
    }
}
