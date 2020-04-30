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
    public partial class Form1 : Form
    {
        
        private UserControl2 _userControl2;
        private UserControl3 _userControl3;
        
        public static int warenKorbElements = 0;
        public Form1()
        {
            InitializeComponent();
            //warenCorb = new List<ItemBestellt>();
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxLogo.Image = Properties.Resources.AppLogoNeu;
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            userControl31.StartUp();
            //MessageBox.Show(warenCorb.Count.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user (not system!) wants to close the form
            // but (s)he answered "no", do not close the form
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (warenKorbElements > 1)
                {
                    //e.Cancel = MessageBox.Show(@"Es gibt noch items in Ihre Warenkorb! Möchten Sie wirklich das schließen?",
                    //                           Application.ProductName,
                    //                           MessageBoxButtons.YesNo) == DialogResult.No;
                    string msg = "Es gibt noch items in Ihre Warenkorb! Möchten Sie wirklich das schließen?";
                    string cpt = "Bestellung abbrechen?";
                    if (MessageBox.Show(msg, cpt, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source=C:\\Temp\\PizzaApp.accdb");
                        try
                        {
                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "DELETE FROM warenKorb;";

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
                    else
                    {
                        e.Cancel = true;
                        button3_Click(sender,e);
                    }
                        
                }

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void kucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();
        }
        
        public void InitializeComponents()
        {
            _userControl2 = new UserControl2();
            _userControl3 = new UserControl3();
            _userControl3.Parent = this;
        }

        internal void ResetUserControl2()
        {
            _userControl2.UserControl2_Load(this,new EventArgs());
        }
    }
}
