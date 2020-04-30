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
using System.IO;

namespace PizzaApp
{
    public partial class UserControl2 : UserControl
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Temp\\PizzaApp.accdb");
        // Für Menu
        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;
        

        // Für Zutaten
        private OleDbDataAdapter daZutaten = null;
        private DataTable dtZutaten = null;
        private DataView dvZutaten = null;

        public List<string> zutatenExtra = new List<string>();

        public UserControl2()
        {
            InitializeComponent();
        }

        public void AddZutaten()
        {
            daZutaten = new OleDbDataAdapter("SELECT Zutaten FROM menu", conn);

            dtZutaten = new DataTable("zutaten");
            conn.Open();
            daZutaten.Fill(dtZutaten);
            conn.Close();
            dvZutaten = new DataView(dtZutaten);

            string[] rowView;
            foreach (DataRowView drv in dvZutaten)
            {
                rowView = drv["Zutaten"].ToString().Split(',');
                foreach (string zutat in rowView)
                {
                    if (!zutatenExtra.Contains(zutat))
                        zutatenExtra.Add(zutat);
                }
            }
            zutatenExtra.Sort();
        }

        // The Y coodonate. Wie hoch soll die Panels generiert werden.
        private int yPos = 10;

        public void UserControl2_Load(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT ID, ElementName, Zutaten, Freddy, Maxi, Supermaxi, Preis, Photo " +
                "FROM menu ORDER BY ID", conn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);

            dt = new DataTable("menu");
            conn.Open();
            da.Fill(dt);
            conn.Close();

            dv = new DataView(dt);
            dv.Sort = "ID";

