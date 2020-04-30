using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form2 : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Temp\\PizzaApp.accdb");

        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT ID, ElementName, Zutaten, Freddy, Maxi, SuperMaxi, Preis, Photo " +
                "FROM menu ORDER BY ID", conn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);

            dt = new DataTable("menu");
            conn.Open();
            da.Fill(dt);
            conn.Close();

            dv = new DataView(dt);
            dv.Sort = "ID";
            dgvElemente.DataSource = dv;
        }

        private void cmdNeuElement_Click(object sender, EventArgs e)
        {
            drv = dv.AddNew();
            Form3 f3 = new Form3();
            f3.EditElement(drv);
            f3.Dispose();
            dgvElemente.Refresh();
        }

        private void cmdBearbeiten_Click(object sender, EventArgs e)
        {
            drv = dv[dgvElemente.CurrentRow.Index];
            Form3 f3 = new Form3();
            f3.EditElement(drv);
            f3.Dispose();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)
        {
            DataTable dt1 = dt.GetChanges();

            if (!(dt == null))
            {
                try
                {
                    conn.Open();
                    int m = da.Update(dt1);
                    string s = "Anzahl der Änderung: " + m.ToString();
                    MessageBox.Show(s, "Speichern war erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.AcceptChanges();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Speichern fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.RejectChanges();
                }
                dgvElemente.Refresh();
            }
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            if (dv.Count > 0)
            {
                string msg = "Wollen Sie den Menu Element " + dv[dgvElemente.CurrentRow.Index]["ElementName"].ToString() + " wirklich löschen?";
                string cpt = "Menu Element löschen";

                if (MessageBox.Show(msg, cpt, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dv[dgvElemente.CurrentRow.Index].Delete();
            }
            else
                MessageBox.Show("kein Menu Element zum Löschen!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
