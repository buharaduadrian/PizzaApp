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
    public partial class Form5 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Temp\\PizzaApp.accdb");
        
        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;
        public Form5()
        {
            InitializeComponent();
            da = new OleDbDataAdapter("SELECT * FROM bestellungen", conn);

            dt = new DataTable("bestellugen");
            conn.Open();
            da.Fill(dt);
            conn.Close();

            dv = new DataView(dt);
            dgvBestellugen.DataSource = dv;
            
            dgvBestellugen.Refresh();
        }
    }
}