            AddZutaten();
            foreach (DataRowView drv in dv)
            {
                GenerateNewPanel(drv);
            }
        }

        private void GenerateNewPanel(DataRowView drv)
        {
            // Panel initialisierung
            Panel newPanel = new Panel()
            {
                Location = new Point(5, yPos),
                Size = new Size(750, 180),
                BackColor = Color.LightGray
            };
            // Checkbox
            CheckBox chk = new CheckBox();

            

            // Pizza label 
            Label labelPizzaName = new Label()
            {
                Text = drv["ElementName"].ToString(),
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Location = new Point(15, 1),
                Size = new Size(300, 20)
            };

            // Pizza bild
            PictureBox pizzaPic = new PictureBox()
            {
                Location = new Point(1, 25),
                Size = new Size(300, 140),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Image = Image.FromFile("C:\\Temp\\Pizza Bilder\\" + drv["Photo"].ToString())
            };

            // Zutaten Label
            Label zutatenLabel = new Label()
            {
                Location = new Point(310, 22),
                Size = new Size(60, 20),
                Font = new Font("Century Gothic", 10, FontStyle.Bold),
                Text = "Zutaten: "
            };
            

            string[] zutaten = drv["Zutaten"].ToString().Split(',');

            ListBox lstBox = new ListBox()
            {
                Location = new Point(310, 42),
                Size = new Size(150, 124),
                Font = new Font("Century Gothic", 8, FontStyle.Bold),
                SelectionMode = SelectionMode.MultiExtended
            };

            foreach (string zutat in zutaten)
            {
                lstBox.Items.Add(zutat);
            }


            Label größeLabel = new Label()
            {
                Location = new Point(600, 120),
                Text = "Größe",
                Font = new Font("Century Gothic", 8, FontStyle.Bold),
            };

            // Große wählen
            ComboBox sizeCMB = new ComboBox()
            {
                Location = new Point(600, 140),
                Font = new Font("Century Gothic", 8, FontStyle.Bold)
            };
            sizeCMB.Items.Add("Freddy");
            sizeCMB.Items.Add("Maxi");
            sizeCMB.Items.Add("Supermaxi");
            sizeCMB.SelectedIndex = 1;

            Label preisLabel = new Label()
            {
                Location = new Point(600, 25),
                Size = new Size(57, 25),
                Font = new Font("Century Gothic", 14, FontStyle.Bold),
                Text = "Preis: "
            };

            Label preisAnzeige = new Label()
            {
                Location = new Point(665, 25),
                Font = new Font("Century Gothic", 14, FontStyle.Bold),
                Size = new Size(70, 25),
                BorderStyle = BorderStyle.Fixed3D
            };

            preisAnzeige.Text = drv["Maxi"].ToString();

            if (!drv["ElementName"].ToString().Contains("Pizza"))
            {
                preisAnzeige.Text = drv["Preis"].ToString();
            }
            else
            {
                sizeCMB.SelectedValueChanged += (s, e) => 
                {
                    if (sizeCMB.SelectedIndex == 0)
                        preisAnzeige.Text = drv["Freddy"].ToString();
                    else if(sizeCMB.SelectedIndex == 1)
                        preisAnzeige.Text = drv["Maxi"].ToString();
                    else if(sizeCMB.SelectedIndex == 2)
                        preisAnzeige.Text = drv["Supermaxi"].ToString();
                };
            }

            Label mengeLabel = new Label()
            {
                Location = new Point(600, 55),
                Size = new Size(60, 25),
                Font = new Font("Century Gothic", 10, FontStyle.Bold),
                Text = "Menge: "
            };

            NumericUpDown numMenge = new NumericUpDown()
            {
                Location = new Point(665, 55),
                Size = new Size(50, 25),
                Minimum = 1,
                Maximum = 10
            };

            Button ohneButton = new Button()
            {
                Location = new Point(465, 41),
                Size = new Size(70, 30),
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Text = "Ohne",
            };

            ohneButton.Click += (s, e) =>
              {
                  ListBox.SelectedObjectCollection zutateLöschen = new ListBox.SelectedObjectCollection(lstBox);
                  zutateLöschen = lstBox.SelectedItems;

                  if (lstBox.SelectedIndex != -1)
                  {
                      for (int i = zutateLöschen.Count - 1; i >= 0; i--)
                          lstBox.Items.Remove(zutateLöschen[i]);
                  }
                  else
                      MessageBox.Show("Bitte wählen Sie ein Zutat zu löschen!", "Kein Zutat gewählt",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
              };

            

            // Extra Zutaten Label
            Label extraZutaten = new Label()
            {
                Location = new Point(465, 73),
                Size = new Size(110, 20),
                Font = new Font("Century Gothic", 10, FontStyle.Bold),
                Text = "Extra Zutat(en): "
            };

            // Extra Zutaten Combobox
            ComboBox extraCMB = new ComboBox()
            {
                Location = new Point(465, 95),
                Font = new Font("Century Gothic", 8, FontStyle.Bold),
                Size = new Size(155, 20),
            };

            foreach (string z in zutatenExtra)
            {
                extraCMB.Items.Add(z);
            }

            Button extraButton = new Button()
            {
                Location = new Point(465, 120),
                Size = new Size(100, 30),
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Text = "Add extra",
            };

            extraButton.Click += (s, e) =>
            {
                if (extraCMB.SelectedIndex != -1)
                {

                    bool gibtEs = false;
                    foreach (string item in lstBox.Items)
                    {
                        if (item.Equals(extraCMB.SelectedItem))
                        {
                            gibtEs = true;
                            break;
                        }
                    }
                    if(gibtEs)
                    {
                        MessageBox.Show("Sie haben schön " + extraCMB.SelectedItem + " gewählt");
                        extraCMB.SelectedItem = null;
                    }
                    else
                    {
                        lstBox.Items.Add(extraCMB.SelectedItem);
                        extraCMB.SelectedItem = null;
                    }
                }
                else
                    MessageBox.Show("Bitte wählen Sie ein extra Zutat!", "Kein extra Zutat gewählt",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            chk.CheckedChanged += (s, e) =>
            {
                KundenDaten ib = new KundenDaten();
                if (chk.Checked)
                {
                    try
                    {
                        numMenge.Enabled = false;
                        extraCMB.Enabled = false;
                        sizeCMB.Enabled = false;
                        string zutatenDB = string.Empty;
                        foreach (var item in lstBox.Items)
                            zutatenDB = string.Concat(zutatenDB, item.ToString(), ",");
                        zutatenDB = zutatenDB.TrimEnd(',');

                        double totalWert = Convert.ToDouble(preisAnzeige.Text) * Convert.ToDouble(numMenge.Value);

                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO warenKorb (ItemName, Zutaten, Preis, Menge, Total) " +
                        "VALUES ('" + drv["ElementName"] + "', '" + zutatenDB + "', '" + preisAnzeige.Text + "', '" + numMenge.Value + "', '" + totalWert + "')";

                        int anzahl = cmd.ExecuteNonQuery();
                        //if(anzahl>0)
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
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM warenKorb WHERE " +
                        "ItemName='" + drv["ElementName"] + "'";

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

                    numMenge.Enabled = true;
                    extraCMB.Enabled = true;
                    sizeCMB.Enabled = true;
                }


            };


            newPanel.Controls.Add(pizzaPic);
            newPanel.Controls.Add(labelPizzaName);
            newPanel.Controls.Add(chk);
            newPanel.Controls.Add(zutatenLabel);
            if (drv["ElementName"].ToString().Contains("Pizza"))
            {
                newPanel.Controls.Add(sizeCMB);
                newPanel.Controls.Add(größeLabel);
            }

            newPanel.Controls.Add(preisLabel);
            newPanel.Controls.Add(lstBox);
            newPanel.Controls.Add(preisAnzeige);
            newPanel.Controls.Add(mengeLabel);
            newPanel.Controls.Add(numMenge);
            newPanel.Controls.Add(ohneButton);
            newPanel.Controls.Add(extraZutaten); 
            newPanel.Controls.Add(extraCMB);
            newPanel.Controls.Add(extraButton);

            Controls.Add(newPanel);
            yPos += newPanel.Height + 10;
        }

    }
    
}
